using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class DiscreteWidthClass
    {
        [JsonProperty("step",
                      Required = Required.Always)]
        public double Step { get; set; }
    }
}
