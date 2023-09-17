namespace JadeChem.Dialogs
{
    public partial class EditParametersDialog : Form
    {
        #region Property
        public Dictionary<string, double> Parameters { get; set; }
        #endregion

        #region Constructor
        public EditParametersDialog()
        {
            InitializeComponent();

            Parameters = new Dictionary<string, double>();
        }
        #endregion

        #region Methods
        private void EditParametersDialog_Load(object sender, EventArgs e)
        {
            parametersDataGridView.Rows.Clear();
            foreach (KeyValuePair<string, double> parameter in Parameters)
                parametersDataGridView.Rows.Add(parameter.Key, parameter.Value);
        }

        private void EditParametersDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;

            // Validate the parameters
            bool parseError = false;

            for (int rowIndex = 0; rowIndex < Parameters.Count; rowIndex++)
            {
                parseError = !double.TryParse(parametersDataGridView.Rows[rowIndex].Cells[1].Value.ToString(), out double value);
                if (parseError)
                {
                    break;
                }
                Parameters[(string)parametersDataGridView.Rows[rowIndex].Cells[0].Value] = value;
            }

            if (parseError)
            {
                MessageBox.Show("Invalid parameter value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            if (Parameters.ContainsKey("Min output"))
            {
                if (Parameters["Min output"] >= Parameters["Max output"])
                {
                    MessageBox.Show("Min output must be less than max output!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (Parameters.ContainsKey("radius"))
            {
                if (Parameters["radius"] % 1 != 0 || Parameters["radius"] < 1)
                {
                    MessageBox.Show("Radius must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                if (Parameters["radius"] > 10)
                {
                    MessageBox.Show("Selected radius is too large!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (Parameters.ContainsKey("nBits"))
            {
                if (Parameters["nBits"] % 1 != 0 || Parameters["nBits"] < 1)
                {
                    MessageBox.Show("nBits must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else if (Parameters["nBits"] > 2048)
                {
                    MessageBox.Show("Selected nBits is too large", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (Parameters.ContainsKey("threshold"))
            {
                if (Parameters["threshold"] <= 0)
                {
                    MessageBox.Show("Threshold must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (Parameters.ContainsKey("nComponents"))
            {
                if (Parameters["nComponents"] % 1 != 0 || Parameters["nComponents"] < 1)
                {
                    MessageBox.Show("nComponents must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}
