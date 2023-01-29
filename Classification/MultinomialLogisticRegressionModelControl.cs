using Accord.Statistics.Models.Regression;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class MultinomialLogisticRegressionModelControl : UserControl
    {
        // Constructor
        public MultinomialLogisticRegressionModelControl(MultinomialLogisticRegression multinomialLogisticRegression, string[] features)
        {
            InitializeComponent();
            
            int numberOfColumns = multinomialLogisticRegression.Coefficients[0].Length;
            int numberOfRows = multinomialLogisticRegression.Coefficients.Length;
            fittingDataGridView.Columns.Add("b0", "b0");
            for (int columnIndex = 1; columnIndex < numberOfColumns; columnIndex++)
                fittingDataGridView.Columns.Add("b" + columnIndex.ToString(), "b" + columnIndex.ToString() + " (" + features[columnIndex - 1] + ")");

            for (int rowIndex = 0; rowIndex < numberOfRows; rowIndex++)
            {
                string[] row = new string[numberOfColumns];
                for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++)
                    row[columnIndex] = multinomialLogisticRegression.Coefficients[rowIndex][columnIndex].ToString();
                fittingDataGridView.Rows.Add(row);
            }
        }
    }
}
