using System;
using System.Windows.Forms;

namespace JadeML
{
    public partial class SplitDatasetDialog : Form
    {
        // Property
        public float PercentageOfTrainingDataset { get { return splitTrackBar.Value; } }
        
        // Constructor
        public SplitDatasetDialog()
        {
            InitializeComponent();
        }

        // Method
        private void splitTrackBar_Scroll(object sender, EventArgs e)
        {
            trainingDatasetLabel.Text = "Training dataset: " + splitTrackBar.Value.ToString() + "%";
            testingDatasetLabel.Text = "Testing dataset: " + (100 - splitTrackBar.Value).ToString() + "%";
        }
    }
}
