using Newtonsoft.Json;

namespace VegaLite
{
    public class ConditionalAxisPropertyTextBaselineNull
    {
        [JsonProperty("condition", Required = Required.Always)]
        public ConditionalAxisPropertyTextBaselineNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", Required = Required.AllowNull)]
        public Baseline? Value { get; set; }
    }
}