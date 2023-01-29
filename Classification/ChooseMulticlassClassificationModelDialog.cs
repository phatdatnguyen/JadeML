using System;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class ChooseMulticlassClassificationModelDialog : Form
    {
        // Constructor
        public ChooseMulticlassClassificationModelDialog()
        {
            InitializeComponent();
        }

        // Method
        private void ChooseMulticlassClassificationModelDialog_Load(object sender, EventArgs e)
        {
            modelComboBox.SelectedIndex = 0;
        }
    }
}
