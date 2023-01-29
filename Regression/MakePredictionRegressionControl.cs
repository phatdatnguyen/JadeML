using Accord;
using Accord.IO;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class MakePredictionRegressionControl : UserControl
    {
        // Fields
        private object regressor = null;
        private string[] columnNames = null;
        private DataTable predictionDataset = null;
        private DoubleRange outputRange = new DoubleRange(-1, 1);

        // Properties
        public object Regressor
        {
            set { regressor = value; }
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

        public DoubleRange OutputRange { set { outputRange = value; } }

        // Constructor
        public MakePredictionRegressionControl()
        {
            InitializeComponent();
        }

        // Methods
        private void predictButton_Click(object sender, EventArgs e)
        {
            if (regressor == null)
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

                double predictedValue = 0;
                if (regressor.GetType() == typeof(MultipleLinearRegression))
                {
                    predictedValue = ((MultipleLinearRegression)regressor).Transform(inputs);
                }
                else if (regressor.GetType() == typeof(PolynomialRegression))
                {
                    predictedValue = ((PolynomialRegression)regressor).Transform(inputs[0]);
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine))
                {
                    predictedValue = ((SupportVectorMachine)regressor).Score(inputs);
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    predictedValue = ((SupportVectorMachine<IKernel>)regressor).Score(inputs);
                }
                else if (regressor.GetType() == typeof(ActivationNetwork))
                {
                    DoubleRange unitRange = new DoubleRange(-1, 1);
                    predictedValue = ((ActivationNetwork)regressor).Compute(inputs)[0].Scale(unitRange, outputRange);
                }

                singlePredictionDataGridView.Rows[0].Cells[columnNames.Length - 1].Value = predictedValue;
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        public void UpdatePredictionResult(DataTable predictionDataset, double[] outputColumn)
        {
            this.predictionDataset = predictionDataset.DeepClone();
            this.predictionDataset.Columns.Add(columnNames.Last() + " (predicted)", typeof(double));
            for (int i = 0; i < outputColumn.Length; i++)
                this.predictionDataset.Rows[i][columnNames.Length - 1] = outputColumn[i];

            datasetPredictionDataGridView.Columns.Clear();
            datasetPredictionDataGridView.DataSource = this.predictionDataset;
            for (int i = 0; i < outputColumn.Length; i++)
                datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Style.BackColor = Color.LightGreen;

            visualizeButton.Enabled = true;
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeRegressionDataDialog visualizeRegressionDataDialog = new VisualizeRegressionDataDialog(predictionDataset, "Predicted dataset");
            visualizeRegressionDataDialog.Show(this);
        }
    }
}
