namespace JadeChem.Dialogs
{
    public partial class MLPStructureDialog : Form
    {
        #region Field
        private readonly string[] inputColunnNames;
        #endregion

        #region Constructor
        public MLPStructureDialog(Dictionary<int, (Dictionary<int, (List<double>, double)>, string)> mlpNetworkStructure, string[] inputColunnNames)
        {
            InitializeComponent();

            this.inputColunnNames = inputColunnNames;

            // Network node
            TreeNode networkNode = networkTreeView.Nodes.Add("MLP");
            networkNode.ForeColor = Color.Brown;
            networkNode.NodeFont = new Font(Font, FontStyle.Bold);
            Dictionary<string, object> networkNodeInfo = new()
            {
                ["node type"] = "network node"
            };
            networkNode.Tag = networkNodeInfo;

            // Layer nodes
            for (int layerIndex = 0; layerIndex < mlpNetworkStructure.Keys.Count; layerIndex++)
            {
                (Dictionary<int, (List<double>, double)> neuronDictionary, string activationFunction) = mlpNetworkStructure[layerIndex];

                string layerName;
                if (layerIndex != mlpNetworkStructure.Keys.Count - 1) // Hidden layer
                    layerName = "Hidden layer " + (layerIndex + 1).ToString();
                else
                    layerName = "Output layer";
                int numberOfInputs = neuronDictionary[0].Item1.Count;
                int numberOfNeurons = neuronDictionary.Keys.Count;
                TreeNode layerNode = networkNode.Nodes.Add(layerName);

                Dictionary<string, object> layerNodeInfo = new()
                {
                    ["node type"] = "layer node",
                    ["layer name"] = layerName,
                    ["number of inputs"] = numberOfInputs,
                    ["number of neurons"] = numberOfNeurons,
                    ["activation function"] = activationFunction
                };
                layerNode.Tag = layerNodeInfo;

                for (int neuronIndex = 0; neuronIndex < neuronDictionary.Keys.Count; neuronIndex++)
                {
                    (List<double> weights, double bias) = neuronDictionary[neuronIndex];

                    TreeNode neuronNode;
                    if (layerIndex != mlpNetworkStructure.Keys.Count - 1) // Hidden layer
                        neuronNode = layerNode.Nodes.Add("Hidden" + (layerIndex + 1).ToString() + "_" + (neuronIndex + 1).ToString());
                    else // Output layer
                        neuronNode = layerNode.Nodes.Add("Output" + (neuronIndex + 1).ToString());
                    neuronNode.ForeColor = Color.Green;

                    Dictionary<string, object> neuronNodeInfo = new()
                    {
                        ["node type"] = "neuron node",
                        ["layer name"] = layerName,
                        ["number of inputs"] = numberOfInputs,
                        ["number of neurons"] = numberOfNeurons,
                        ["activation function"] = activationFunction,
                        ["layer index"] = layerIndex,
                        ["weights"] = weights,
                        ["bias"] = bias
                    };
                    neuronNode.Tag = neuronNodeInfo;
                }
            }
        }
        #endregion

        #region Method
        private void NetworkTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = networkTreeView.SelectedNode;

            if (selectedNode.Tag == null)
                return;

            Dictionary<string, object> nodeInfo = (Dictionary<string, object>)selectedNode.Tag;
            if ((string)nodeInfo["node type"] == "layer node")
            {
                layerNameTextBox.Text = (string)nodeInfo["layer name"];
                numberOfInputsTextBox.Text = ((int)nodeInfo["number of inputs"]).ToString();
                numberOfNeuronsTextBox.Text = ((int)nodeInfo["number of neurons"]).ToString();
                activationFunctionTextBox.Text = (string)nodeInfo["activation function"];

                weightsAndBiasDataGridView.Columns.Clear();
            }
            else if ((string)nodeInfo["node type"] == "neuron node")
            {
                layerNameTextBox.Text = (string)nodeInfo["layer name"];
                numberOfInputsTextBox.Text = ((int)nodeInfo["number of inputs"]).ToString();
                numberOfNeuronsTextBox.Text = ((int)nodeInfo["number of neurons"]).ToString();
                activationFunctionTextBox.Text = (string)nodeInfo["activation function"];

                int layerIndex = (int)nodeInfo["layer index"];
                List<double> weights = (List<double>)nodeInfo["weights"];
                double bias = (double)nodeInfo["bias"];
                weightsAndBiasDataGridView.Columns.Clear();
                weightsAndBiasDataGridView.Columns.Add("Input", "Input");
                weightsAndBiasDataGridView.Columns.Add("Value", "Value");
                for (int weightIndex = 0; weightIndex < weights.Count; weightIndex++)
                {
                    weightsAndBiasDataGridView.Rows.Add();

                    string inputNeuronName;
                    if (layerIndex == 0) // first hidden layer
                        inputNeuronName = inputColunnNames[weightIndex];
                    else
                        inputNeuronName = "Hidden" + (layerIndex).ToString() + "_" + (weightIndex + 1).ToString();

                    weightsAndBiasDataGridView.Rows[weightIndex].Cells[0].Value = inputNeuronName;
                    weightsAndBiasDataGridView.Rows[weightIndex].Cells[1].Value = weights[weightIndex];
                }
                weightsAndBiasDataGridView.Rows.Add();
                weightsAndBiasDataGridView.Rows[weights.Count].Cells[0].Value = "Bias";
                weightsAndBiasDataGridView.Rows[weights.Count].Cells[1].Value = bias.ToString();
            }
            else
            {
                layerNameTextBox.Text = "";
                numberOfInputsTextBox.Text = "";
                numberOfNeuronsTextBox.Text = "";
                activationFunctionTextBox.Text = "";

                weightsAndBiasDataGridView.Columns.Clear();
            }
        }
        #endregion
    }
}
