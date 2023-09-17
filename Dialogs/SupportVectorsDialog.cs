using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Statistics.Kernels;
using System.Data;

namespace JadeChem.Dialogs
{
    public partial class SupportVectorsDialog : Form
    {
        #region Contructor
        public SupportVectorsDialog(SupportVectorMachine<IKernel> model, string[] inputColunnNames)
        {
            InitializeComponent();

            DataTable supportVectorsDataTable = model.SupportVectors.ToTable(inputColunnNames);
            supportVectorsDataGridView.DataSource = supportVectorsDataTable;
        }
        #endregion
    }
}
