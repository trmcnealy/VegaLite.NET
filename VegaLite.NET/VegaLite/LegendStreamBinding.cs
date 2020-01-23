using Newtonsoft.Json;

namespace VegaLite
{
    public class LegendStreamBinding
    {
        [JsonProperty("legend", Required = Required.Always)]
        public OnUnion Legend { get; set; }
    }
}