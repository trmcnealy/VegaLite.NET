using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// A sort definition for sorting a discrete scale in an encoding field definition.
    /// </summary>
    public class EncodingSortField
    {
        /// <summary>
        /// The data [field](https://vega.github.io/vega-lite/docs/field.html) to sort by.
        ///
        /// __Default value:__ If unspecified, defaults to the field specified in the outer data
        /// reference.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public Field? Field { get; set; }

        /// <summary>
        /// An [aggregate operation](https://vega.github.io/vega-lite/docs/aggregate.html#ops) to
        /// perform on the field prior to sorting (e.g., `"count"`, `"mean"` and `"median"`).
        /// An aggregation is required when there are multiple values of the sort field for each
        /// encoded data field.
        /// The input data objects will be aggregated, grouped by the encoded data field.
        ///
        /// For a full list of operations, please see the documentation for
        /// [aggregate](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
        ///
        /// __Default value:__ `"sum"` for stacked plots. Otherwise, `"mean"`.
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public NonArgAggregateOp? Op { get; set; }

        /// <summary>
        /// The sort order. One of `"ascending"` (default), `"descending"`, or `null` (no not sort).
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Order { get; set; }

        /// <summary>
        /// The [encoding channel](https://vega.github.io/vega-lite/docs/encoding.html#channels) to
        /// sort by (e.g., `"x"`, `"y"`)
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public SortByChannel? Encoding { get; set; }
    }
}