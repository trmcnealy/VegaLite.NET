using Newtonsoft.Json;

namespace VegaLite
{
    public class WindowFieldDef
    {
        /// <summary>
        /// The output name for the window operation.
        /// </summary>
        [JsonProperty("as", Required = Required.Always)]
        public string As { get; set; }

        /// <summary>
        /// The data field for which to compute the aggregate or window function. This can be omitted
        /// for window functions that do not operate over a field such as `"count"`, `"rank"`,
        /// `"dense_rank"`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The window or aggregation operation to apply within a window (e.g., `"rank"`, `"lead"`,
        /// `"sum"`, `"average"` or `"count"`). See the list of all supported operations
        /// [here](https://vega.github.io/vega-lite/docs/window.html#ops).
        /// </summary>
        [JsonProperty("op", Required = Required.Always)]
        public Op? Op { get; set; }

        /// <summary>
        /// Parameter values for the window functions. Parameter values can be omitted for operations
        /// that do not accept a parameter.
        ///
        /// See the list of all supported operations and their parameters
        /// [here](https://vega.github.io/vega-lite/docs/transforms/window.html).
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public double? Param { get; set; }
    }
}