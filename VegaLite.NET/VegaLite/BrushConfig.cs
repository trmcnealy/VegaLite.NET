using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// An interval selection also adds a rectangle mark to depict the
    /// extents of the interval. The `mark` property can be used to customize the
    /// appearance of the mark.
    ///
    /// __See also:__ [`mark`](https://vega.github.io/vega-lite/docs/selection-mark.html)
    /// documentation.
    /// </summary>
    public class BrushConfig
    {
        /// <summary>
        /// The fill color of the interval mark.
        ///
        /// __Default value:__ `"#333333"`
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public string Fill { get; set; }

        /// <summary>
        /// The fill opacity of the interval mark (a value between 0 and 1).
        ///
        /// __Default value:__ `0.125`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The stroke color of the interval mark.
        ///
        /// __Default value:__ `"#ffffff"`
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public string Stroke { get; set; }

        /// <summary>
        /// An array of alternating stroke and space lengths,
        /// for creating dashed or dotted lines.
        /// </summary>
        [JsonProperty("strokeDash", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StrokeDash { get; set; }

        /// <summary>
        /// The offset (in pixels) with which to begin drawing the stroke dash array.
        /// </summary>
        [JsonProperty("strokeDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeDashOffset { get; set; }

        /// <summary>
        /// The stroke opacity of the interval mark (a value between `0` and `1`).
        /// </summary>
        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeOpacity { get; set; }

        /// <summary>
        /// The stroke width of the interval mark.
        /// </summary>
        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeWidth { get; set; }
    }
}