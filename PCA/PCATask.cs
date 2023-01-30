using Accord;
using Accord.IO;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Kernels;
using MindFusion.Diagramming;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace JadeML.PCA
{
    public partial class PCATask : Form
    {
        // Fields
        private KernelPrincipalComponentAnalysis kpca = null;
        private string[] features = null;
        private string[] pcs = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private DataTable projectedTrainingDataset = null;

        private DataTable predictionDataset = null;
        private DataTable projectedPreditionDataset = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsTrainingDatasetLoaded { get { return trainingDataset != null; } }
        public bool IsPredictionDatasetLoaded { get { return predictionDataset != null; } }
        public bool IsModelLoaded { get { return true; } }
        public bool IsModelTrained { get { return modelTrained; } }

        // Event
        public delegate void TrainingDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event TrainingDataLoadedEventHandler TrainingDatasetLoaded;
        public delegate void PredictionDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event PredictionDataLoadedEventHandler PredictionDatasetLoaded;
        public delegate void ModelLoadedEventHandler(EventArgs e);
        public event ModelLoadedEventHandler ModelLoaded;
        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public PCATask()
        {
            InitializeComponent();

            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += (EventArgs e) => { return; };
            ModelTrained += onModelTrained;
        }

        public PCATask(object model, DataTable trainingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += (EventArgs e) => { return; };
            ModelTrained += onModelTrained;

            TrainingDatasetLoaded(new DatasetLoadedEventArgs { Dataset = trainingDataset });

            SetLearningParameters(serializedLearningParameters);

            ModelTrained(new ModelTrainedEventArgs() { Model = model });
        }

        // Form event handlers
        private void BinaryClassificationTask_Load(object sender, EventArgs e)
        {
            ShapeNode trainingDatasetNode = taskDiagram.Factory.CreateShapeNode(5, 5, 20, 10, Shapes.Rectangle);
            trainingDatasetNode.Text = "Training dataset";
            trainingDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            ShapeNode modelNode = taskDiagram.Factory.CreateShapeNode(55, 5, 30, 10, Shapes.Cube);
            modelNode.Text = "PCA";
            modelNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Cyan);
            modelNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link1 = taskDiagram.Factory.CreateDiagramLink(trainingDatasetNode, modelNode);
            link1.AllowMoveStart = false;
            link1.AllowMoveEnd = false;

            ShapeNode projectionNode = taskDiagram.Factory.CreateShapeNode(105, 5, 30, 10, Shapes.RoundRect);
            projectionNode.Text = "Projection\n(training dataset)";
            projectionNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Orange);
            projectionNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link2 = taskDiagram.Factory.CreateDiagramLink(modelNode, projectionNode);
            link2.AllowMoveStart = false;
            link2.AllowMoveEnd = false;

            ShapeNode predictionNode = taskDiagram.Factory.CreateShapeNode(55, 25, 30, 10, Shapes.RoundRect);
            predictionNode.Text = "Projection\n(prediction dataset)";
            predictionNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Orange);
            predictionNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link3 = taskDiagram.Factory.CreateDiagramLink(modelNode, predictionNode);
            link3.AllowMoveStart = false;
            link3.AllowMoveEnd = false;

            ShapeNode predictionDatasetNode = taskDiagram.Factory.CreateShapeNode(5, 25, 20, 10, Shapes.Rectangle);
            predictionDatasetNode.Text = "Prediction dataset";
            predictionDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link4 = taskDiagram.Factory.CreateDiagramLink(predictionDatasetNode, predictionNode);
            link4.AllowMoveStart = false;
            link4.AllowMoveEnd = false;

            methodComboBox.SelectedIndex = 0;
        }

        private void BinaryClassificationTask_Resize(object sender, EventArgs e)
        {
            taskSplitContainer.Height = Height - 64;
        }
        
        private void BinaryClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (kpca != null && modelTrained)
            {
                switch (MessageBox.Show(mainForm, "Do you want to save this task?", "Save task", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        mainForm.SaveCurrentModel();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
        }

        public void SaveModel(string filePath)
        {
            if (!modelTrained || kpca == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 4; // pca
                    byte modelIndex = 0;

                    kpca.Save(out byte[] serializedModel);
                    int modelSize = serializedModel.Length;

                    int dataSize = 0;

                    byte[] serializedTrainingDataset = null;
                    int trainingDatasetSize = 0;
                    if (trainingDataset != null)
                    {
                        trainingDataset.Save(out serializedTrainingDataset);
                        trainingDatasetSize = serializedTrainingDataset.Length;
                    }

                    int testDataSize = 0;

                    binaryWriter.Write(taskIndex);
                    binaryWriter.Write(modelIndex);
                    binaryWriter.Write(serializedLearningParameters);
                    binaryWriter.Write(modelSize);
                    binaryWriter.Write(serializedModel);
                    binaryWriter.Write(dataSize);
                    binaryWriter.Write(trainingDatasetSize);
                    binaryWriter.Write(serializedTrainingDataset);
                    binaryWriter.Write(testDataSize);
                }
            }
        }

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int kernel = 0;
            if (gaussianKernelRadioButton.Checked)
                kernel = 1;
            else if (laplacianKernelRadioButton.Checked)
                kernel = 2;
            else if (sigmoidKernelRadioButton.Checked)
                kernel = 3;
            learningParameters.Add("kernel", kernel.ToString());
            learningParameters.Add("polynomial degree", polynomialDegreeNumericUpDown.Value.ToString());
            learningParameters.Add("polynomial constant", polynomialConstantNumericUpDown.Value.ToString());
            learningParameters.Add("gaussian sigma", gaussianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("laplacian sigma", laplacianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid alpha", sigmoidAlphaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid constant", sigmoidConstantNumericUpDown.Value.ToString());
            learningParameters.Add("method", methodComboBox.SelectedIndex.ToString());
            learningParameters.Add("number of components", numberOfComponentsNumericUpDown.Value.ToString());
            learningParameters.Add("centering", centeringCheckBox.Checked.ToString());
            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);

            int kernel = Convert.ToInt32(learningParameters["kernel"]);
            if (kernel == 1)
                gaussianKernelRadioButton.Checked = true;
            else if (kernel == 2)
                laplacianKernelRadioButton.Checked = true;
            else if (kernel == 3)
                sigmoidKernelRadioButton.Checked = true;
            polynomialDegreeNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial degree"]);
            polynomialConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial constant"]);
            gaussianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["gaussian sigma"]);
            laplacianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["laplacian sigma"]);
            sigmoidAlphaNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid alpha"]);
            sigmoidConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid constant"]);
            methodComboBox.SelectedIndex = Convert.ToInt32(learningParameters["method"]);
            numberOfComponentsNumericUpDown.Value = Convert.ToDecimal(learningParameters["number of components"]);
            centeringCheckBox.Checked = Convert.ToBoolean(learningParameters["centering"]);
        }

        // Diagram
        private void taskDiagram_SelectionChanged(object sender, EventArgs e)
        {
            if (taskDiagram.ActiveItem == null || taskDiagram.ActiveItem.GetType() != typeof(ShapeNode))
                return;

            ShapeNode activeNode = (ShapeNode)taskDiagram.ActiveItem;
            switch (activeNode.Text)
            {
                case "Training dataset":
                    datasetLabel.Text = "Training dataset";
                    datasetDataGridView.DataSource = null;
                    if (trainingDataset != null)
                        datasetDataGridView.DataSource = trainingDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Prediction dataset":
                    datasetLabel.Text = "Prediction dataset";
                    datasetDataGridView.DataSource = null;
                    if (predictionDataset != null)
                        datasetDataGridView.DataSource = predictionDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Projection\n(training dataset)":
                    datasetLabel.Text = "Projected training dataset";
                    datasetDataGridView.DataSource = null;
                    if (projectedTrainingDataset != null)
                        datasetDataGridView.DataSource = projectedTrainingDataset;
                    else
                        return;
                    taskTabControl.SelectTab(0);
                    break;
                case "PCA":
                    taskTabControl.SelectTab(1);
                    break;
                case "Projection\n(prediction dataset)":
                    taskTabControl.SelectTab(2);
                    break;
            }
        }

        private void taskDiagram_NodeDeleting(object sender, NodeValidationEventArgs e)
        {
            e.Cancel = true;
        }

        private void taskDiagram_LinkDeleting(object sender, LinkValidationEventArgs e)
        {
            e.Cancel = true;
        }

        // Load data
        public void LoadTrainingDataset(DataTable dataset)
        {
            TrainingDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnTrainingDatasetLoaded(DatasetLoadedEventArgs e)
        {
            trainingDataset = e.Dataset;

            DataTable trainingDataTable = e.Dataset.DeepClone();
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            if (features == null)
            {
                features = new string[trainingDataset.Columns.Count];
                for (int i = 0; i < features.Length; i++)
                    features[i] = trainingDataset.Columns[i].ColumnName;
            }

            if (datasetLabel.Text == "Training dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = trainingDataset;
            }

            numberOfComponentsNumericUpDown.Maximum = features.Length;
            numberOfComponentsNumericUpDown.Value = features.Length;

            modelTableLayoutPanel.Enabled = true;
            ModelLoaded(EventArgs.Empty);
        }

        public void LoadPredictionDataset(DataTable dataset)
        {
            PredictionDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnPredictionDatasetLoaded(DatasetLoadedEventArgs e)
        {
            predictionDataset = e.Dataset;

            if (datasetLabel.Text == "Prediction dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = predictionDataset;
            }
        }

        private void datasetVisualizeButton_Click(object sender, EventArgs e)
        {
            if (datasetLabel.Text == "Training dataset" && trainingDataset != null)
            {
                VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(trainingDataset, "Training dataset");
                visualizeDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Prediction dataset" && predictionDataset != null)
            {
                VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(predictionDataset, "Prediction dataset");
                visualizeDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Projected training dataset" && projectedTrainingDataset != null)
            {
                VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(projectedTrainingDataset, "Projected training dataset");
                visualizeDataDialog.Show(this);
            }
        }

        // Kernel
        private IKernel createKernel()
        {
            if (gaussianKernelRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);
            else if (polynomialKernelRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }
            else if (laplacianKernelRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);
            else // sigmoidKernelRadioButton.Checked
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = Gaussian.Estimate(trainingInputColumns, trainingInputColumns.Length);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = Laplacian.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            Sigmoid sigmoid = Sigmoid.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }
        
        // Training
        public void TrainModel()
        {
            if (trainingInputColumns == null)
            {
                MessageBox.Show(this, "Training dataset cannot be empty!", "Training dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modelTabPage.BackColor = SystemColors.Control;
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            KernelPrincipalComponentAnalysis kpca = null;
            IKernel kernel = createKernel();
            try
            {
                switch (methodComboBox.SelectedItem.ToString())
                {
                    case "Center":
                        kpca = new KernelPrincipalComponentAnalysis(kernel, PrincipalComponentMethod.Center);
                        break;
                    case "Standardize":
                        kpca = new KernelPrincipalComponentAnalysis(kernel, PrincipalComponentMethod.Standardize);
                        break;
                }
                kpca.NumberOfOutputs = Convert.ToInt32(numberOfComponentsNumericUpDown.Value);
                kpca.Center = centeringCheckBox.Checked;
                kpca.Learn(trainingInputColumns);

                ModelTrained(new ModelTrainedEventArgs() { Model = kpca });
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Default;
            }
        }

        private void onModelTrained(ModelTrainedEventArgs e)
        {
            kpca = (KernelPrincipalComponentAnalysis)e.Model;

            serializedLearningParameters = GetLearningParameters();

            modelTrained = true;

            pcs = new string[kpca.Components.Count];
            principalComponentComboBox.Items.Clear();
            for (int i = 0; i < kpca.Components.Count; i++)
            {
                pcs[i] = "PC" + (i + 1).ToString();
                principalComponentComboBox.Items.Add("PC" + (i + 1).ToString());
            }
            principalComponentComboBox.SelectedIndex = 0;

            principleComponentsGroupBox.Enabled = true;

            double[][] projectionResult = kpca.Transform(trainingInputColumns);
            projectedTrainingDataset = projectionResult.ToTable(pcs);

            singleProjectionInputDataGridView.Columns.Clear();
            foreach (string feature in features)
                singleProjectionInputDataGridView.Columns.Add(feature, feature);
            singleProjectionInputDataGridView.Rows.Add();

            singleProjectionPCDataGridView.Columns.Clear();
            foreach (string pc in pcs)
                singleProjectionPCDataGridView.Columns.Add(pc, pc);
            singleProjectionPCDataGridView.Rows.Add();

            singleProjectionGroupBox.Enabled = true;
            datasetProjectionGroupBox.Enabled = true;

            modelTabPage.BackColor = Color.LightGreen;
            taskTabControl.SelectTab(1);

            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }

        // PCs
        private void principalComponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!modelTrained)
                return;

            PrincipalComponent component = kpca.Components[principalComponentComboBox.SelectedIndex];
            eigenvalueTextBox.Text = component.Eigenvalue.ToString();
            proportionTextBox.Text = component.Proportion.ToString();
            eigenvectorDataGridView.DataSource = component.Eigenvector.ToJagged().ToTable();
        }

        // Prediction
        private void projectButton_Click(object sender, EventArgs e)
        {
            if (kpca == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                double[] inputs = new double[features.Length];
                for (int i = 0; i < features.Length; i++)
                    inputs[i] = Convert.ToDouble(singleProjectionInputDataGridView.Rows[0].Cells[i].Value);

                double[] projectedData = kpca.Transform(inputs);
                for (int i = 0; i < pcs.Length; i++)
                    singleProjectionPCDataGridView.Rows[0].Cells[i].Value = projectedData[i].ToString();

                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        public void MakeDatasetPrediction()
        {
            if (kpca == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (predictionDataset == null)
            {
                MessageBox.Show(this, "Prediction dataset cannot be empty!", "Prediction dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (predictionDataset.Columns.Count != trainingDataset.Columns.Count)
            {
                MessageBox.Show(this, "Prediction dataset does not match training dataset!", "Prediction dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            taskTabControl.SelectTab(2);
            Cursor = Cursors.WaitCursor;

            try
            {
                double[][] inputColumns = predictionDataset.ToMatrix().ToJagged();

                projectedPreditionDataset = kpca.Transform(inputColumns).ToTable(pcs);
                datasetProjectionDataGridView.DataSource = null;
                datasetProjectionDataGridView.DataSource = projectedPreditionDataset;

                visualizeProjectedDataButton.Enabled = true;
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        private void visualizeProjectedDataButton_Click(object sender, EventArgs e)
        {
            VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(projectedPreditionDataset, "Projected prediction dataset");
            visualizeDataDialog.Show(this);
        }
    }
}
