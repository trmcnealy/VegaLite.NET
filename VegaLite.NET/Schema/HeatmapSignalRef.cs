using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class HeatmapSignalRef
    {
        [JsonProperty("signal",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("count",
                      NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Count { get; set; }

        [JsonProperty("extent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public SignalRefExtent? Extent { get; set; }

        [JsonProperty("scheme",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme? Scheme { get; set; }
    }
}
