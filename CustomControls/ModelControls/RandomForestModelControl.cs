using Accord.MachineLearning.DecisionTrees;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class RandomForestModelControl : UserControl
    {
        #region Fields
        private RandomForest? model;
        private string[]? inputColumnNames;
        private string[]? classLabels;
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Property
        public Dictionary<string, double> Hyperparameters { get; set; }
        #endregion

        #region Constructor
        public RandomForestModelControl()
        {
            InitializeComponent();

            Hyperparameters = new Dictionary<string, double>
            {
                ["Number of trees"] = (double)numberOfTreesNumericUpDown.Value,
                ["Sample ratio"] = (double)sampleRatioNumericUpDown.Value
            };
        }
        #endregion

        #region Methods
        private void NumberOfTreesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["Number of trees"] = (double)numberOfTreesNumericUpDown.Value;
        }

        private void SampleRatioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["Sample ratio"] = (double)sampleRatioNumericUpDown.Value;

        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void UpdateDecisionTreeView(RandomForest model, string[] inputColumnNames, string[] classLabels)
        {
            this.model = model;
            this.inputColumnNames = inputColumnNames;
            this.classLabels = classLabels;

            treeComboBox.Items.Clear();

            for (int treeIndex = 0; treeIndex < model.Trees.Length; treeIndex++)
                treeComboBox.Items.Add((treeIndex + 1).ToString());

            treeComboBox.SelectedIndex = 0;

            treeViewGroupBox.Visible = true;
        }

        private void TreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeComboBox.SelectedIndex == -1 || model == null || inputColumnNames == null || classLabels == null)
                return;

            decisionTreeViewControl.UpdateDecisionTreeView(model.Trees[treeComboBox.SelectedIndex], inputColumnNames, classLabels);
        }
        #endregion
    }
}
