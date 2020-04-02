using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class LegendResolveMap
    {
        [JsonProperty("color",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Color { get; set; }

        [JsonProperty("fill",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Fill { get; set; }

        [JsonProperty("fillOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? FillOpacity { get; set; }

        [JsonProperty("opacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Opacity { get; set; }

        [JsonProperty("shape",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Shape { get; set; }

        [JsonProperty("size",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Size { get; set; }

        [JsonProperty("stroke",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Stroke { get; set; }

        [JsonProperty("strokeOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? StrokeOpacity { get; set; }

        [JsonProperty("strokeWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? StrokeWidth { get; set; }
    }
}
