using Newtonsoft.Json;

namespace VegaLite
{
    public class PaddingClass
    {
        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bottom { get; set; }

        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public double? Left { get; set; }

        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public double? Right { get; set; }

        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public double? Top { get; set; }
    }
}