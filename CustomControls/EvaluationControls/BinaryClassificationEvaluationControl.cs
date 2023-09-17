using Accord.Statistics.Analysis;
using System.Data;

namespace JadeChem.CustomControls.EvaluationControls
{
    public partial class BinaryClassificationEvaluationControl : UserControl
    {
        #region Fields
        private readonly string[] classLabels;
        private readonly int[] predictedClassIndices;
        private readonly int[] expectedClassIndices;
        #endregion

        #region Constructor
        public BinaryClassificationEvaluationControl(string[] classLabels, int[] predictedClassIndices, int[] expectedClassIndices)
        {
            InitializeComponent();

            this.classLabels = classLabels;
            this.predictedClassIndices = predictedClassIndices;
            this.expectedClassIndices = expectedClassIndices;

            for (int classIndex = 0; classIndex < classLabels.Length; classIndex++)
                positiveClassComboBox.Items.Add(classLabels[classIndex]);

            positiveClassComboBox.SelectedIndex = 0;

            ConfusionMatrix confusionMatrix = new(predictedClassIndices, expectedClassIndices, 0);

            DataTable confusionMatrixTable = new();
            confusionMatrixTable.Columns.Add("", typeof(string));
            confusionMatrixTable.Columns.Add("", typeof(string));
            confusionMatrixTable.Columns.Add("", typeof(string));
            confusionMatrixTable.Rows.Add("", classLabels[0] + " (Expected)", classLabels[1] + " (Expected)");
            confusionMatrixTable.Rows.Add(classLabels[0] + " (Predicted)", confusionMatrix.TruePositives.ToString(), confusionMatrix.FalsePositives.ToString());
            confusionMatrixTable.Rows.Add(classLabels[1] + " (Predicted)", confusionMatrix.FalseNegatives.ToString(), confusionMatrix.TrueNegatives.ToString());
            confusionMatrixDataGridView.DataSource = confusionMatrixTable;

            metricsListView.Items.Clear();
            metricsListView.Items.Add(new ListViewItem(new string[] { "Accuracy", confusionMatrix.Accuracy.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Precision", confusionMatrix.Precision.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Recall/Sensitivity", confusionMatrix.Recall.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Specificity", confusionMatrix.Specificity.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Efficiency", confusionMatrix.Efficiency.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "F1 score", confusionMatrix.FScore.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Prevalence", confusionMatrix.Prevalence.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Normalized mutual information", confusionMatrix.NormalizedMutualInformation.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Pearson's contingency coefficient", confusionMatrix.Pearson.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "χ²", confusionMatrix.ChiSquare.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Cohen's κ coefficient", confusionMatrix.Kappa.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Matthews correlation coefficient", confusionMatrix.MatthewsCorrelationCoefficient.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Cramer's V", confusionMatrix.ToGeneralMatrix().Cramer.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "φ coefficient", confusionMatrix.ToGeneralMatrix().Phi.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Sakoda's contingency coefficient", confusionMatrix.ToGeneralMatrix().Sakoda.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Kendall's τ coefficient", confusionMatrix.ToGeneralMatrix().Tau.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Tschuprow's T", confusionMatrix.ToGeneralMatrix().Tschuprow.ToString("N4") }));
        }
        #endregion

        #region Method
        private void PositiveClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int positiveClassIndex = positiveClassComboBox.SelectedIndex;
            int negativeClassIndex = 1;
            if (positiveClassIndex == 0)
                negativeClassIndex = 1;
            else if (positiveClassIndex == 1)
                negativeClassIndex = 0;

            //Binary classification
            ConfusionMatrix confusionMatrix = new(predictedClassIndices, expectedClassIndices, positiveClassIndex);

            DataTable confusionMatrixTable = new();
            confusionMatrixTable.Columns.Add("", typeof(string));
            confusionMatrixTable.Columns.Add("", typeof(string));
            confusionMatrixTable.Columns.Add("", typeof(string));
            confusionMatrixTable.Rows.Add("", classLabels[positiveClassIndex] + " (Expected)", classLabels[negativeClassIndex] + " (Expected)");
            confusionMatrixTable.Rows.Add(classLabels[positiveClassIndex] + " (Predicted)", confusionMatrix.TruePositives.ToString(), confusionMatrix.FalsePositives.ToString());
            confusionMatrixTable.Rows.Add(classLabels[negativeClassIndex] + " (Predicted)", confusionMatrix.FalseNegatives.ToString(), confusionMatrix.TrueNegatives.ToString());
            confusionMatrixDataGridView.DataSource = confusionMatrixTable;

            metricsListView.Items.Clear();
            metricsListView.Items.Add(new ListViewItem(new string[] { "Accuracy", confusionMatrix.Accuracy.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Precision", confusionMatrix.Precision.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Recall/Sensitivity", confusionMatrix.Recall.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Specificity", confusionMatrix.Specificity.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Efficiency", confusionMatrix.Efficiency.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "F1 score", confusionMatrix.FScore.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Prevalence", confusionMatrix.Prevalence.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Normalized mutual information", confusionMatrix.NormalizedMutualInformation.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Pearson's contingency coefficient", confusionMatrix.Pearson.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "χ²", confusionMatrix.ChiSquare.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Cohen's κ coefficient", confusionMatrix.Kappa.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Matthews correlation coefficient", confusionMatrix.MatthewsCorrelationCoefficient.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Cramer's V", confusionMatrix.ToGeneralMatrix().Cramer.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "φ coefficient", confusionMatrix.ToGeneralMatrix().Phi.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Sakoda's contingency coefficient", confusionMatrix.ToGeneralMatrix().Sakoda.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Kendall's τ coefficient", confusionMatrix.ToGeneralMatrix().Tau.ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Tschuprow's T", confusionMatrix.ToGeneralMatrix().Tschuprow.ToString("N4") }));
        }
        #endregion
    }
}
