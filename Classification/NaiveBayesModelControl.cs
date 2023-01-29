using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Univariate;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class NaiveBayesModelControl : UserControl
    {
        // Constructor
        public NaiveBayesModelControl(NaiveBayes<NormalDistribution> naiveBayes, string[] features, string target, string[] classLabels)
        {
            InitializeComponent();

            probabilitiesDataGridView.DataSource = new ArrayDataView(naiveBayes.Distributions, features, classLabels);
            foreach (DataGridViewColumn dataGridViewColumn in probabilitiesDataGridView.Columns)
                if (dataGridViewColumn.Index == 0)
                    dataGridViewColumn.HeaderText = target;
                else
                    dataGridViewColumn.Width = 300;
        }
    }
}
