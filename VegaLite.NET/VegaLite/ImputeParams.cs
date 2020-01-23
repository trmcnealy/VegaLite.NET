using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    public class ImputeParams
    {
        /// <summary>
        /// A frame specification as a two-element array used to control the window over which the
        /// specified method is applied. The array entries should either be a number indicating the
        /// offset from the current data object, or null to indicate unbounded rows preceding or
        /// following the current data object. For example, the value `[-5, 5]` indicates that the
        /// window should include five objects preceding and five objects following the current
        /// object.
        ///
        /// __Default value:__:  `[null, null]` indicating that the window includes all objects.
        /// </summary>
        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public List<double?> Frame { get; set; }

        /// <summary>
        /// Defines the key values that should be considered for imputation.
        /// An array of key values or an object defining a [number
        /// sequence](https://vega.github.io/vega-lite/docs/impute.html#sequence-def).
        ///
        /// If provided, this will be used in addition to the key values observed within the input
        /// data. If not provided, the values will be derived from all unique values of the `key`
        /// field. For `impute` in `encoding`, the key field is the x-field if the y-field is
        /// imputed, or vice versa.
        ///
        /// If there is no impute grouping, this property _must_ be specified.
        /// </summary>
        [JsonProperty("keyvals", NullValueHandling = NullValueHandling.Ignore)]
        public Keyvals? Keyvals { get; set; }

        /// <summary>
        /// The imputation method to use for the field value of imputed data objects.
        /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
        ///
        /// __Default value:__  `"value"`
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public ImputeParamsMethod? Method { get; set; }

        /// <summary>
        /// The field value to use when the imputation `method` is `"value"`.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; set; }
    }
}