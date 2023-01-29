using Accord.Controls;
using Accord.Math;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class SVMRegressionModelControl : UserControl
    {
        // Constructor
        public SVMRegressionModelControl(double[][] supportVectors, double[] weights, string[] features, string target, double[][] inputColumns, double[] outputColumn)
        {
            InitializeComponent();

            int[] supportVectorsIndexes = new int[supportVectors.Length];
            supportVectorsIndexes = new int[supportVectors.Length];
            bool temp = inputColumns[0][0] == supportVectors[0][0];
            for (int i = 0; i < supportVectors.Length; i++)
                supportVectorsIndexes[i] = inputColumns.Find(supportVector => supportVector.SequenceEqual(supportVectors[i]))[0];

            // Show support vectors on the Support Vectors tab page
            string[][] supportVectorsWithWeights = new string[supportVectors.Length][];
            for (int rowIndex = 0; rowIndex < supportVectorsWithWeights.Length; rowIndex++)
            {
                string[] supportVector = new string[features.Length];
                supportVector = supportVectors[rowIndex].ToString(supportVector);
                supportVectorsWithWeights[rowIndex] = supportVector.Concatenate(outputColumn[supportVectorsIndexes[rowIndex]].ToString()).Concatenate(weights[rowIndex].ToString());
            }
            string[] inputColumnNamesWithWeight = features.Concatenate(target).Concatenate("Weight");
            supportVectorsDataGridView.DataSource = new ArrayDataView(supportVectorsWithWeights, inputColumnNamesWithWeight);
        }
    }
}
