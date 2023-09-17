using Accord.Math;
using Accord.Statistics;

namespace JadeChem.Utils
{
    public class VarianceThresholdFilter
    {
        #region Fields
        private string[] columnNames;
        private int[] filteredColumnIndices;
        #endregion

        #region Constructor
        public VarianceThresholdFilter() { }
        #endregion

        #region Methods
        public (string[], double[][]) FitTransform(string[] columnNames, double[][] inputColumns, double threshold)
        {
            Fit(columnNames, inputColumns, threshold);
            return Transform(inputColumns);
        }

        public void Fit(string[] columnNames, double[][] inputColumns, double threshold)
        {
            this.columnNames = columnNames;

            // Filter the columns greater than threshold and add the indices to a list
            List<int> filteredColumnIndices = new();
            for (int columnIndex = 0; columnIndex < inputColumns.Columns(); columnIndex++)
            {
                double[] column = inputColumns.GetColumn(columnIndex);

                if (column.Variance() >= threshold)
                    filteredColumnIndices.Add(columnIndex);
            }

            if (filteredColumnIndices.Count == 0)
                throw new Exception("All columns will be removed after applying variance threshold filter!");

            this.filteredColumnIndices = filteredColumnIndices.ToArray();
        }

        public (string[], double[][]) Transform(double[][] inputColumns)
        {
            // Get the outputs
            string[] filteredColumnNames = columnNames.Get(filteredColumnIndices);
            double[][] filteredColumns = inputColumns.GetColumns(filteredColumnIndices);

            return (filteredColumnNames, filteredColumns);
        }

        public double[] Transform(double[] inputRow)
        {
            return inputRow.Get(filteredColumnIndices);
        }
        #endregion
    }
}
