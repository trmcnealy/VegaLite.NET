using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Legend orient group layout parameters.
    /// </summary>
    public class LegendLayout
    {
        /// <summary>
        /// The anchor point for legend orient group layout.
        /// </summary>
        [JsonProperty("anchor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public AnchorUnion? Anchor { get; set; }

        [JsonProperty("bottom",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Bottom { get; set; }

        [JsonProperty("bottom-left",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout BottomLeft { get; set; }

        [JsonProperty("bottom-right",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout BottomRight { get; set; }

        /// <summary>
        /// The bounds calculation to use for legend orient group layout.
        /// </summary>
        [JsonProperty("bounds",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LayoutBounds? Bounds { get; set; }

        /// <summary>
        /// A flag to center legends within a shared orient group.
        /// </summary>
        [JsonProperty("center",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BottomCenter? Center { get; set; }

        /// <summary>
        /// The layout direction for legend orient group layout.
        /// </summary>
        [JsonProperty("direction",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Direction? Direction { get; set; }

        [JsonProperty("left",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Left { get; set; }

        /// <summary>
        /// The pixel margin between legends within a orient group.
        /// </summary>
        [JsonProperty("margin",
                      NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Margin { get; set; }

        /// <summary>
        /// The pixel offset from the chart body for a legend orient group.
        /// </summary>
        [JsonProperty("offset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Offset { get; set; }

        [JsonProperty("right",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Right { get; set; }

        [JsonProperty("top",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Top { get; set; }

        [JsonProperty("top-left",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout TopLeft { get; set; }

        [JsonProperty("top-right",
                      NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout TopRight { get; set; }
    }
}
