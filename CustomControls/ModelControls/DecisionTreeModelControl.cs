using Accord.MachineLearning.DecisionTrees;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class DecisionTreeModelControl : UserControl
    {
        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public DecisionTreeModelControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void UpdateDecisionTreeView(DecisionTree model, string[] inputColumnNames, string[] classLabels)
        {
            decisionTreeViewControl.UpdateDecisionTreeView(model, inputColumnNames, classLabels);
            treeViewGroupBox.Visible = true;
        }
        #endregion
    }
}
