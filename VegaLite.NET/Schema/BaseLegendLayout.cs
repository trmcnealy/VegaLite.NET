using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class BaseLegendLayout
    {
        /// <summary>
        /// The anchor point for legend orient group layout.
        /// </summary>
        [JsonProperty("anchor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public AnchorUnion? Anchor { get; set; }

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
    }
}
