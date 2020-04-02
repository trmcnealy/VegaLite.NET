using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class LegendStreamBinding
    {
        [JsonProperty("legend",
                      Required = Required.Always)]
        public OnUnion Legend { get; set; }
    }
}
