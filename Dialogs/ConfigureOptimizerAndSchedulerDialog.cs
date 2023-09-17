namespace JadeChem.Dialogs
{
    public partial class ConfigureOptimizerAndSchedulerDialog : Form
    {
        #region Fields
        private readonly Dictionary<string, double> optimizerParameters;
        private readonly Dictionary<string, double> lrSchedulerParameters;
        #endregion

        #region Properties
        public Dictionary<string, double> OptimizerParameters { get { return optimizerParameters; } }
        public Dictionary<string, double> LRSchedulerParameters { get { return lrSchedulerParameters; } }
        #endregion

        #region Constructor
        public ConfigureOptimizerAndSchedulerDialog(string optimizerName, Dictionary<string, double> optimizerParameters, string lrSchedulerName, Dictionary<string, double> lrSchedulerParameters)
        {
            InitializeComponent();

            // Optimizer
            optimizerNameTextBox.Text = optimizerName;
            this.optimizerParameters = optimizerParameters;
            foreach (KeyValuePair<string, double> parameter in optimizerParameters)
                optimizerParametersDataGridView.Rows.Add(parameter.Key, parameter.Value.ToString());

            // Scheduler
            lrSchedulerNameTextBox.Text = lrSchedulerName;
            this.lrSchedulerParameters = lrSchedulerParameters;
            foreach (KeyValuePair<string, double> parameter in lrSchedulerParameters)
                lrSchedulerParametersDataGridView.Rows.Add(parameter.Key, parameter.Value.ToString());
        }
        #endregion

        #region Method
        private void EditParametersDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;

            // Validate the parameters
            bool parseError = false;

            // Optimizer parameters
            for (int rowIndex = 0; rowIndex < optimizerParameters.Count; rowIndex++)
            {
                parseError = !double.TryParse(optimizerParametersDataGridView.Rows[rowIndex].Cells[1].Value.ToString(), out double value);
                if (parseError)
                {
                    break;
                }
                optimizerParameters[(string)optimizerParametersDataGridView.Rows[rowIndex].Cells[0].Value] = value;
            }

            if (parseError)
            {
                MessageBox.Show("Invalid parameter value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            // Scheduler parameters
            for (int rowIndex = 0; rowIndex < lrSchedulerParameters.Count; rowIndex++)
            {
                parseError = !double.TryParse(lrSchedulerParametersDataGridView.Rows[rowIndex].Cells[1].Value.ToString(), out double value);
                if (parseError)
                {
                    break;
                }
                lrSchedulerParameters[(string)lrSchedulerParametersDataGridView.Rows[rowIndex].Cells[0].Value] = value;
            }

            if (parseError)
            {
                MessageBox.Show("Invalid parameter value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        #endregion
    }
}
