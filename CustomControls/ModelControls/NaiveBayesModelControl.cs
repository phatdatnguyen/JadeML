using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Univariate;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class NaiveBayesModelControl : UserControl
    {
        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public NaiveBayesModelControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void UpdateNormalDistributionTable(NaiveBayes<NormalDistribution> naiveBayes, string[] inputColumnNames, string[] classLabels, string outputColumnName)
        {
            normalDistributionDataGridView.Columns.Clear();
            normalDistributionDataGridView.Columns.Add(outputColumnName, outputColumnName);
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
            {
                normalDistributionDataGridView.Columns.Add(inputColumnNames[columnIndex], inputColumnNames[columnIndex]);
                normalDistributionDataGridView.Columns[columnIndex + 1].Width = 350;
            }
            normalDistributionDataGridView.Rows.Add();
            normalDistributionDataGridView.Rows[0].Cells[0].Value = classLabels[0];
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                normalDistributionDataGridView.Rows[0].Cells[columnIndex + 1].Value = naiveBayes.Distributions[0, columnIndex].ToString();

            normalDistributionDataGridView.Rows.Add();
            normalDistributionDataGridView.Rows[1].Cells[0].Value = classLabels[1];
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                normalDistributionDataGridView.Rows[1].Cells[columnIndex + 1].Value = naiveBayes.Distributions[1, columnIndex].ToString();

            normalDistributionGroupBox.Visible = true;
        }
        
        private void NormalDistributionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.CellStyle ??= new DataGridViewCellStyle();

                e.CellStyle.BackColor = Color.Cyan;
            }
        }
        #endregion
    }
}
