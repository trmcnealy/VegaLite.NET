using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// An object defining the view background's fill and stroke.
    ///
    /// __Default value:__ none (transparent)
    /// </summary>
    public class ViewBackground
    {
        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The fill color.
        ///
        /// __Default value:__ `undefined`
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public string Fill { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// The stroke color.
        ///
        /// __Default value:__ `"#ddd"`
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public string Stroke { get; set; }

        /// <summary>
        /// The stroke cap for line ending style. One of `"butt"`, `"round"`, or `"square"`.
        ///
        /// __Default value:__ `"square"`
        /// </summary>
        [JsonProperty("strokeCap", NullValueHandling = NullValueHandling.Ignore)]
        public StrokeCap? StrokeCap { get; set; }

        /// <summary>
        /// An array of alternating stroke, space lengths for creating dashed or dotted lines.
        /// </summary>
        [JsonProperty("strokeDash", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StrokeDash { get; set; }

        /// <summary>
        /// The offset (in pixels) into which to begin drawing with the stroke dash array.
        /// </summary>
        [JsonProperty("strokeDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeDashOffset { get; set; }

        /// <summary>
        /// The stroke line join method. One of `"miter"`, `"round"` or `"bevel"`.
        ///
        /// __Default value:__ `"miter"`
        /// </summary>
        [JsonProperty("strokeJoin", NullValueHandling = NullValueHandling.Ignore)]
        public StrokeJoin? StrokeJoin { get; set; }

        /// <summary>
        /// The miter limit at which to bevel a line join.
        /// </summary>
        [JsonProperty("strokeMiterLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeMiterLimit { get; set; }

        /// <summary>
        /// The stroke opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeOpacity { get; set; }

        /// <summary>
        /// The stroke width, in pixels.
        /// </summary>
        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeWidth { get; set; }

        /// <summary>
        /// A string or array of strings indicating the name of custom styles to apply to the view
        /// background. A style is a named collection of mark property defaults defined within the
        /// [style configuration](https://vega.github.io/vega-lite/docs/mark.html#style-config). If
        /// style is an array, later styles will override earlier styles.
        ///
        /// __Default value:__ `"cell"`
        /// __Note:__ Any specified view background properties will augment the default style.
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Style { get; set; }
    }
}