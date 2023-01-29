using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Pruning;
using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class DecisionTreeModelControl : UserControl
    {
        // Fields
        private DecisionTree decisionTree = null;
        private string[] features = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private double[][] trainingInputColumns = null;
        private int[] trainingClassIndexColumn = null;

        // Event
        public delegate void ModelModifiedEventHandler(ModelModifiedEventArgs e);
        public event ModelModifiedEventHandler ModelModified;

        // Constructor
        public DecisionTreeModelControl(DecisionTree decisionTree, double[][] trainingInputColumns, int[] trainingClassIndexColumn, string[] features, Dictionary<int, string> classes)
        {
            InitializeComponent();

            pruningMethodComboBox.SelectedIndex = 0;

            this.decisionTree = decisionTree;
            this.trainingInputColumns = trainingInputColumns;
            this.trainingClassIndexColumn = trainingClassIndexColumn;
            this.features = features;
            this.classes = classes;

            updateDecisionTreeLayout(decisionTree);
        }

        // Methods
        private void pruneButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                if (pruningMethodComboBox.SelectedItem.ToString() == "Error-Based Pruning")
                {
                    ErrorBasedPruning prune = new ErrorBasedPruning(decisionTree, trainingInputColumns, trainingClassIndexColumn)
                    {
                        Threshold = (double)pruningThresholdNumericUpDown.Value
                    };

                    double lastError;
                    double error = Double.PositiveInfinity;
                    do
                    {
                        lastError = error;
                        error = prune.Run();
                    }
                    while (error < lastError);
                }
                else //pruningMethodComboBox.SelectedItem.ToString() == "Reduced Error Pruning"
                {
                    ReducedErrorPruning prune = new ReducedErrorPruning(decisionTree, trainingInputColumns, trainingClassIndexColumn);

                    double lastError;
                    double error = Double.PositiveInfinity;
                    do
                    {
                        lastError = error;
                        error = prune.Run();
                    }
                    while (error < lastError);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Arrow;
                return;
            }

            updateDecisionTreeLayout(decisionTree);

            Cursor = Cursors.Arrow;

            ModelModified(new ModelModifiedEventArgs { Model = decisionTree });
        }

        private void updateDecisionTreeLayout(DecisionTree decisionTree)
        {
            decisionTreeDiagram.ClearAll();

            ShapeNode rootNode = decisionTreeDiagram.Factory.CreateShapeNode(5, 5, 20, 10, Shapes.Rectangle);
            rootNode.Text = "Root";
            rootNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Brown);
            rootNode.EnabledHandles = AdjustmentHandles.Move;

            if (decisionTree.Root.IsLeaf)
            {
                int classIndex = (int)decisionTree.Root.Output;
                ShapeNode outputNode = decisionTreeDiagram.Factory.CreateShapeNode(5, 5, 40, 10, Shapes.RoundRect);
                outputNode.Text = classes[classIndex];
                outputNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Magenta);
                outputNode.EnabledHandles = AdjustmentHandles.Move;
                DiagramLink link = decisionTreeDiagram.Factory.CreateDiagramLink(rootNode, outputNode);
                link.AllowMoveStart = false;
                link.AllowMoveEnd = false;

                return;
            }

            rootNode.Tag = decisionTree.Root;
            foreach (DecisionNode decisionNode in decisionTree.Root.Branches)
            {
                ShapeNode branchNode = convertToBranchNode(decisionNode);
                DiagramLink link = decisionTreeDiagram.Factory.CreateDiagramLink(rootNode, branchNode);
                link.AllowMoveStart = false;
                link.AllowMoveEnd = false;
            }

            decisionTreeDiagram.Arrange(decisionTreeLayout);
        }

        private ShapeNode convertToBranchNode(DecisionNode parentNode)
        {
            string feature = features[parentNode.Parent.Branches.AttributeIndex];
            string comparison = "";
            switch (parentNode.Comparison)
            {
                case ComparisonKind.Equal:
                    comparison = "=";
                    break;
                case ComparisonKind.NotEqual:
                    comparison = "<>";
                    break;
                case ComparisonKind.GreaterThan:
                    comparison = ">";
                    break;
                case ComparisonKind.GreaterThanOrEqual:
                    comparison = ">=";
                    break;
                case ComparisonKind.LessThan:
                    comparison = "<";
                    break;
                case ComparisonKind.LessThanOrEqual:
                    comparison = "<=";
                    break;
            }

            ShapeNode parentShapeNode = decisionTreeDiagram.Factory.CreateShapeNode(5, 5, 40, 10, Shapes.Octagon);
            parentShapeNode.Text = feature + " " + comparison + " " + Math.Round((double)parentNode.Value, 3).ToString();
            parentShapeNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Cyan);
            parentShapeNode.EnabledHandles = AdjustmentHandles.Move;

            if (!parentNode.IsLeaf)
            {
                foreach (DecisionNode childDecisionNode in parentNode.Branches)
                {
                    ShapeNode childShapeNode = convertToBranchNode(childDecisionNode);
                    DiagramLink link = decisionTreeDiagram.Factory.CreateDiagramLink(parentShapeNode, childShapeNode);
                    link.AllowMoveStart = true;
                    link.AllowMoveEnd = true;
                }
            }
            else
            {
                int classIndex = (int)parentNode.Output;
                ShapeNode outputNode = decisionTreeDiagram.Factory.CreateShapeNode(5, 5, 40, 10, Shapes.RoundRect);
                outputNode.Text = classes[classIndex];
                outputNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Magenta);
                outputNode.EnabledHandles = AdjustmentHandles.Move;
                DiagramLink link = decisionTreeDiagram.Factory.CreateDiagramLink(parentShapeNode, outputNode);
                link.AllowMoveStart = true;
                link.AllowMoveEnd = true;
            }

            return parentShapeNode;
        }

        // Diagram
        private void decisionTreeDiagram_NodeDeleting(object sender, NodeValidationEventArgs e)
        {
            e.Cancel = true;
        }

        private void decisionTreeDiagram_LinkDeleting(object sender, LinkValidationEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
