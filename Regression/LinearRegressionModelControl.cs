using Accord.Statistics.Models.Regression.Linear;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class LinearRegressionModelControl : UserControl
    {
        // Constructor
        public LinearRegressionModelControl(MultipleLinearRegression multipleLinearRegression, string[] features)
        {
            InitializeComponent();

            fittingDataGridView.Columns.Clear();
            fittingDataGridView.Columns.Add("b0", "Intercept (b0)");
            double[] weights = multipleLinearRegression.Weights;
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                fittingDataGridView.Columns.Add("b" + (columnIndex + 1).ToString(), features[columnIndex] + " (b" + (columnIndex + 1).ToString() + ")");
            string[] coefficents = new string[weights.Length + 1];
            coefficents[0] = multipleLinearRegression.Intercept.ToString();
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                coefficents[columnIndex + 1] = weights[columnIndex].ToString();
            fittingDataGridView.Rows.Add(coefficents);
        }
    }
}
