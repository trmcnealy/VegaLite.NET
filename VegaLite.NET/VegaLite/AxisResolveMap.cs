using Newtonsoft.Json;

namespace VegaLite
{
    public class AxisResolveMap
    {
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Y { get; set; }
    }
}