using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class ScaleInterpolateParams
    {
        [JsonProperty("gamma",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Gamma { get; set; }

        [JsonProperty("type",
                      Required = Required.Always)]
        public ScaleInterpolateParamsType? Type { get; set; }
    }
}
