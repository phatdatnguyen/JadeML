namespace JadeChem.Dialogs
{
    public partial class EditSplitRatioDialog : Form
    {
        #region Fields
        private readonly int numberOfRows;
        private readonly SplitType splitType;
        #endregion

        #region Properties
        public double SplitRatio { get; set; } // & of train dataset
        public int RandomSeed { get; set; } // & of train dataset
        #endregion

        #region Enum
        public enum SplitType
        {
            TrainTestSplit,
            TrainValidationSplit
        }
        #endregion

        #region Constructor
        public EditSplitRatioDialog(int numberOfRows, SplitType splitType)
        {
            InitializeComponent();

            this.numberOfRows = numberOfRows;
            this.splitType = splitType;
            if (splitType == SplitType.TrainValidationSplit)
                split2Label.Text = "Validation dataset: 30%";

            SplitRatio = 0.7;
        }
        #endregion

        #region Methods
        private void SplitRatioTrackBar_Scroll(object sender, EventArgs e)
        {
            split1Label.Text = "Train dataset: " + splitRatioTrackBar.Value.ToString() + "%";
            if (splitType == SplitType.TrainTestSplit)
                split2Label.Text = "Test dataset: " + (100 - splitRatioTrackBar.Value).ToString() + "%";
            else
                split2Label.Text = "Validation dataset: " + (100 - splitRatioTrackBar.Value).ToString() + "%";
        }

        private void EditSplitRatioDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                SplitRatio = (double)splitRatioTrackBar.Value / 100;
                RandomSeed = (int)randomSeedNumericUpDown.Value;

                // Check for invalid split
                bool isInvalidSplit = false;

                if (SplitRatio == 0 || SplitRatio == 1)
                    isInvalidSplit = true;
                else
                {
                    int trainSize = (int)(numberOfRows * SplitRatio);
                    int testSize = numberOfRows - trainSize;

                    if (trainSize <= 1 || testSize <= 1)
                        isInvalidSplit = true;
                }

                if (isInvalidSplit)
                {
                    MessageBox.Show("Cannot split dataset with the selected split ratio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}
