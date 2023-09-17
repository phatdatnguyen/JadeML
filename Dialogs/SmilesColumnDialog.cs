using System;
using System.Collections.Generic;
namespace JadeChem.Dialogs
{
    public partial class SmilesColumnDialog : Form
    {
        #region Field
        private readonly List<string> columnNames = new();
        #endregion

        #region Property
        public string SelectedColumnName { get; set; }
        #endregion

        #region Constructor
        public SmilesColumnDialog(List<string> columnNames)
        {
            InitializeComponent();
            this.columnNames = columnNames;

            foreach (string columnName in columnNames)
                columnComboBox.Items.Add(columnName);

            columnComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Method
        private void EditSplitRatioDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                SelectedColumnName = columnComboBox.Text;
            }
        }
        #endregion
    }
}
