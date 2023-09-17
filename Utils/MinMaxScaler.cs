namespace JadeChem.Utils
{
    public class MinMaxScaler
    {
        #region Fields
        readonly double minOutput = 0;
        readonly double maxOutput = 1;
        double minInput = 0;
        double maxInput = 1;
        #endregion

        #region Constructor
        public MinMaxScaler(double minOutput = 0, double maxOutput = 1)
        {
            this.minOutput = minOutput;
            this.maxOutput = maxOutput;
        }
        #endregion

        #region Methods
        public double[] FitTransform(double[] inputs)
        {
            Fit(inputs);
            return Transform(inputs);
        }

        public void Fit(double[] inputs)
        {
            minInput = inputs.Min();
            maxInput = inputs.Max();
        }

        public double[] Transform(double[] inputs)
        {
            double[] outputs = new double[inputs.Length];
            for (int elementIndex = 0; elementIndex < inputs.Length; elementIndex++)
            {
                // Scale to range (0, 1)
                outputs[elementIndex] = (inputs[elementIndex] - minInput) / (maxInput - minInput);

                // Scale to range (minOutput, maxOutput)
                outputs[elementIndex] = outputs[elementIndex] * (maxOutput - minOutput) + minOutput;
            }

            return outputs;
        }

        public double Transform(double input)
        {
            // Scale to range (0, 1)
            double output = (input - minInput) / (maxInput - minInput);

            // Scale to range (minOutput, maxOutput)
            output = output * (maxOutput - minOutput) + minOutput;

            return output;
        }

        public double[] InverseTransform(double[] outputs)
        {
            double[] inputs = new double[outputs.Length];
            for (int elementIndex = 0; elementIndex < outputs.Length; elementIndex++)
            {
                // Scale to range (0, 1)
                inputs[elementIndex] = (outputs[elementIndex] - minOutput) / (maxOutput - minOutput);

                // Scale to range (minInput, maxInput)
                inputs[elementIndex] = inputs[elementIndex] * (maxInput - minInput) + minInput;
            }

            return inputs;
        }

        public double InverseTransform(double output)
        {
            // Scale to range (0, 1)
            double input = (output - minOutput) / (maxOutput - minOutput);

            // Scale to range (minInput, maxInput)
            input = input * (maxInput - minInput) + minInput;

            return input;
        }
        #endregion
    }
}
