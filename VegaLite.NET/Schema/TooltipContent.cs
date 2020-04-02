using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class TooltipContent
    {
        [JsonProperty("content",
                      Required = Required.Always)]
        public Content Content { get; set; }
    }
}
