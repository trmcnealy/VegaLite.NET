using Newtonsoft.Json;

namespace VegaLite
{
    public class JoinAggregateFieldDef
    {
        /// <summary>
        /// The output name for the join aggregate operation.
        /// </summary>
        [JsonProperty("as", Required = Required.Always)]
        public string As { get; set; }

        /// <summary>
        /// The data field for which to compute the aggregate function. This can be omitted for
        /// functions that do not operate over a field such as `"count"`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The aggregation operation to apply (e.g., `"sum"`, `"average"` or `"count"`). See the
        /// list of all supported operations
        /// [here](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
        /// </summary>
        [JsonProperty("op", Required = Required.Always)]
        public AggregateOp Op { get; set; }
    }
}