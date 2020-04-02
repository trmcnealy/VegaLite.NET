using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class DiscreteHeightClass
    {
        [JsonProperty("step",
                      Required = Required.Always)]
        public double Step { get; set; }
    }
}
