using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Statistics.Kernels;
using System.Data;

namespace JadeChem.Dialogs
{
    public partial class MulticlassSupportVectorsDialog : Form
    {
        #region Fields
        private readonly SupportVectorMachine<IKernel>[] svmModels;
        private readonly string[] inputColunnNames;
        #endregion

        #region Contructor
        public MulticlassSupportVectorsDialog(MulticlassSupportVectorMachine<IKernel> model, string[] inputColunnNames)
        {
            InitializeComponent();

            svmModels = model.Models.Flatten();
            this.inputColunnNames = inputColunnNames;

            svmComboBox.Items.Clear();
            for (int svmIndex = 0; svmIndex < svmModels.Length; svmIndex++)
                svmComboBox.Items.Add("Support vector machine " + (svmIndex + 1).ToString());

            svmComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Method
        private void SVMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (svmComboBox.SelectedIndex == -1)
                return;

            DataTable supportVectorsDataTable = svmModels[svmComboBox.SelectedIndex].SupportVectors.ToTable(inputColunnNames);
            supportVectorsDataGridView.DataSource = supportVectorsDataTable;
        }
        #endregion
    }
}
