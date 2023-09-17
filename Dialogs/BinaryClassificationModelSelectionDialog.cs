namespace JadeChem.Dialogs
{
    public partial class BinaryClassificationModelSelectionDialog : Form
    {
        #region Property
        public string ModelName { get { return modelComboBox.Text; } }
        #endregion

        #region Constructor
        public BinaryClassificationModelSelectionDialog()
        {
            InitializeComponent();

            modelComboBox.SelectedIndex = 0;
        }
        #endregion
    }
}
