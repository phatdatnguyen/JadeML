using System;
using System.Windows.Forms;

namespace JadeML
{
    public partial class NewTaskDialog : Form
    {
        // Fields
        private string selectedTask = "";

        // Properties
        public string SelectedTask
        {
            get { return selectedTask; }
        }

        // Methods
        public NewTaskDialog()
        {
            InitializeComponent();
        }

        private void binaryClassificationButton_Click(object sender, EventArgs e)
        {
            selectedTask = "Binary Classification";
            Close();
        }

        private void multiclassClassificationButton_Click(object sender, EventArgs e)
        {
            selectedTask = "Multiclass Classification";
            Close();
        }

        private void regressionButton_Click(object sender, EventArgs e)
        {
            selectedTask = "Regression";
            Close();
        }

        private void clusteringButton_Click(object sender, EventArgs e)
        {
            selectedTask = "Clustering";
            Close();
        }

        private void pcaButton_Click(object sender, EventArgs e)
        {
            selectedTask = "PCA";
            Close();
        }

        private void daButton_Click(object sender, EventArgs e)
        {
            selectedTask = "DA";
            Close();
        }
    }
}
