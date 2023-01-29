using Accord.Controls;
using Accord.Math;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class SVMClassificationModelControl : UserControl
    {
        // Constructor
        public SVMClassificationModelControl(double[][] supportVectors, double[] weights, string[] features, string target, double[][] inputColumns, string[] outputColumn)
        {
            InitializeComponent();

            int[] supportVectorsIndexes = new int[supportVectors.Length];
            for (int i = 0; i < supportVectors.Length; i++)
                supportVectorsIndexes[i] = inputColumns.Find(supportVector => supportVector.SequenceEqual(supportVectors[i]))[0];

            string[][] supportVectorsWithWeights = new string[supportVectors.Length][];
            for (int rowIndex = 0; rowIndex < supportVectorsWithWeights.Length; rowIndex++)
            {
                string[] supportVector = new string[features.Length];
                supportVector = supportVectors[rowIndex].ToString(supportVector);
                supportVectorsWithWeights[rowIndex] = supportVector.Concatenate(outputColumn[supportVectorsIndexes[rowIndex]]).Concatenate(weights[rowIndex].ToString());
            }
            string[] inputColumnNamesWithWeight = features.Concatenate(target).Concatenate("Weight");
            supportVectorsDataGridView.DataSource = new ArrayDataView(supportVectorsWithWeights, inputColumnNamesWithWeight);
        }
    }
}
