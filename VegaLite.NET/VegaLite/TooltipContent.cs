using Newtonsoft.Json;

namespace VegaLite
{
    public class TooltipContent
    {
        [JsonProperty("content", Required = Required.Always)]
        public Content Content { get; set; }
    }
}