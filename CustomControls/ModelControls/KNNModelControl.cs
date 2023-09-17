namespace JadeChem.CustomControls.ModelControls
{
    public partial class KNNModelControl : UserControl
    {
        #region Property
        public Dictionary<string, int> Hyperparameters { get; set; }
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public KNNModelControl()
        {
            InitializeComponent();

            Hyperparameters = new Dictionary<string, int>
            {
                ["k"] = (int)kNumericUpDown.Value
            };
        }
        #endregion

        #region Methods
        private void KNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["k"] = (int)kNumericUpDown.Value;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }
        #endregion
    }
}
