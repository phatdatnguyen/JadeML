using Accord.Statistics.Models.Regression;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class LogisticRegressionModelControl : UserControl
    {
        #region Property
        public Dictionary<string, object> Hyperparameters { get; set; }
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public LogisticRegressionModelControl()
        {
            InitializeComponent();

            Hyperparameters = new Dictionary<string, object>
            {
                ["learning method"] = logisticGradientDescentRadioButton.Text,
                ["learning rate"] = (double)learningRateNumericUpDown.Value,
                ["stochastic"] = stochasticCheckBox.Checked,
                ["regularization"] = (double)regularizationNumericUpDown.Value,

                ["tolerance"] = (double)toleranceNumericUpDown.Value,
                ["max iterations"] = (int)maxIterationsNumericUpDown.Value
            };
        }
        #endregion

        #region Methods
        private void LearningMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (logisticGradientDescentRadioButton.Checked)
                Hyperparameters["learning method"] = logisticGradientDescentRadioButton.Text;
            else
                Hyperparameters["learning method"] = iterativeReweightedLeastSquaresRadioButton.Text;
        }

        private void LearningRateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["learning rate"] = (double)learningRateNumericUpDown.Value;
        }

        private void StochasticCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Hyperparameters["stochastic"] = stochasticCheckBox.Checked;
        }

        private void RegularizationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["regularization"] = (double)regularizationNumericUpDown.Value;
        }

        private void ToleranceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["tolerance"] = (double)toleranceNumericUpDown.Value;
        }

        private void MaxIterationsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["max iterations"] = (int)maxIterationsNumericUpDown.Value;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void UpdateFittingEquation(LogisticRegression logisticRegression, string[] inputColumnNames)
        {
            weightsAndInterceptDataGridView.Columns.Clear();
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                weightsAndInterceptDataGridView.Columns.Add(inputColumnNames[columnIndex], inputColumnNames[columnIndex]);
            weightsAndInterceptDataGridView.Columns.Add("Intercept", "Intercept");

            weightsAndInterceptDataGridView.Rows.Add();

            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                weightsAndInterceptDataGridView.Rows[0].Cells[columnIndex].Value = logisticRegression.Weights[columnIndex];
            weightsAndInterceptDataGridView.Rows[0].Cells[inputColumnNames.Length].Value = logisticRegression.Intercept;

            fittingEquationGroupBox.Visible = true;
        }
        #endregion
    }
}
