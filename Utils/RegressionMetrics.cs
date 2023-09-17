using Accord.Statistics;

namespace JadeChem.Utils
{
    public static class RegressionMetrics
    {
        #region Methods
        public static double MeanAbsoluteError(double[] array1, double[] array2)
        {
            double meanAbsoluteError = 0;

            for (int rowIndex = 0; rowIndex < array1.Length; rowIndex++)
                meanAbsoluteError += Math.Abs(array1[rowIndex] - array2[rowIndex]);
            
            meanAbsoluteError /= array1.Length;

            return meanAbsoluteError;
        }

        public static double MeanSquaredError(double[] array1, double[] array2)
        {
            double meanSquaredError = 0;

            for (int rowIndex = 0; rowIndex < array1.Length; rowIndex++)
                meanSquaredError += Math.Pow(array1[rowIndex] - array2[rowIndex], 2);

            meanSquaredError /= array1.Length;

            return meanSquaredError;
        }

        public static double RootMeanSquaredError(double[] array1, double[] array2)
        {
            double rootMeanSquaredError = 0;

            for (int rowIndex = 0; rowIndex < array1.Length; rowIndex++)
                rootMeanSquaredError += Math.Pow(array1[rowIndex] - array2[rowIndex], 2);

            rootMeanSquaredError = Math.Sqrt(rootMeanSquaredError / array1.Length);

            return rootMeanSquaredError;
        }

        public static double PearsonCorrelationCoefficient(double[] array1, double[] array2)
        {
            double covarience = array1.Covariance(array2);
            double r = covarience / (array1.StandardDeviation() * array2.StandardDeviation());

            return r;
        }

        public static double RSquared(double[] array1, double[] array2)
        {
            double sumOfSquaresResidual = 0;
            double totalSumOfSquares = 0;

            double expectedMean = array2.Mean();

            for (int rowIndex = 0; rowIndex < array1.Length; rowIndex++)
            {
                sumOfSquaresResidual += Math.Pow(array2[rowIndex] - array1[rowIndex], 2);
                totalSumOfSquares += Math.Pow(array2[rowIndex] - expectedMean, 2);
            }

            double rSquared = 1 - (sumOfSquaresResidual / totalSumOfSquares);

            return rSquared;
        }
        #endregion

    }
}
