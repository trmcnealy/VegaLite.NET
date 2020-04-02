using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class Step
    {
        /// <summary>
        /// The size (width/height) per discrete step.
        /// </summary>
        [JsonProperty("step",
                      Required = Required.Always)]
        public double StepStep { get; set; }
    }
}
