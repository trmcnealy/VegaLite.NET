using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Default properties for [single view
    /// plots](https://vega.github.io/vega-lite/docs/spec.html#single).
    /// </summary>
    public class ViewConfig
    {
        /// <summary>
        /// Whether the view should be clipped.
        /// </summary>
        [JsonProperty("clip",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clip { get; set; }

        /// <summary>
        /// The default height when the plot has a continuous y-field.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("continuousHeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousHeight { get; set; }

        /// <summary>
        /// The default width when the plot has a continuous x-field.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("continuousWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousWidth { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The default height when the plot has either a discrete y-field or no y-field.
        ///
        /// __Default value:__ a step size based on `config.view.step`.
        /// </summary>
        [JsonProperty("discreteHeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DiscreteHeightUnion? DiscreteHeight { get; set; }

        /// <summary>
        /// The default width when the plot has either a discrete x-field or no x-field.
        ///
        /// __Default value:__ a step size based on `config.view.step`.
        /// </summary>
        [JsonProperty("discreteWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DiscreteWidthUnion? DiscreteWidth { get; set; }

        /// <summary>
        /// The fill color.
        ///
        /// __Default value:__ `undefined`
        /// </summary>
        [JsonProperty("fill",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Fill { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// Default height
        /// </summary>
        [JsonProperty("height",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Default step size for x-/y- discrete fields.
        /// </summary>
        [JsonProperty("step",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// The stroke color.
        ///
        /// __Default value:__ `"#ddd"`
        /// </summary>
        [JsonProperty("stroke",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Stroke { get; set; }

        /// <summary>
        /// The stroke cap for line ending style. One of `"butt"`, `"round"`, or `"square"`.
        ///
        /// __Default value:__ `"square"`
        /// </summary>
        [JsonProperty("strokeCap",
                      NullValueHandling = NullValueHandling.Ignore)]
        public StrokeCap? StrokeCap { get; set; }

        /// <summary>
        /// An array of alternating stroke, space lengths for creating dashed or dotted lines.
        /// </summary>
        [JsonProperty("strokeDash",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StrokeDash { get; set; }

        /// <summary>
        /// The offset (in pixels) into which to begin drawing with the stroke dash array.
        /// </summary>
        [JsonProperty("strokeDashOffset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeDashOffset { get; set; }

        /// <summary>
        /// The stroke line join method. One of `"miter"`, `"round"` or `"bevel"`.
        ///
        /// __Default value:__ `"miter"`
        /// </summary>
        [JsonProperty("strokeJoin",
                      NullValueHandling = NullValueHandling.Ignore)]
        public StrokeJoin? StrokeJoin { get; set; }

        /// <summary>
        /// The miter limit at which to bevel a line join.
        /// </summary>
        [JsonProperty("strokeMiterLimit",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeMiterLimit { get; set; }

        /// <summary>
        /// The stroke opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("strokeOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeOpacity { get; set; }

        /// <summary>
        /// The stroke width, in pixels.
        /// </summary>
        [JsonProperty("strokeWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeWidth { get; set; }

        /// <summary>
        /// Default width
        /// </summary>
        [JsonProperty("width",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }
    }
}
