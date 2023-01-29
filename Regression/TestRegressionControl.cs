using Accord.Math;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class TestRegressionControl : UserControl
    {
        // Field
        private DataTable testDataTable = null;
        
        // Event
        public delegate void ModelTestedEventHandler(ModelTestedEventArgs e);
        public event ModelTestedEventHandler ModelTested;

        // Property
        public DataTable TestDataTable
        {
            set
            {
                testDataTable = value;

                ModelTested(new ModelTestedEventArgs { TestDataset = value });
            }
        }

        // Event handler
        protected virtual void OnModelTested(ModelTestedEventArgs e)
        {
            testDataTable = e.TestDataset;

            int outputColumnIndex = testDataTable.Columns.Count - 2;
            double predictedOutputColumn = testDataTable.Columns.Count - 1;
            int predictedOutputColumnIndex = testDataTable.Columns.Count - 1;

            testDatasetDataGridView.DataSource = testDataTable;
            foreach (DataGridViewRow dataGridViewRow in testDatasetDataGridView.Rows)
                dataGridViewRow.Cells[predictedOutputColumnIndex].Style.BackColor = Color.LightGreen;

            CalculateMetrics();
        }

        // Constructor
        public TestRegressionControl()
        {
            InitializeComponent();

            ModelTested += OnModelTested;
        }

        // Methods
        private void positiveClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (testDataTable == null)
                return;

            CalculateMetrics();
        }

        private void CalculateMetrics()
        {
            double mae = 0;
            double mse = 0;
            double residualSumOfSquares = 0;
            double totalSumOfSquares = 0;
            double rmse = 0;
            double r2 = 0;

            double[] outputColumn = testDataTable.Columns[testDataTable.Columns.Count - 2].ToArray<double>();
            double[] predictedOutputColumn = testDataTable.Columns[testDataTable.Columns.Count - 1].ToArray<double>();
            double observedMean = outputColumn.Average();

            for (int i = 0; i < outputColumn.Length; i++)
            {
                mae += Math.Abs(outputColumn[i] - predictedOutputColumn[i]);
                residualSumOfSquares += Math.Pow(outputColumn[i] - predictedOutputColumn[i], 2);
                totalSumOfSquares += Math.Pow(outputColumn[i] - observedMean, 2);
                mse += Math.Pow(outputColumn[i] - predictedOutputColumn[i], 2);
            }
            mae /= outputColumn.Length;
            mse /= outputColumn.Length;
            rmse = Math.Sqrt(mse);
            r2 = 1f - residualSumOfSquares / totalSumOfSquares;

            meanAbsoluteErrorValueLabel.Text = mae.ToString("f4");
            meanSquareErrorValueLabel.Text = mse.ToString("f4");
            rootMeanSquareErrorValueLabel.Text = rmse.ToString("f4");
            rSquareValueLabel.Text = r2.ToString("f4");
        }

        public void Reset()
        {
            testDataTable = null;
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeRegressionTestResultDialog visualizeRegressionTestResultDialog = new VisualizeRegressionTestResultDialog(testDataTable, "Regression test result");
            visualizeRegressionTestResultDialog.Show(this);
        }
    }
}
