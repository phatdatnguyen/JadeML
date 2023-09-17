using MathNet.Numerics.LinearAlgebra;

namespace JadeChem.Models
{
    public class RidgeRegression
    {
        #region Fields
        private readonly double lambda;
        private Vector<double> coefficients;
        #endregion

        #region Property
        public double[] Coefficients { get { return coefficients.ToArray(); } }
        #endregion

        #region Constructor
        public RidgeRegression(double lambda)
        {
            this.lambda = lambda;
        }
        #endregion

        #region Methods
        public void Learn(double[][]? inputColumns, double[]? outputColumn)
        {
            if (inputColumns == null)
                throw new ArgumentNullException(nameof(inputColumns));

            if (outputColumn == null)
                throw new ArgumentNullException(nameof(inputColumns));

            Matrix<double> inputMatrix = Matrix<double>.Build.DenseOfRowArrays(inputColumns);
            inputMatrix = inputMatrix.Append(Matrix<double>.Build.Dense(inputMatrix.RowCount, 1, 1)); // Add a column of 1s for intercept
            Vector<double> outputVector = Vector<double>.Build.Dense(outputColumn);

            Matrix<double> inputMatrixTranspose = inputMatrix.Transpose();
            Matrix<double> identityMatrix = Matrix<double>.Build.DenseIdentity(inputMatrix.ColumnCount);
            coefficients = (inputMatrixTranspose * inputMatrix + lambda * identityMatrix).Inverse() * inputMatrixTranspose * outputVector;
        }

        public double[] Transform(double[][]? inputColumns)
        {
            if (inputColumns == null)
                throw new ArgumentNullException(nameof(inputColumns));

            double[] transformedData = new double[inputColumns.Length];

            for (int rowIndex = 0; rowIndex < inputColumns.Length; rowIndex++)
            {
                Vector<double> inputVector = Vector<double>.Build.DenseOfArray(inputColumns[rowIndex]);
                inputVector = Vector<double>.Build.DenseOfEnumerable(inputVector.Append(1)); // For intercept
                transformedData[rowIndex] = inputVector.DotProduct(coefficients);
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
