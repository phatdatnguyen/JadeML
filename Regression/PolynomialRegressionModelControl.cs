using Accord.Statistics.Models.Regression.Linear;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class PolynomialRegressionModelControl : UserControl
    {
        // Constructor
        public PolynomialRegressionModelControl(PolynomialRegression polynomialRegression)
        {
            InitializeComponent();

            fittingDataGridView.Columns.Clear();
            fittingDataGridView.Columns.Add("b0", "Intercept (b0)");
            double[] weights = polynomialRegression.Weights;
            for (int columnIndex = weights.Length - 1; columnIndex >= 0; columnIndex--)
                fittingDataGridView.Columns.Add("b" + (columnIndex + 1).ToString(), "b" + (columnIndex + 1).ToString());
            string[] coefficents = new string[weights.Length + 1];
            coefficents[0] = polynomialRegression.Intercept.ToString();
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                coefficents[columnIndex + 1] = weights[columnIndex].ToString();
            fittingDataGridView.Rows.Add(coefficents);
        }
    }
}
