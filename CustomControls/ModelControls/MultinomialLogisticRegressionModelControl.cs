using Accord.Statistics.Models.Regression;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class MultinomialLogisticRegressionModelControl : UserControl
    {
        #region Property
        public Dictionary<string, string> Hyperparameters { get; set; }
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public MultinomialLogisticRegressionModelControl()
        {
            InitializeComponent();

            Hyperparameters = new Dictionary<string, string>();
            lowerBoundNewtonRaphsonRadioButton.Checked = true;
            if (lowerBoundNewtonRaphsonRadioButton.Checked)
                Hyperparameters["learning method"] = lowerBoundNewtonRaphsonRadioButton.Text;
            else if (conjugateGradientRadioButton.Checked)
                Hyperparameters["learning method"] = conjugateGradientRadioButton.Text;
            else if (gradientDescentRadioButton.Checked)
                Hyperparameters["learning method"] = gradientDescentRadioButton.Text;
            else if (broydenFletcherGoldfarbShannoRadioButton.Checked)
                Hyperparameters["learning method"] = broydenFletcherGoldfarbShannoRadioButton.Text;
            Hyperparameters["max iteration"] = maxIterationNumericUpDown.Value.ToString();
            Hyperparameters["tolerance"] = toleranceNumericUpDown.Value.ToString();
        }
        #endregion

        #region Methods
        private void LearningMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerBoundNewtonRaphsonRadioButton.Checked)
                Hyperparameters["learning method"] = lowerBoundNewtonRaphsonRadioButton.Text;
            else if (conjugateGradientRadioButton.Checked)
                Hyperparameters["learning method"] = conjugateGradientRadioButton.Text;
            else if (gradientDescentRadioButton.Checked)
                Hyperparameters["learning method"] = gradientDescentRadioButton.Text;
            else if (broydenFletcherGoldfarbShannoRadioButton.Checked)
                Hyperparameters["learning method"] = broydenFletcherGoldfarbShannoRadioButton.Text;
        }

        private void MultinomialLogisticRegressionModelControl_Load(object sender, EventArgs e)
        {
            lowerBoundNewtonRaphsonRadioButton.Checked = true;
        }

        private void MaxInterationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["max iteration"] = maxIterationNumericUpDown.Value.ToString();
        }

        private void ToleranceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["tolerance"] = toleranceNumericUpDown.Value.ToString();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void UpdateFittingEquation(MultinomialLogisticRegression multinomialLogisticRegression, string[] inputColumnNames)
        {
            weightsAndInterceptDataGridView.Columns.Clear();
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                weightsAndInterceptDataGridView.Columns.Add(inputColumnNames[columnIndex], inputColumnNames[columnIndex]);
            weightsAndInterceptDataGridView.Columns.Add("Intercept", "Intercept");

            for (int rowIndex = 0; rowIndex < multinomialLogisticRegression.Coefficients.Length; rowIndex++)
            {
                weightsAndInterceptDataGridView.Rows.Add();
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                    weightsAndInterceptDataGridView.Rows[rowIndex].Cells[columnIndex].Value = multinomialLogisticRegression.Coefficients[rowIndex][columnIndex + 1];
                weightsAndInterceptDataGridView.Rows[rowIndex].Cells[inputColumnNames.Length].Value = multinomialLogisticRegression.Coefficients[rowIndex][0];
            }

            fittingEquationGroupBox.Visible = true;
        }
        #endregion
    }
}
