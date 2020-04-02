using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Box Config
    /// </summary>
    public class BoxPlotConfig
    {
        [JsonProperty("box",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Box { get; set; }

        /// <summary>
        /// The extent of the whiskers. Available options include:
        /// - `"min-max"`: min and max are the lower and upper whiskers respectively.
        /// - A number representing multiple of the interquartile range. This number will be
        /// multiplied by the IQR to determine whisker boundary, which spans from the smallest data
        /// to the largest data within the range _[Q1 - k * IQR, Q3 + k * IQR]_ where _Q1_ and _Q3_
        /// are the first and third quartiles while _IQR_ is the interquartile range (_Q3-Q1_).
        ///
        /// __Default value:__ `1.5`.
        /// </summary>
        [JsonProperty("extent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BoxplotExtent? Extent { get; set; }

        [JsonProperty("median",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Median { get; set; }

        [JsonProperty("outliers",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Outliers { get; set; }

        [JsonProperty("rule",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Rule { get; set; }

        /// <summary>
        /// Size of the box and median tick of a box plot
        /// </summary>
        [JsonProperty("size",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        [JsonProperty("ticks",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Ticks { get; set; }
    }
}
