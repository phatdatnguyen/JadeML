namespace JadeChem
{
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredictionTaskForm predictionTaskForm = new()
            {
                MdiParent = this
            };
            predictionTaskForm.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new();
            aboutBox.ShowDialog(this);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                closeToolStripMenuItem.Enabled = false;
            else
                closeToolStripMenuItem.Enabled = true;
        }
        #endregion
    }
}
