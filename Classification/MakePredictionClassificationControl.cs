using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class MakePredictionClassificationControl : UserControl
    {
        // Fields
        private object classifier = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private string[] columnNames = null;
        private DataTable predictionDataset = null;

        // Properties
        public object Classifier
        {
            set { classifier = value; }
        }

        public Dictionary<int, string> Classes
        { 
            set { classes = value; }
        }

        public string[] ColumnNames
        {
            set
            {
                columnNames = value;
                singlePredictionDataGridView.Columns.Clear();
                foreach (string columnName in columnNames)
                    singlePredictionDataGridView.Columns.Add(columnName, columnName);
                singlePredictionDataGridView.Columns[singlePredictionDataGridView.Columns.Count - 1].Name += " (predicted)";
                singlePredictionDataGridView.Columns[singlePredictionDataGridView.Columns.Count - 1].ReadOnly = true;
                singlePredictionDataGridView.Rows.Add();
                singlePredictionDataGridView.Rows[0].Cells[singlePredictionDataGridView.Columns.Count - 1].Style.BackColor = Color.LightGreen;
            }
        }

        // Constructor
        public MakePredictionClassificationControl()
        {
            InitializeComponent();
        }

        // Methods
        private void predictButton_Click(object sender, EventArgs e)
        {
            if (classifier == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                double[] inputs = new double[columnNames.Length - 1];
                for (int i = 0; i < columnNames.Length - 1; i++)
                    inputs[i] = Convert.ToDouble(singlePredictionDataGridView.Rows[0].Cells[i].Value);

                int classIndex = -1;
                if (classifier.GetType() == typeof(LogisticRegression))
                {
                    bool predictedValue = ((LogisticRegression)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(MultinomialLogisticRegression))
                {
                    classIndex = ((MultinomialLogisticRegression)classifier).Decide(inputs);
                }
                else if(classifier.GetType() == typeof(KNearestNeighbors))
                {
                    classIndex = ((KNearestNeighbors)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                {
                    classIndex = ((MinimumMeanDistanceClassifier)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                {
                    classIndex = ((NaiveBayes<NormalDistribution>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(DecisionTree))
                {
                    classIndex = ((DecisionTree)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(RandomForest))
                {
                    classIndex = ((RandomForest)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    bool predictedValue = ((SupportVectorMachine<IKernel>)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    bool predictedValue = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine))
                {
                    bool predictedValue = ((SupportVectorMachine)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
                {
                    classIndex = ((MulticlassSupportVectorMachine<IKernel>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    classIndex = ((MulticlassSupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<Linear>))
                {
                    classIndex = ((MulticlassSupportVectorMachine<Linear>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(ActivationNetwork))
                {
                    double[] output = ((ActivationNetwork)classifier).Compute(inputs);
                    classIndex = output.IndexOf(output.Max());
                }

                singlePredictionDataGridView.Rows[0].Cells[columnNames.Length - 1].Value = classes[classIndex];
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        public void UpdatePredictionResult(DataTable predictionDataset, int[] classIndexColumn)
        {
            this.predictionDataset = predictionDataset.DeepClone();
            this.predictionDataset.Columns.Add(columnNames.Last() + " (predicted)", typeof(string));
            for (int i = 0; i < classIndexColumn.Length; i++)
                this.predictionDataset.Rows[i][columnNames.Length - 1] = classes[classIndexColumn[i]];

            datasetPredictionDataGridView.Columns.Clear();
            datasetPredictionDataGridView.DataSource = this.predictionDataset;
            for (int i = 0; i < classIndexColumn.Length; i++)
                datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Style.BackColor = Color.LightGreen;

            visualizeButton.Enabled = true;
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(predictionDataset, "Predicted dataset");
            visualizeClassificationDataDialog.Show(this);
        }
    }
}
