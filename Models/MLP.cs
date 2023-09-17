using Accord.MachineLearning.Bayes;
using System.Collections.Generic;
using TorchSharp;
using TorchSharp.Modules;
using static TorchSharp.torch;
using static TorchSharp.torch.nn;
using static TorchSharp.torch.optim.lr_scheduler.impl;

namespace JadeChem.Models
{
    [Serializable]
    public class MLP : Module<Tensor, Tensor>
    {
        #region Field
        private readonly Sequential sequential;
        #endregion

        #region Property
        public Sequential Sequential { get { return sequential; } }
        #endregion

        #region Constructor
        public MLP(string name, int inputSize, int[] hiddenSizes, string[] activationFunctions, int outputSize) : base(name)
        {
            List<(string, Module<Tensor, Tensor>)> modules = new();
            for (int layerIndex = 0; layerIndex < hiddenSizes.Length; layerIndex++)
            {
                // Hidden layers
                if (layerIndex == 0)
                    modules.Add(("hidden" + (layerIndex + 1).ToString(), Linear(inputSize, hiddenSizes[layerIndex])));
                else
                    modules.Add(("hidden" + (layerIndex + 1).ToString(), Linear(hiddenSizes[layerIndex - 1], hiddenSizes[layerIndex])));

                // Activation functions
                switch (activationFunctions[layerIndex])
                {
                    case "ReLU":
                        modules.Add(("activation" + (layerIndex + 1).ToString(), ReLU()));

                        break;
                    case "LeakyReLU":
                        modules.Add(("activation" + (layerIndex + 1).ToString(), LeakyReLU()));

                        break;
                    case "Sigmoid":
                        modules.Add(("activation" + (layerIndex + 1).ToString(), Sigmoid()));

                        break;
                    case "Tanh":
                        modules.Add(("activation" + (layerIndex + 1).ToString(), Tanh()));

                        break;
                }
            }
            // Output layer
            modules.Add(("output", Linear(hiddenSizes.Last(), outputSize)));

            sequential = Sequential(modules);

            RegisterComponents();
        }
        #endregion

        #region Method
        public override Tensor forward(Tensor input)
        {
            Tensor x = input;
            return sequential.forward(x);
        }
        #endregion
    }
}
