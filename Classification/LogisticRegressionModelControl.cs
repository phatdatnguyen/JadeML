using Accord.Statistics.Models.Regression;
using System;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class LogisticRegressionModelControl : UserControl
    {
        // Constructor
        public LogisticRegressionModelControl(LogisticRegression logisticRegression, string[] features)
        {
            InitializeComponent();

            double[] weights = logisticRegression.Weights;
            double intercept = logisticRegression.Intercept;

            fittingDataGridView.Columns.Clear();
            fittingDataGridView.Columns.Add("b0", "b0");
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                fittingDataGridView.Columns.Add("b" + (columnIndex + 1).ToString(), "b" + (columnIndex + 1).ToString() + " (" + features[columnIndex] + ")");
            
            string[] coefficents = new string[weights.Length + 1];
            coefficents[0] = Math.Round(intercept, 3).ToString();
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                coefficents[columnIndex + 1] = Math.Round(weights[columnIndex],3).ToString();
            fittingDataGridView.Rows.Add(coefficents);
        }
    }
}
