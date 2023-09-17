using Accord.Statistics;

namespace JadeChem.Utils
{
    public class StandardScaler
    {
        #region Fields
        private double mean;
        private double std;
        #endregion

        #region Constructor
        public StandardScaler() { }
        #endregion

        #region Methods
        public double[] FitTransform(double[] inputs)
        {
            Fit(inputs);
            return Transform(inputs);
        }

        public void Fit(double[] inputs)
        {
            mean = inputs.Mean();
            std = inputs.StandardDeviation();
        }

        public double[] Transform(double[] inputs)
        {
            double[] output = new double[inputs.Length];
            for (int elementIndex = 0; elementIndex < inputs.Length; elementIndex++)
            {
                output[elementIndex] = (inputs[elementIndex] - mean) / std;
            }

            return output;
        }

        public double Transform(double input)
        {
            double output = (input - mean) / std;

            return output;
        }

        public double[] InverseTransform(double[] outputs)
        {
            double[] inputs = new double[outputs.Length];
            for (int elementIndex = 0; elementIndex < outputs.Length; elementIndex++)
            {
                inputs[elementIndex] = outputs[elementIndex] * std + mean;
            }

            return inputs;
        }

        public double InverseTransform(double output)
        {
            double input = output * std + mean;

            return input;
        }
        #endregion
    }
}
