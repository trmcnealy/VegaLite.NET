using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// ErrorBar Config
    /// </summary>
    public class ErrorBarConfig
    {
        /// <summary>
        /// The extent of the rule. Available options include:
        /// - `"ci"`: Extend the rule to the confidence interval of the mean.
        /// - `"stderr"`: The size of rule are set to the value of standard error, extending from the
        /// mean.
        /// - `"stdev"`: The size of rule are set to the value of standard deviation, extending from
        /// the mean.
        /// - `"iqr"`: Extend the rule to the q1 and q3.
        ///
        /// __Default value:__ `"stderr"`.
        /// </summary>
        [JsonProperty("extent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ErrorbandExtent? Extent { get; set; }

        [JsonProperty("rule",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Rule { get; set; }

        [JsonProperty("ticks",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Ticks { get; set; }
    }
}
