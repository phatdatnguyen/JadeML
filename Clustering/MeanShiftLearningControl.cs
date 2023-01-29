using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Clustering
{
    public partial class MeanShiftLearningControl : UserControl
    {
        // Constructor
        public MeanShiftLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();
            learningParameters.Add("k", RadiusNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            RadiusNumericUpDown.Value = Convert.ToDecimal(learningParameters["k"]);
        }
    }
}
