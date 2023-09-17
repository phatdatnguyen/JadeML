using Accord.Statistics.Models.Regression.Linear;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class LinearRegressionModelControl : UserControl
    {
        #region Property
        public Dictionary<string, bool> Hyperparameters { get; set; }
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public LinearRegressionModelControl()
        {
            InitializeComponent();

            Hyperparameters = new Dictionary<string, bool>
            {
                ["Set intercept = 0"] = setInterceptZeroCheckBox.Checked
            };
        }
        #endregion

        #region Methods
        private void SetInterceptZeroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Hyperparameters["Set intercept = 0"] = setInterceptZeroCheckBox.Checked;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void UpdateFittingEquation(MultipleLinearRegression multipleLinearRegression, string[] inputColumnNames)
        {
            weightsAndInterceptDataGridView.Columns.Clear();
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                weightsAndInterceptDataGridView.Columns.Add(inputColumnNames[columnIndex], inputColumnNames[columnIndex]);
            weightsAndInterceptDataGridView.Columns.Add("Bias", "Bias");

            weightsAndInterceptDataGridView.Rows.Add();

            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                weightsAndInterceptDataGridView.Rows[0].Cells[columnIndex].Value = multipleLinearRegression.Weights[columnIndex];
            weightsAndInterceptDataGridView.Rows[0].Cells[inputColumnNames.Length].Value = multipleLinearRegression.Intercept;

            fittingEquationGroupBox.Visible = true;
        }
        #endregion
    }
}
