using System;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class ChooseBinaryClassificationModelDialog : Form
    {
        // Constructor
        public ChooseBinaryClassificationModelDialog()
        {
            InitializeComponent();
        }

        // Method
        private void ChooseClassificationModelDialog_Load(object sender, EventArgs e)
        {
            modelComboBox.SelectedIndex = 0;
        }
    }
}
