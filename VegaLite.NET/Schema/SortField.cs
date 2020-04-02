using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// A sort definition for transform
    /// </summary>
    public class SortField
    {
        /// <summary>
        /// The name of the field to sort.
        /// </summary>
        [JsonProperty("field",
                      Required = Required.Always)]
        public string Field { get; set; }

        /// <summary>
        /// Whether to sort the field in ascending or descending order. One of `"ascending"`
        /// (default), `"descending"`, or `null` (no not sort).
        /// </summary>
        [JsonProperty("order",
                      NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Order { get; set; }
    }
}
