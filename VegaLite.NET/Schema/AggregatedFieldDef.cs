using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class AggregatedFieldDef
    {
        /// <summary>
        /// The output field names to use for each aggregated field.
        /// </summary>
        [JsonProperty("as",
                      Required = Required.Always)]
        public string As { get; set; }

        /// <summary>
        /// The data field for which to compute aggregate function. This is required for all
        /// aggregation operations except `"count"`.
        /// </summary>
        [JsonProperty("field",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The aggregation operation to apply to the fields (e.g., `"sum"`, `"average"`, or
        /// `"count"`).
        /// See the [full list of supported aggregation
        /// operations](https://vega.github.io/vega-lite/docs/aggregate.html#ops)
        /// for more information.
        /// </summary>
        [JsonProperty("op",
                      Required = Required.Always)]
        public AggregateOp Op { get; set; }
    }
}
