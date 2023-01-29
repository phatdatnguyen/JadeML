using Accord.IO;
using Accord.MachineLearning;
using Accord.Math;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Clustering
{
    public partial class MakePredictionClusteringControl : UserControl
    {
        // Fields
        private object clusterer = null;
        private string[] columnNames = null;
        private DataTable predictionDataset = null;

        // Properties
        public object Clusterer
        {
            set { clusterer = value; }
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
        public MakePredictionClusteringControl()
        {
            InitializeComponent();
        }

        // Methods
        private void predictButton_Click(object sender, EventArgs e)
        {
            if (clusterer == null)
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

                double predictedClusterIndex = 0;
                if (clusterer.GetType() == typeof(KMeans))
                    predictedClusterIndex = ((KMeans)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(KMedoids))
                    predictedClusterIndex = ((KMedoids)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(BinarySplit))
                    predictedClusterIndex = ((BinarySplit)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                    predictedClusterIndex = ((GaussianMixtureModel)clusterer).Gaussians.Decide(inputs);
                else if (clusterer.GetType() == typeof(MeanShift))
                    predictedClusterIndex = ((MeanShift)clusterer).Clusters.Decide(inputs);

                singlePredictionDataGridView.Rows[0].Cells[columnNames.Length - 1].Value = "Cluster " + (predictedClusterIndex + 1).ToString();
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        public void UpdatePredictionResult(DataTable predictionDataset, int[] clusterIndexColumn)
        {
            this.predictionDataset = predictionDataset.DeepClone();
            this.predictionDataset.Columns.Add(columnNames.Last() + " (predicted)", typeof(string));
            for (int i = 0; i < clusterIndexColumn.Length; i++)
                this.predictionDataset.Rows[i][columnNames.Length - 1] = "Cluster " + (clusterIndexColumn[i] + 1).ToString();

            datasetPredictionDataGridView.Columns.Clear();
            datasetPredictionDataGridView.DataSource = this.predictionDataset;
            for (int i = 0; i < clusterIndexColumn.Length; i++)
                datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Style.BackColor = Color.LightGreen;

            visualizeButton.Enabled = true;
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            int numberOfCluster = predictionDataset.Columns[predictionDataset.Columns.Count - 1].ToArray<string>().Distinct().Length;
            if (numberOfCluster > 10)
            {
                MessageBox.Show(this, "Cannot visualize data with too many clusters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VisualizeClusteringDataDialog visualizeClusteringDataDialog = new VisualizeClusteringDataDialog(predictionDataset, "Predicted dataset", true);
            visualizeClusteringDataDialog.Show(this);
        }
    }
}
