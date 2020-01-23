using Newtonsoft.Json;

namespace VegaLite
{
    public class DiscreteHeightClass
    {
        [JsonProperty("step", Required = Required.Always)]
        public double Step { get; set; }
    }
}