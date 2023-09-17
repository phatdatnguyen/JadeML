using JadeChem.Models;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class LassoRegressionModelControl : UserControl
    {
        #region Property
        public Dictionary<string, double> Hyperparameters { get; set; }
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public LassoRegressionModelControl()
        {
            InitializeComponent();

            Hyperparameters = new Dictionary<string, double>
            {
                ["lambda"] = (double)lambdaNumericUpDown.Value,
                ["learning rate"] = (double)learningRateNumericUpDown.Value,
                ["max iterations"] = (int)maxIterationsNumericUpDown.Value
            };
        }
        #endregion

        #region Methods
        private void LambdaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["lambda"] = (int)lambdaNumericUpDown.Value;
        }

        private void LearningRateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["learning rate"] = (double)learningRateNumericUpDown.Value;
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

        public void UpdateFittingEquation(LassoRegression lassoRegression, string[] inputColumnNames)
        {
            weightsAndInterceptDataGridView.Columns.Clear();
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                weightsAndInterceptDataGridView.Columns.Add(inputColumnNames[columnIndex], inputColumnNames[columnIndex]);
            weightsAndInterceptDataGridView.Columns.Add("Intercept", "Intercept");

            weightsAndInterceptDataGridView.Rows.Add();

            double[] coefficients = lassoRegression.Coefficients;
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length + 1; columnIndex++)
                weightsAndInterceptDataGridView.Rows[0].Cells[columnIndex].Value = coefficients[columnIndex];

            fittingEquationGroupBox.Visible = true;
        }
        #endregion
    }
}
