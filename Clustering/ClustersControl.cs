using System;
using System.Windows.Forms;

namespace JadeML.Clustering
{
    public partial class ClustersControl : UserControl
    {
        // Fields
        private double[][] inputColumns = null;
        private int[] clusterIndexColumn = null;
        private string[] features = null;

        // Constructor
        public ClustersControl(double[][] inputColumns, int[] clusterIndexColumn, string[] features)
        {
            InitializeComponent();

            this.inputColumns = inputColumns;
            this.clusterIndexColumn = clusterIndexColumn;
            this.features = features;
        }

        // Method
        private void showClustersButton_Click(object sender, EventArgs e)
        {
            VisualizeClustersDialog visualizeClustersDialog = new VisualizeClustersDialog(inputColumns, clusterIndexColumn, features);
            visualizeClustersDialog.Show(this);
        }
    }
}
