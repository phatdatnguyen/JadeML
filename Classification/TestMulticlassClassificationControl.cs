using Accord.Controls;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class TestMulticlassClassificationControl : UserControl
    {
        // Fields
        private DataTable testDataTable = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        
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
            int predictedOutputColumnIndex = testDataTable.Columns.Count - 1;
            string[] outputColumn = testDataTable.Columns[outputColumnIndex].ToArray<string>();
            string[] predictedOutputColumn = testDataTable.Columns[predictedOutputColumnIndex].ToArray<string>();
            string[] classLabels = outputColumn.Distinct().OrderBy(x => x).ToArray();
            classes = new Dictionary<int, string>();
            for (int i = 0; i < classLabels.Length; i++)
                classes.Add(i, classLabels[i]);

            testDatasetDataGridView.DataSource = testDataTable;
            foreach (DataGridViewRow dataGridViewRow in testDatasetDataGridView.Rows)
                if (dataGridViewRow.Cells[outputColumnIndex].Value.ToString() == dataGridViewRow.Cells[predictedOutputColumnIndex].Value.ToString())
                    dataGridViewRow.Cells[predictedOutputColumnIndex].Style.BackColor = Color.LightGreen;
                else
                    dataGridViewRow.Cells[predictedOutputColumnIndex].Style.BackColor = Color.Red;

            int[][] confusionMatrix = new int[classLabels.Length][];
            for (int rowIndex = 0; rowIndex < confusionMatrix.Length; rowIndex++)
            {
                confusionMatrix[rowIndex] = new int[classLabels.Length];

                for (int columnIndex = 0; columnIndex < confusionMatrix.Length; columnIndex++)
                    confusionMatrix[rowIndex][columnIndex] = 0;
            }

            for (int i = 0; i < outputColumn.Length; i++)
            {
                int actualClassIndex = classLabels.IndexOf(outputColumn[i]);
                int predictedClassIndex = classLabels.IndexOf(predictedOutputColumn[i]);
                confusionMatrix[actualClassIndex][predictedClassIndex] += 1;
            }

            string[][] confusionMatrixTable = new string[classLabels.Length + 2][];
            for (int rowIndex = 0; rowIndex < confusionMatrixTable.Length; rowIndex++)
            {
                confusionMatrixTable[rowIndex] = new string[classLabels.Length + 2];

                for (int columnIndex = 0; columnIndex < confusionMatrixTable.Length; columnIndex++)
                {
                    if (rowIndex == 0 || columnIndex == 0) // Label columns & rows
                    {
                        if (rowIndex == 0 && columnIndex == 0)
                            confusionMatrixTable[rowIndex][columnIndex] = "Class";

                        if (rowIndex == 0 && columnIndex != 0)
                        {
                            if (columnIndex <= classLabels.Length)
                                confusionMatrixTable[rowIndex][columnIndex] = classLabels[columnIndex - 1];
                            else
                                confusionMatrixTable[rowIndex][columnIndex] = "Total";
                        }
                            
                        if (rowIndex != 0 && columnIndex == 0)
                        {
                            if (rowIndex <= classLabels.Length)
                                confusionMatrixTable[rowIndex][columnIndex] = classLabels[rowIndex - 1];
                            else
                                confusionMatrixTable[rowIndex][columnIndex] = "Total";
                        }
                    }
                    else if (rowIndex <= classLabels.Length) // Class label count rows
                    {
                        if (columnIndex <= classLabels.Length)
                            confusionMatrixTable[rowIndex][columnIndex] = confusionMatrix[rowIndex - 1][columnIndex - 1].ToString();
                        else // Total column
                            confusionMatrixTable[rowIndex][columnIndex] = confusionMatrix[rowIndex - 1].Sum().ToString();
                    }
                    else if (columnIndex <= classLabels.Length) // Total row
                    {
                        confusionMatrixTable[rowIndex][columnIndex] = confusionMatrix[columnIndex - 1].Sum().ToString();
                    }
                    else
                    {
                        confusionMatrixTable[rowIndex][columnIndex] = outputColumn.Length.ToString();
                    }
                }
            }

            confusionMatrixDataGridView.DataSource = new ArrayDataView(confusionMatrixTable);

            int correctCount = 0;
            for (int i = 0; i < outputColumn.Length; i++)
                if (predictedOutputColumn[i] == outputColumn[i])
                    correctCount++;

            accuracyValueLabel.Text = ((correctCount + 0f) / outputColumn.Length).ToString("p2");
        }

        // Constructor
        public TestMulticlassClassificationControl()
        {
            InitializeComponent();

            ModelTested += OnModelTested;
        }

        // Methods
        private void visualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationTestResultDialog visualizeClassificationTestResultDialog = new VisualizeClassificationTestResultDialog(testDataTable, "Classification test result");
            visualizeClassificationTestResultDialog.Show(this);
        }
    }
}
