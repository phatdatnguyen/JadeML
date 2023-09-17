using MathNet.Numerics.LinearAlgebra;

namespace JadeChem.Models
{
    public class LassoRegression
    {
        #region Fields
        private readonly double lambda;
        private readonly double learningRate;
        private readonly int maxIterations;
        private Vector<double> coefficients;
        #endregion

        #region Property
        public double[] Coefficients { get { return coefficients.ToArray(); } }
        #endregion

        #region Constructor
        public LassoRegression(double lambda, double learningRate, int maxIterations)
        {
            this.lambda = lambda;
            this.learningRate = learningRate;
            this.maxIterations = maxIterations;
        }
        #endregion

        #region Methods
        public void Learn(double[][]? inputColumns, double[]? outputColumn)
        {
            if (inputColumns == null)
                throw new ArgumentNullException(nameof(inputColumns));

            if (outputColumn == null)
                throw new ArgumentNullException(nameof(outputColumn));

            var inputMatrix = Matrix<double>.Build.DenseOfRowArrays(inputColumns);
            inputMatrix = inputMatrix.Append(Matrix<double>.Build.Dense(inputMatrix.RowCount, 1, 1)); // Add a column of 1s for intercept
            var outputVector = Vector<double>.Build.Dense(outputColumn);

            int numberOfColumns = inputMatrix.ColumnCount;

            // Initialize coefficients to zeros
            coefficients = Vector<double>.Build.Dense(numberOfColumns);

            double lambdaFactor = 2 * lambda * learningRate;
            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                Vector<double> residuals = outputVector - inputMatrix * coefficients;
                Vector<double> gradients = -2 * inputMatrix.Transpose() * residuals + lambdaFactor * coefficients.Map(x => x >= 0 ? 1.0 : -1.0);

                for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++)
                {
                    double oldCoefficient = coefficients[columnIndex];
                    double newCoefficient = oldCoefficient - learningRate * gradients[columnIndex];

                    coefficients[columnIndex] = newCoefficient;
                }
            }
        }

        public double[] Transform(double[][]? inputColumns)
        {
            if (inputColumns == null)
                throw new ArgumentNullException(nameof(inputColumns));

            double[] transformedData = new double[inputColumns.Length];

            for (int i = 0; i < inputColumns.Length; i++)
            {
                Vector<double> inputVector = Vector<double>.Build.DenseOfArray(inputColumns[i]);
                inputVector = Vector<double>.Build.DenseOfEnumerable(inputVector.Append(1)); // For intercept
                transformedData[i] = inputVector.DotProduct(coefficients);
            }

            return transformedData;
        }

        public double Transform(double[]? inputRow)
        {
            if (inputRow == null)
                throw new ArgumentNullException(nameof(inputRow));

            Vector<double> inputVector = Vector<double>.Build.DenseOfArray(inputRow);
            inputVector = Vector<double>.Build.DenseOfEnumerable(inputVector.Append(1)); // For intercept
            return inputVector.DotProduct(coefficients);
        }
        #endregion
    }
}
