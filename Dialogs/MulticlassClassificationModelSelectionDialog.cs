using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadeChem.Dialogs
{
    public partial class MulticlassClassificationModelSelectionDialog : Form
    {
        #region Property
        public string ModelName { get { return modelComboBox.Text; } }
        #endregion

        #region Constructor
        public MulticlassClassificationModelSelectionDialog()
        {
            InitializeComponent();

            modelComboBox.SelectedIndex = 0;
        }
        #endregion
    }
}
