using Accord.Math;
using System.Data;

namespace JadeChem.Utils
{
    public class TrainTestSpliter
    {
        #region Fields
        private int[] testIndices;
        private int[] trainIndices;
        #endregion

        #region Properties
        public int[] TrainIndices
        {
            get { return trainIndices; }
        }

        public int[] TestIndices
        {
            get { return testIndices; }
        }
        #endregion

        #region Constructor
        public TrainTestSpliter() { }
        #endregion

        #region Methods
        public (double[][], double[][], double[][], double[][]) Split(double[][] inputColumns, double[][] outputColumns, double testSize = 0.3, int randomSeed = 0)
        {
            // Get the number of rows in the processedDataset
            int totalRowCount = outputColumns.Rows();

            // Calculate the number of rows for the test set
            int testRowCount = (int)Math.Round(testSize * totalRowCount);

            // Throw new exception if train split or test split have 0 row
            if (testRowCount == 0 || totalRowCount - testRowCount == 0)
            {
                throw new Exception("Invalid split");
            }

            // Split
            Random random = new(randomSeed);
            trainIndices = new int[totalRowCount - testRowCount];
            testIndices = new int[testRowCount];

            // Get the indices for test dataset
            for (int testRowIndex = 0; testRowIndex < testRowCount; testRowIndex++)
            {
                int randomIndex;

                do
                {
                    randomIndex = random.Next(totalRowCount);
                }
                while (testIndices.Contains(randomIndex));

                testIndices[testRowIndex] = randomIndex;
            }
            testIndices = testIndices.OrderBy(x => x).ToArray();

            int trainRowIndex = 0;
            for (int rowIndex = 0; rowIndex < totalRowCount; rowIndex++)
            {
                if (!testIndices.Contains(rowIndex))
                {
                    trainIndices[trainRowIndex] = rowIndex;
                    trainRowIndex++;
                    continue;
                }
            }

            // Get the train and test matrix
            double[][] trainInputColumns = inputColumns.GetRows(trainIndices);
            double[][] trainOutputColumns = outputColumns.GetRows(trainIndices);
            double[][] testInputColumns = inputColumns.GetRows(testIndices);
            double[][] testOutputColumns = outputColumns.GetRows(testIndices);

            return (trainInputColumns, trainOutputColumns, testInputColumns, testOutputColumns);
        }

        public (double[][], string[][], double[][], string[][]) Split(double[][] inputColumns, string[][] outputColumns, double testSize = 0.3, int randomSeed = 0)
        {
            // Get the number of rows in the processedDataset
            int totalRowCount = outputColumns.Rows();

            // Calculate the number of rows for the test set
            int testRowCount = (int)Math.Round(testSize * totalRowCount);

            // Throw new exception if train split or test split have 0 row
            if (testRowCount == 0 || totalRowCount - testRowCount == 0)
            {
                throw new Exception("Invalid split");
            }

            // Split
            Random random = new(randomSeed);
            trainIndices = new int[totalRowCount - testRowCount];
            testIndices = new int[testRowCount];

            // Get the indices for test dataset
            for (int testRowIndex = 0; testRowIndex < testRowCount; testRowIndex++)
            {
                int randomIndex;

                do
                {
                    randomIndex = random.Next(totalRowCount);
                }
                while (testIndices.Contains(randomIndex));

                testIndices[testRowIndex] = randomIndex;
            }
            testIndices = testIndices.OrderBy(x => x).ToArray();

            int trainRowIndex = 0;
            for (int rowIndex = 0; rowIndex < totalRowCount; rowIndex++)
            {
                if (!testIndices.Contains(rowIndex))
                {
                    trainIndices[trainRowIndex] = rowIndex;
                    trainRowIndex++;
                    continue;
                }
            }

            // Get the train and test matrix
            double[][] trainInputColumns = inputColumns.GetRows(trainIndices);
            string[][] trainOutputColumns = outputColumns.GetRows(trainIndices);
            double[][] testInputColumns = inputColumns.GetRows(testIndices);
            string[][] testOutputColumns = outputColumns.GetRows(testIndices);

            return (trainInputColumns, trainOutputColumns, testInputColumns, testOutputColumns);
        }
        #endregion
    }
}
