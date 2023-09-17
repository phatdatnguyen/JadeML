namespace JadeChem.Dialogs
{
    public partial class RegressionModelSelectionDialog : Form
    {
        #region Property
        public string ModelName { get { return modelComboBox.Text; } }
        #endregion

        #region Constructor
        public RegressionModelSelectionDialog()
        {
            InitializeComponent();

            modelComboBox.SelectedIndex = 0;
        }
        #endregion
    }
}
