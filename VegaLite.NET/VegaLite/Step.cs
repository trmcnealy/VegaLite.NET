using Newtonsoft.Json;

namespace VegaLite
{
    public class Step
    {
        /// <summary>
        /// The size (width/height) per discrete step.
        /// </summary>
        [JsonProperty("step", Required = Required.Always)]
        public double StepStep { get; set; }
    }
}