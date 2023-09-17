using Accord.Statistics.Analysis;
using System.Data;

namespace JadeChem.CustomControls.EvaluationControls
{
    public partial class MulticlassClassificationEvaluationControl : UserControl
    {
        #region Constructor
        public MulticlassClassificationEvaluationControl(string[] classLabels, int[] predictedClassIndices, int[] expectedClassIndices)
        {
            InitializeComponent();

            GeneralConfusionMatrix generalConfusionMatrix = new(predictedClassIndices, expectedClassIndices);

            DataTable confusionMatrixTable = new();
            for (int columnIndex = 0; columnIndex <= classLabels.Length; columnIndex++)
                confusionMatrixTable.Columns.Add("", typeof(string));
            for (int rowIndex = 0; rowIndex <= classLabels.Length; rowIndex++)
            {
                if (rowIndex == 0)
                {
                    string[] row = new string[classLabels.Length + 1];
                    for (int columnIndex = 0; columnIndex <= classLabels.Length; columnIndex++)
                    {
                        if (columnIndex == 0)
                            row[columnIndex] = "";
                        else
                            row[columnIndex] = classLabels[columnIndex - 1] + " (Expected)";
                    }

                    confusionMatrixTable.Rows.Add(row);
                }
                else
                {
                    string[] row = new string[classLabels.Length + 1];
                    for (int columnIndex = 0; columnIndex <= classLabels.Length; columnIndex++)
                    {
                        if (columnIndex == 0)
                            row[columnIndex] = classLabels[rowIndex - 1] + " (Predicted)";
                        else
                            row[columnIndex] = generalConfusionMatrix.Matrix[columnIndex - 1, rowIndex - 1].ToString();
                    }

                    confusionMatrixTable.Rows.Add(row);
                }
            }
            confusionMatrixDataGridView.DataSource = confusionMatrixTable;

            metricsListView.Items.Add(new ListViewItem(new string[] { "Accuracy", generalConfusionMatrix.Accuracy.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Pearson's contingency coefficient", generalConfusionMatrix.Pearson.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "χ²", generalConfusionMatrix.ChiSquare.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Cohen's κ coefficient", generalConfusionMatrix.Kappa.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Cramer's V", generalConfusionMatrix.Cramer.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "φ coefficient", generalConfusionMatrix.Phi.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Sakoda's contingency coefficient", generalConfusionMatrix.Sakoda.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Kendall's τ coefficient", generalConfusionMatrix.Tau.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Tschuprow's T", generalConfusionMatrix.Tschuprow.ToString("N4") }));

        }
        #endregion
    }
}
