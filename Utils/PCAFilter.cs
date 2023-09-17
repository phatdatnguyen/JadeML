using Accord.Math;
using Accord.Statistics.Analysis;

namespace JadeChem.Utils
{
    public class PCAFilter
    {
        #region Fields
        private string[] filteredColumnNames;
        private PrincipalComponentAnalysis pca;
        #endregion

        #region Constructor
        public PCAFilter() { }
        #endregion

        #region Methods
        public (string[], double[][]) FitTransform(double[][] inputColumns, int nComponents)
        {
            Fit(inputColumns, nComponents);
            return Transform(inputColumns);
        }

        public void Fit(double[][] inputColumns, int nComponents)
        {
            // Create a pca instance
            pca = new PrincipalComponentAnalysis()
            {
                Method = PrincipalComponentMethod.Center,
                NumberOfOutputs = Math.Min(inputColumns.Columns(), nComponents),
                Whiten = true
            };

            // Train the pca
            pca.Learn(inputColumns);

            // Get the column names
            filteredColumnNames = new string[pca.NumberOfOutputs];

            for (int columnIndex = 0; columnIndex < pca.NumberOfOutputs; columnIndex++)
                filteredColumnNames[columnIndex] = "PC" + (columnIndex + 1).ToString();
        }

        public (string[], double[][]) Transform(double[][] inputColumns)
        {
            double[][] filteredColumns = pca.Transform(inputColumns);

            return (filteredColumnNames, filteredColumns);
        }

        public double[] Transform(double[] inputRow)
        {
            double[][] filteredData = pca.Transform(inputRow.ToJagged(false));
            return filteredData.GetRow(0);
        }
        #endregion
    }
}
