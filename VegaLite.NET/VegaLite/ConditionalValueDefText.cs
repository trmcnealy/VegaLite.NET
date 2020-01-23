using Newtonsoft.Json;

namespace VegaLite
{
    public class ConditionalValueDefText
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", Required = Required.Always)]
        public Text Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }
}