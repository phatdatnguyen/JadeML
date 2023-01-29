using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class DecisionTreeLearningControl : UserControl
    {
        // Constructor
        public DecisionTreeLearningControl()
        {
            InitializeComponent();

            MethodComboBox.SelectedIndex = 0;
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            learningParameters.Add("method", MethodComboBox.SelectedIndex.ToString());
            
            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            MethodComboBox.SelectedIndex = Convert.ToInt32(learningParameters["method"]);
        }
    }
}
