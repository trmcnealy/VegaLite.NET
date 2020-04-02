using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Line-Specific Config
    ///
    /// Trail-Specific Config
    /// </summary>
    public class LineConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Default color.
        ///
        /// __Default value:__ <span style="color: #4682b4;">&#9632;</span> `"#4682b4"`
        ///
        /// __Note:__
        /// - This property cannot be used in a [style
        /// config](https://vega.github.io/vega-lite/docs/mark.html#style-config).
        /// - The `fill` and `stroke` properties have higher precedence than `color` and will
        /// override `color`.
        /// </summary>
        [JsonProperty("color",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Fill { get; set; }

        /// <summary>
        /// Whether the mark's color should be used as fill color instead of stroke color.
        ///
        /// __Default value:__ `false` for all `point`, `line`, and `rule` marks as well as
        /// `geoshape` marks for
        /// [`graticule`](https://vega.github.io/vega-lite/docs/data.html#graticule) data sources;
        /// otherwise, `true`.
        ///
        /// __Note:__ This property cannot be used in a [style
        /// config](https://vega.github.io/vega-lite/docs/mark.html#style-config).
        /// </summary>
        [JsonProperty("filled",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        /// <summary>
        /// The line interpolation method to use for line and area marks. One of the following:
        /// - `"linear"`: piecewise linear segments, as in a polyline.
        /// - `"linear-closed"`: close the linear segments to form a polygon.
        /// - `"step"`: alternate between horizontal and vertical segments, as in a step function.
        /// - `"step-before"`: alternate between vertical and horizontal segments, as in a step
        /// function.
        /// - `"step-after"`: alternate between horizontal and vertical segments, as in a step
        /// function.
        /// - `"basis"`: a B-spline, with control point duplication on the ends.
        /// - `"basis-open"`: an open B-spline; may not intersect the start or end.
        /// - `"basis-closed"`: a closed B-spline, as in a loop.
        /// - `"cardinal"`: a Cardinal spline, with control point duplication on the ends.
        /// - `"cardinal-open"`: an open Cardinal spline; may not intersect the start or end, but
        /// will intersect other control points.
        /// - `"cardinal-closed"`: a closed Cardinal spline, as in a loop.
        /// - `"bundle"`: equivalent to basis, except the tension parameter is used to straighten the
        /// spline.
        /// - `"monotone"`: cubic interpolation that preserves monotonicity in y.
        /// </summary>
        [JsonProperty("interpolate",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

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
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order { get; set; }

        /// <summary>
        /// The orientation of a non-stacked bar, tick, area, and line charts.
        /// The value is either horizontal (default) or vertical.
        /// - For bar, rule and tick, this determines whether the size of the bar and tick
        /// should be applied to x or y dimension.
        /// - For area, this property determines the orient property of the Vega output.
        /// - For line and trail marks, this property determines the sort order of the points in the
        /// line
        /// if `config.sortLineBy` is not specified.
        /// For stacked charts, this is always determined by the orientation of the stack;
        /// therefore explicitly specified value will be ignored.
        /// </summary>
        [JsonProperty("orient",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        /// <summary>
        /// A flag for overlaying points on top of line or area marks, or an object defining the
        /// properties of the overlayed points.
        ///
        /// - If this property is `"transparent"`, transparent points will be used (for enhancing
        /// tooltips and selections).
        ///
        /// - If this property is an empty object (`{}`) or `true`, filled points with default
        /// properties will be used.
        ///
        /// - If this property is `false`, no points would be automatically added to line or area
        /// marks.
        ///
        /// __Default value:__ `false`.
        /// </summary>
        [JsonProperty("point",
                      NullValueHandling = NullValueHandling.Ignore)]
        public PointUnion? Point { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Radius { get; set; }

        /// <summary>
        /// Shape of the point marks. Supported values include:
        /// - plotting shapes: `"circle"`, `"square"`, `"cross"`, `"diamond"`, `"triangle-up"`,
        /// `"triangle-down"`, `"triangle-right"`, or `"triangle-left"`.
        /// - the line symbol `"stroke"`
        /// - centered directional shapes `"arrow"`, `"wedge"`, or `"triangle"`
        /// - a custom [SVG path
        /// string](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial/Paths) (For correct
        /// sizing, custom shape paths should be defined within a square bounding box with
        /// coordinates ranging from -1 to 1 along both the x and y dimensions.)
        ///
        /// __Default value:__ `"circle"`
        /// </summary>
        [JsonProperty("shape",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }

        /// <summary>
        /// Default size for marks.
        /// - For `point`/`circle`/`square`, this represents the pixel area of the marks. For
        /// example: in the case of circles, the radius is determined in part by the square root of
        /// the size value.
        /// - For `bar`, this represents the band size of the bar, in pixels.
        /// - For `text`, this represents the font size, in pixels.
        ///
        /// __Default value:__
        /// - `30` for point, circle, square marks; width/height's `step`
        /// - `2` for bar marks with discrete dimensions;
        /// - `5` for bar marks with continuous dimensions;
        /// - `11` for text marks.
        /// </summary>
        [JsonProperty("size",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBandPosition { get; set; }

        /// <summary>
        /// The tooltip text string to show upon mouse hover or an object defining which fields
        /// should the tooltip be derived from.
        ///
        /// - If `tooltip` is `true` or `{"content": "encoding"}`, then all fields from `encoding`
        /// will be used.
        /// - If `tooltip` is `{"content": "data"}`, then all fields that appear in the highlighted
        /// data point will be used.
        /// - If set to `null` or `false`, then no tooltip will be used.
        ///
        /// See the [`tooltip`](https://vega.github.io/vega-lite/docs/tooltip.html) documentation for
        /// a detailed discussion about tooltip  in Vega-Lite.
        ///
        /// __Default value:__ `null`
        /// </summary>
        [JsonProperty("tooltip",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x",
                      NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y",
                      NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }
}
