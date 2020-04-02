using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class ConditionalPredicateValueDefNumberNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test",
                      Required = Required.Always)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value",
                      Required = Required.AllowNull)]
        public List<double> Value { get; set; }
    }
}
