using System;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class ChooseRegressionModelDialog : Form
    {
        // Constructor
        public ChooseRegressionModelDialog()
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
