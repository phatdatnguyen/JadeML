using Accord.Math;

namespace JadeChem.Utils
{
    public class OneHotEncoder
    {
        #region Field
        private string[] classLabels;
        #endregion

        #region Constructor
        public OneHotEncoder() { }
        #endregion

        #region Methods
        public byte[][] FitTransform(string[] inputs)
        {
            Fit(inputs);
            return Transform(inputs);
        }

        public void Fit(string[] inputs)
        {
            classLabels = inputs.Distinct().OrderBy(x => x).ToArray();
        }

        public byte[][] Transform(string[] inputs)
        {
            byte[][] outputs = new byte[inputs.Length][];
            for (int rowIndex = 0; rowIndex < inputs.Length; rowIndex++)
            {
                outputs[rowIndex] = new byte[classLabels.Length];
                for (int classIndex = 0; classIndex < classLabels.Length; classIndex++)
                    if (classIndex == classLabels.IndexOf(inputs[rowIndex]))
                        outputs[rowIndex][classIndex] = 1;
                    else
                        outputs[rowIndex][classIndex] = 0;
            }

            return outputs;
        }

        public string[] InverseTranform(byte[][] outputs)
        {
            string[] inputs = new string[outputs.Length];
            for (int rowIndex = 0; rowIndex < inputs.Length; rowIndex++)
            {
                int classIndex = outputs[rowIndex].IndexOf((byte)1);
                inputs[rowIndex] = classLabels[classIndex];
            }

            return inputs;
        }
        #endregion
    }
}
