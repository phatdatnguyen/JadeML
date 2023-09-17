using JadeChem.Utils;

namespace JadeChem.CustomControls.EvaluationControls
{
    public partial class RegressionEvaluationControl : UserControl
    {
        #region Constructor
        public RegressionEvaluationControl(double[] predictedOutputColumn, double[] expectedOutputColumn)
        {
            InitializeComponent();

            metricsListView.Items.Add(new ListViewItem(new string[] { "Mean absolute error", RegressionMetrics.MeanAbsoluteError(predictedOutputColumn, expectedOutputColumn).ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Mean squared error", RegressionMetrics.MeanSquaredError(predictedOutputColumn, expectedOutputColumn).ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Root mean squared error", RegressionMetrics.RootMeanSquaredError(predictedOutputColumn, expectedOutputColumn).ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "Pearson correlation coefficient", RegressionMetrics.PearsonCorrelationCoefficient(predictedOutputColumn, expectedOutputColumn).ToString("N4") }));
            metricsListView.Items.Add(new ListViewItem(new string[] { "R²", RegressionMetrics.RSquared(predictedOutputColumn, expectedOutputColumn).ToString("N4") }));
        }
        #endregion
    }
}
