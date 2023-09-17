namespace JadeChem.Dialogs
{
    public partial class DataProcessingDialog : Form
    {
        #region Field
        // flag
        private bool resettingFilters = false;
        #endregion

        #region Properties
        public Dictionary<string, Dictionary<string, (double, double)>> InputScalersDictionary { get; }
        public Dictionary<string, Dictionary<string, (double, double)>> OutputScalersDictionary { get; }
        public Dictionary<string, Dictionary<string, double>> DimensionalityReductionStepsDictionary { get; }
        #endregion

        #region Constructor
        public DataProcessingDialog(Dictionary<string, Dictionary<string, (double, double)>> inputScalersDictionary, Dictionary<string, Dictionary<string, (double, double)>> outputScalersDictionary, Dictionary<string, Dictionary<string, double>> dimensionalityReductionStepsDictionary)//,Dictionary<string,Dictionary<string,uint>> fingerprintExtractionDictionary)
        {
            InitializeComponent();

            InputScalersDictionary = inputScalersDictionary;
            OutputScalersDictionary = outputScalersDictionary;
            DimensionalityReductionStepsDictionary = dimensionalityReductionStepsDictionary;
        }
        #endregion

        #region Methods
        private void DataProcessingDialog_Load(object sender, EventArgs e)
        {
            // Clear the list box then add new items
            columnListBox.Items.Clear();
            foreach (string columnName in InputScalersDictionary.Keys)
                columnListBox.Items.Add(columnName);
            foreach (string columnName in OutputScalersDictionary.Keys)
                columnListBox.Items.Add(columnName);


            // Select the first column
            if (columnListBox.Items.Count > 0)
                columnListBox.SelectedIndex = 0;
        }

        private void ColumnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (columnListBox.SelectedIndex == -1)
                return;

            // Loop through the list of scalers
            foreach (ListViewItem item in processingStepsListView.Items)
            {
                if (item.Group.Header == "Scaling")
                {
                    // Check if the scaler was selected for selected column (presents in the dictionary)
                    if ((InputScalersDictionary.ContainsKey(columnListBox.Text) && InputScalersDictionary[columnListBox.Text].ContainsKey(item.Text))
                        || (OutputScalersDictionary.ContainsKey(columnListBox.Text) && OutputScalersDictionary[columnListBox.Text].ContainsKey(item.Text)))

                    {
                        // Check the checkbox
                        resettingFilters = true;
                        item.Checked = true;
                        resettingFilters = false;

                        // Show the parameters
                        if (item.Text == "Min-max scaling")
                        {
                            if (InputScalersDictionary.ContainsKey(columnListBox.Text))
                            {
                                (double minOutput, double maxOutput) = InputScalersDictionary[columnListBox.Text][item.Text];
                                item.SubItems[1].Text = "{ range=(" + minOutput.ToString() + ", " + maxOutput.ToString() + ") }";
                            }
                            else if (OutputScalersDictionary.ContainsKey(columnListBox.Text))
                            {
                                (double minOutput, double maxOutput) = OutputScalersDictionary[columnListBox.Text][item.Text];
                                item.SubItems[1].Text = "{ range=(" + minOutput.ToString() + ", " + maxOutput.ToString() + ") }";
                            }
                        }
                    }
                    else
                    {
                        // Uncheck the checkbox
                        resettingFilters = true;
                        item.Checked = false;
                        resettingFilters = false;

                        // Reset the parameters
                        if (item.Text == "Min-max scaling")
                            item.SubItems[1].Text = "{ range=(0, 1) }";
                    }
                }
            }

            // Enable/disable the edit button
            if (processingStepsListView.SelectedItems.Count == 0)
                return;

            if (processingStepsListView.SelectedItems[0].Checked &&
                (processingStepsListView.SelectedItems[0].Text == "Min-max scaling" ||
                processingStepsListView.SelectedItems[0].Text == "Variance threshold" ||
                processingStepsListView.SelectedItems[0].Text == "Principle component analysis"))
                editButton.Enabled = true;
            else
                editButton.Enabled = false;
        }

        private void ProcessingStepsView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Do nothing the the item was checked/unchecked by code
            if (resettingFilters)
                return;

            if (e.Item.Group.Header == "Scaling")
            {
                // Add/remove the scaler from the dictionary
                if (InputScalersDictionary.ContainsKey(columnListBox.Text))
                {
                    if (e.Item.Checked)
                    {
                        if (e.Item.Text == "Min-max scaling")
                        {
                            InputScalersDictionary[columnListBox.Text][e.Item.Text] = (0, 1);
                            e.Item.SubItems[1].Text = "{ range=(0, 1) }";
                        }
                        else if (e.Item.Text == "Standardization")
                            InputScalersDictionary[columnListBox.Text][e.Item.Text] = (0, 1);
                    }
                    else
                        InputScalersDictionary[columnListBox.Text] = new Dictionary<string, (double, double)>();
                }
                else if (OutputScalersDictionary.ContainsKey(columnListBox.Text))
                {
                    if (e.Item.Checked)
                    {
                        if (e.Item.Text == "Min-max scaling")
                        {
                            OutputScalersDictionary[columnListBox.Text][e.Item.Text] = (0, 1);
                            e.Item.SubItems[1].Text = "{ range=(0, 1) }";
                        }
                        else if (e.Item.Text == "Standardization")
                            OutputScalersDictionary[columnListBox.Text][e.Item.Text] = (0, 1);
                    }
                    else
                        OutputScalersDictionary[columnListBox.Text] = new Dictionary<string, (double, double)>();
                }

            }
            else if (e.Item.Group.Header == "Dimensionality Reduction")
            {
                // Add/remove the step from the list
                if (e.Item.Checked)
                {
                    if (e.Item.Text == "Variance threshold")
                    {
                        Dictionary<string, double> parameters = new()
                        {
                            { "threshold", 0.1 }
                        };
                        DimensionalityReductionStepsDictionary[e.Item.Text] = parameters;
                        e.Item.SubItems[1].Text = "{ threshold=0.1 }";
                    }
                    else if (e.Item.Text == "Principle component analysis")
                    {
                        Dictionary<string, double> parameters = new()
                        {
                            { "nComponents", 32 }
                        };
                        DimensionalityReductionStepsDictionary[e.Item.Text] = parameters;
                        e.Item.SubItems[1].Text = "{ nComponents=32 }";
                    }
                }
                else
                    DimensionalityReductionStepsDictionary.Remove(e.Item.Text);
            }

            // Enable/disable the edit button
            if (processingStepsListView.SelectedItems.Count == 0)
                return;

            if (processingStepsListView.SelectedItems[0].Checked &&
                (processingStepsListView.SelectedItems[0].Text == "Min-max scaling" ||
                processingStepsListView.SelectedItems[0].Text == "Variance threshold" ||
                processingStepsListView.SelectedItems[0].Text == "Principle component analysis"))
                editButton.Enabled = true;
            else
                editButton.Enabled = false;
        }

        private void ProcessingStepsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable the edit button
            if (processingStepsListView.SelectedItems.Count == 0)
                return;

            if (processingStepsListView.SelectedItems[0].Checked &&
                (processingStepsListView.SelectedItems[0].Text == "Min-max scaling" ||
                processingStepsListView.SelectedItems[0].Text == "Variance threshold" ||
                processingStepsListView.SelectedItems[0].Text == "Principle component analysis"))
                editButton.Enabled = true;
            else
                editButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (processingStepsListView.SelectedItems.Count == 0)
                return;

            if (processingStepsListView.SelectedItems[0].Text == "Min-max scaling")
            {
                EditParametersDialog editParametersDialog = new();
                if (InputScalersDictionary.ContainsKey(columnListBox.Text))
                    (editParametersDialog.Parameters["Min output"], editParametersDialog.Parameters["Max output"]) = InputScalersDictionary[columnListBox.Text]["Min-max scaling"];
                else if (OutputScalersDictionary.ContainsKey(columnListBox.Text))
                    (editParametersDialog.Parameters["Min output"], editParametersDialog.Parameters["Max output"]) = OutputScalersDictionary[columnListBox.Text]["Min-max scaling"];

                if (editParametersDialog.ShowDialog(this) == DialogResult.OK)
                {
                    double minOutput = editParametersDialog.Parameters["Min output"];
                    double maxOutput = editParametersDialog.Parameters["Max output"];

                    processingStepsListView.Items[0].SubItems[1].Text = "{ range=(" + minOutput.ToString() + ", " + maxOutput.ToString() + ") }";

                    if (InputScalersDictionary.ContainsKey(columnListBox.Text))
                        InputScalersDictionary[columnListBox.Text]["Min-max scaling"] = (minOutput, maxOutput);
                    else if (OutputScalersDictionary.ContainsKey(columnListBox.Text))
                        OutputScalersDictionary[columnListBox.Text]["Min-max scaling"] = (minOutput, maxOutput);
                }
            }
            else if (processingStepsListView.SelectedItems[0].Text == "Variance threshold")
            {
                EditParametersDialog editParametersDialog = new();
                editParametersDialog.Parameters["threshold"] = DimensionalityReductionStepsDictionary["Variance threshold"]["threshold"];
                if (editParametersDialog.ShowDialog(this) == DialogResult.OK)
                {
                    double threshold = editParametersDialog.Parameters["threshold"];

                    processingStepsListView.Items[2].SubItems[1].Text = "{ threshold=" + threshold.ToString() + " }";

                    Dictionary<string, double> parameters = new()
                    {
                        { "threshold", threshold }
                    };
                    DimensionalityReductionStepsDictionary["Variance threshold"] = parameters;
                }
            }
            if (processingStepsListView.SelectedItems[0].Text == "Principle component analysis")
            {
                EditParametersDialog editParametersDialog = new();
                editParametersDialog.Parameters["nComponents"] = DimensionalityReductionStepsDictionary["Principle component analysis"]["nComponents"]; ;
                if (editParametersDialog.ShowDialog(this) == DialogResult.OK)
                {
                    double nComponents = editParametersDialog.Parameters["nComponents"];

                    processingStepsListView.Items[3].SubItems[1].Text = "{ nComponents=" + nComponents.ToString() + " }";
                    Dictionary<string, double> parameters = new()
                    {
                        { "nComponents", nComponents }
                    };
                    DimensionalityReductionStepsDictionary["Principle component analysis"] = parameters;
                }
            }
        }
        #endregion
    }
}
