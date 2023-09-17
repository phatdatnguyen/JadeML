using System;
using System.Collections.Generic;
namespace JadeChem.Dialogs
{
    public partial class HiddenLayerDialog : Form
    {
        #region Properties
        public int NumberOfNeurons { get; set; }
        public string ActivationFunction { get; set; }
        #endregion

        #region Constructor
        public HiddenLayerDialog()
        {
            InitializeComponent();

            NumberOfNeurons = 32;
            ActivationFunction = "ReLU";
        }
        #endregion

        #region Methods
        private void HiddenLayerDialog_Load(object sender, EventArgs e)
        {
            numberOfNeuronsNumericUpDown.Value = NumberOfNeurons;
            activationFunctionComboBox.Text = ActivationFunction;
        }

        private void AddHiddenLayerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            NumberOfNeurons = (int)numberOfNeuronsNumericUpDown.Value;
            ActivationFunction = (string)activationFunctionComboBox.SelectedItem;
        }
        #endregion
    }
}
