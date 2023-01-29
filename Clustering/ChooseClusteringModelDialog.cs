using System;
using System.Windows.Forms;

namespace JadeML.Clustering
{
    public partial class ChooseClusteringModelDialog : Form
    {
        // Constructor
        public ChooseClusteringModelDialog()
        {
            InitializeComponent();
        }

        // Method
        private void ChooseClusteringModelDialog_Load(object sender, EventArgs e)
        {
            modelComboBox.SelectedIndex = 0;
        }
    }
}
