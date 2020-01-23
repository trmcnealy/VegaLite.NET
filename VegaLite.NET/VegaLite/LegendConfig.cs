using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Legend configuration, which determines default properties for all
    /// [legends](https://vega.github.io/vega-lite/docs/legend.html). For a full list of legend
    /// configuration options, please see the [corresponding section of in the legend
    /// documentation](https://vega.github.io/vega-lite/docs/legend.html#config).
    /// </summary>
    public class LegendConfig
    {
        /// <summary>
        /// The height in pixels to clip symbol legend entries and limit their size.
        /// </summary>
        [JsonProperty("clipHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ClipHeight { get; set; }

        /// <summary>
        /// The horizontal padding in pixels between symbol legend entries.
        ///
        /// __Default value:__ `10`.
        /// </summary>
        [JsonProperty("columnPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? ColumnPadding { get; set; }

        /// <summary>
        /// The number of columns in which to arrange symbol legend entries. A value of `0` or lower
        /// indicates a single row with one column per entry.
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public double? Columns { get; set; }

        /// <summary>
        /// Corner radius for the full legend.
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// Background fill color for the full legend.
        /// </summary>
        [JsonProperty("fillColor", NullValueHandling = NullValueHandling.Ignore)]
        public string FillColor { get; set; }

        /// <summary>
        /// The default direction (`"horizontal"` or `"vertical"`) for gradient legends.
        ///
        /// __Default value:__ `"vertical"`.
        /// </summary>
        [JsonProperty("gradientDirection", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? GradientDirection { get; set; }

        /// <summary>
        /// Max legend length for a horizontal gradient when `config.legend.gradientLength` is
        /// undefined.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("gradientHorizontalMaxLength", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientHorizontalMaxLength { get; set; }

        /// <summary>
        /// Min legend length for a horizontal gradient when `config.legend.gradientLength` is
        /// undefined.
        ///
        /// __Default value:__ `100`
        /// </summary>
        [JsonProperty("gradientHorizontalMinLength", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientHorizontalMinLength { get; set; }

        /// <summary>
        /// The maximum allowed length in pixels of color ramp gradient labels.
        /// </summary>
        [JsonProperty("gradientLabelLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientLabelLimit { get; set; }

        /// <summary>
        /// Vertical offset in pixels for color ramp gradient labels.
        ///
        /// __Default value:__ `2`.
        /// </summary>
        [JsonProperty("gradientLabelOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientLabelOffset { get; set; }

        /// <summary>
        /// The length in pixels of the primary axis of a color gradient. This value corresponds to
        /// the height of a vertical gradient or the width of a horizontal gradient.
        ///
        /// __Default value:__ `200`.
        /// </summary>
        [JsonProperty("gradientLength", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientLength { get; set; }

        /// <summary>
        /// Opacity of the color gradient.
        /// </summary>
        [JsonProperty("gradientOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientOpacity { get; set; }

        /// <summary>
        /// The color of the gradient stroke, can be in hex color code or regular color name.
        ///
        /// __Default value:__ `"lightGray"`.
        /// </summary>
        [JsonProperty("gradientStrokeColor", NullValueHandling = NullValueHandling.Ignore)]
        public string GradientStrokeColor { get; set; }

        /// <summary>
        /// The width of the gradient stroke, in pixels.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("gradientStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientStrokeWidth { get; set; }

        /// <summary>
        /// The thickness in pixels of the color gradient. This value corresponds to the width of a
        /// vertical gradient or the height of a horizontal gradient.
        ///
        /// __Default value:__ `16`.
        /// </summary>
        [JsonProperty("gradientThickness", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientThickness { get; set; }

        /// <summary>
        /// Max legend length for a vertical gradient when `config.legend.gradientLength` is
        /// undefined.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("gradientVerticalMaxLength", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientVerticalMaxLength { get; set; }

        /// <summary>
        /// Min legend length for a vertical gradient when `config.legend.gradientLength` is
        /// undefined.
        ///
        /// __Default value:__ `100`
        /// </summary>
        [JsonProperty("gradientVerticalMinLength", NullValueHandling = NullValueHandling.Ignore)]
        public double? GradientVerticalMinLength { get; set; }

        /// <summary>
        /// The alignment to apply to symbol legends rows and columns. The supported string values
        /// are `"all"`, `"each"` (the default), and `none`. For more information, see the [grid
        /// layout documentation](https://vega.github.io/vega/docs/layout).
        ///
        /// __Default value:__ `"each"`.
        /// </summary>
        [JsonProperty("gridAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutAlign? GridAlign { get; set; }

        /// <summary>
        /// The alignment of the legend label, can be left, center, or right.
        /// </summary>
        [JsonProperty("labelAlign", NullValueHandling = NullValueHandling.Ignore)]
        public Align? LabelAlign { get; set; }

        /// <summary>
        /// The position of the baseline of legend label, can be `"top"`, `"middle"`, `"bottom"`, or
        /// `"alphabetic"`.
        ///
        /// __Default value:__ `"middle"`.
        /// </summary>
        [JsonProperty("labelBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? LabelBaseline { get; set; }

        /// <summary>
        /// The color of the legend label, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("labelColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelColor { get; set; }

        /// <summary>
        /// The font of the legend label.
        /// </summary>
        [JsonProperty("labelFont", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelFont { get; set; }

        /// <summary>
        /// The font size of legend label.
        ///
        /// __Default value:__ `10`.
        /// </summary>
        [JsonProperty("labelFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelFontSize { get; set; }

        /// <summary>
        /// The font style of legend label.
        /// </summary>
        [JsonProperty("labelFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelFontStyle { get; set; }

        /// <summary>
        /// The font weight of legend label.
        /// </summary>
        [JsonProperty("labelFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? LabelFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of legend tick labels.
        ///
        /// __Default value:__ `160`.
        /// </summary>
        [JsonProperty("labelLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelLimit { get; set; }

        /// <summary>
        /// The offset of the legend label.
        /// </summary>
        [JsonProperty("labelOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelOffset { get; set; }

        /// <summary>
        /// Opacity of labels.
        /// </summary>
        [JsonProperty("labelOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelOpacity { get; set; }

        /// <summary>
        /// The strategy to use for resolving overlap of labels in gradient legends. If `false`, no
        /// overlap reduction is attempted. If set to `true` or `"parity"`, a strategy of removing
        /// every other label is used. If set to `"greedy"`, a linear scan of the labels is
        /// performed, removing any label that overlaps with the last visible label (this often works
        /// better for log-scaled axes).
        ///
        /// __Default value:__ `"greedy"` for `log scales otherwise `true`.
        /// </summary>
        [JsonProperty("labelOverlap", NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlap? LabelOverlap { get; set; }

        /// <summary>
        /// Padding in pixels between the legend and legend labels.
        /// </summary>
        [JsonProperty("labelPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelPadding { get; set; }

        /// <summary>
        /// The minimum separation that must be between label bounding boxes for them to be
        /// considered non-overlapping (default `0`). This property is ignored if *labelOverlap*
        /// resolution is not enabled.
        /// </summary>
        [JsonProperty("labelSeparation", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelSeparation { get; set; }

        /// <summary>
        /// Legend orient group layout parameters.
        /// </summary>
        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public LegendLayout Layout { get; set; }

        /// <summary>
        /// Custom x-position for legend with orient "none".
        /// </summary>
        [JsonProperty("legendX", NullValueHandling = NullValueHandling.Ignore)]
        public double? LegendX { get; set; }

        /// <summary>
        /// Custom y-position for legend with orient "none".
        /// </summary>
        [JsonProperty("legendY", NullValueHandling = NullValueHandling.Ignore)]
        public double? LegendY { get; set; }

        /// <summary>
        /// The offset in pixels by which to displace the legend from the data rectangle and axes.
        ///
        /// __Default value:__ `18`.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        /// <summary>
        /// The orientation of the legend, which determines how the legend is positioned within the
        /// scene. One of "left", "right", "top-left", "top-right", "bottom-left", "bottom-right",
        /// "none".
        ///
        /// __Default value:__ `"right"`
        /// </summary>
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public LegendOrient? Orient { get; set; }

        /// <summary>
        /// The padding between the border and content of the legend group.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public double? Padding { get; set; }

        /// <summary>
        /// The vertical padding in pixels between symbol legend entries.
        ///
        /// __Default value:__ `2`.
        /// </summary>
        [JsonProperty("rowPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? RowPadding { get; set; }

        /// <summary>
        /// Border stroke color for the full legend.
        /// </summary>
        [JsonProperty("strokeColor", NullValueHandling = NullValueHandling.Ignore)]
        public string StrokeColor { get; set; }

        /// <summary>
        /// Border stroke dash pattern for the full legend.
        /// </summary>
        [JsonProperty("strokeDash", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StrokeDash { get; set; }

        /// <summary>
        /// Border stroke width for the full legend.
        /// </summary>
        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? StrokeWidth { get; set; }

        /// <summary>
        /// Default fill color for legend symbols. Only applied if there is no `"fill"` scale color
        /// encoding for the legend.
        ///
        /// __Default value:__ `"transparent"`.
        /// </summary>
        [JsonProperty("symbolBaseFillColor", NullValueHandling = NullValueHandling.Ignore)]
        public string SymbolBaseFillColor { get; set; }

        /// <summary>
        /// Default stroke color for legend symbols. Only applied if there is no `"fill"` scale color
        /// encoding for the legend.
        ///
        /// __Default value:__ `"gray"`.
        /// </summary>
        [JsonProperty("symbolBaseStrokeColor", NullValueHandling = NullValueHandling.Ignore)]
        public string SymbolBaseStrokeColor { get; set; }

        /// <summary>
        /// An array of alternating [stroke, space] lengths for dashed symbol strokes.
        /// </summary>
        [JsonProperty("symbolDash", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> SymbolDash { get; set; }

        /// <summary>
        /// The pixel offset at which to start drawing with the symbol stroke dash array.
        /// </summary>
        [JsonProperty("symbolDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? SymbolDashOffset { get; set; }

        /// <summary>
        /// The default direction (`"horizontal"` or `"vertical"`) for symbol legends.
        ///
        /// __Default value:__ `"vertical"`.
        /// </summary>
        [JsonProperty("symbolDirection", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? SymbolDirection { get; set; }

        /// <summary>
        /// The color of the legend symbol,
        /// </summary>
        [JsonProperty("symbolFillColor", NullValueHandling = NullValueHandling.Ignore)]
        public string SymbolFillColor { get; set; }

        /// <summary>
        /// The maximum number of allowed entries for a symbol legend. Additional entries will be
        /// dropped.
        /// </summary>
        [JsonProperty("symbolLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? SymbolLimit { get; set; }

        /// <summary>
        /// Horizontal pixel offset for legend symbols.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("symbolOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? SymbolOffset { get; set; }

        /// <summary>
        /// Opacity of the legend symbols.
        /// </summary>
        [JsonProperty("symbolOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? SymbolOpacity { get; set; }

        /// <summary>
        /// The size of the legend symbol, in pixels.
        ///
        /// __Default value:__ `100`.
        /// </summary>
        [JsonProperty("symbolSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? SymbolSize { get; set; }

        /// <summary>
        /// Stroke color for legend symbols.
        /// </summary>
        [JsonProperty("symbolStrokeColor", NullValueHandling = NullValueHandling.Ignore)]
        public string SymbolStrokeColor { get; set; }

        /// <summary>
        /// The width of the symbol's stroke.
        ///
        /// __Default value:__ `1.5`.
        /// </summary>
        [JsonProperty("symbolStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? SymbolStrokeWidth { get; set; }

        /// <summary>
        /// The symbol shape. One of the plotting shapes `circle` (default), `square`, `cross`,
        /// `diamond`, `triangle-up`, `triangle-down`, `triangle-right`, or `triangle-left`, the line
        /// symbol `stroke`, or one of the centered directional shapes `arrow`, `wedge`, or
        /// `triangle`. Alternatively, a custom [SVG path
        /// string](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial/Paths) can be provided.
        /// For correct sizing, custom shape paths should be defined within a square bounding box
        /// with coordinates ranging from -1 to 1 along both the x and y dimensions.
        ///
        /// __Default value:__ `"circle"`.
        /// </summary>
        [JsonProperty("symbolType", NullValueHandling = NullValueHandling.Ignore)]
        public string SymbolType { get; set; }

        /// <summary>
        /// The desired number of tick values for quantitative legends.
        /// </summary>
        [JsonProperty("tickCount", NullValueHandling = NullValueHandling.Ignore)]
        public TickCount? TickCount { get; set; }

        /// <summary>
        /// Set to null to disable title for the axis, legend, or header.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public object Title { get; set; }

        /// <summary>
        /// Horizontal text alignment for legend titles.
        ///
        /// __Default value:__ `"left"`.
        /// </summary>
        [JsonProperty("titleAlign", NullValueHandling = NullValueHandling.Ignore)]
        public Align? TitleAlign { get; set; }

        /// <summary>
        /// Text anchor position for placing legend titles.
        /// </summary>
        [JsonProperty("titleAnchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? TitleAnchor { get; set; }

        /// <summary>
        /// Vertical text baseline for legend titles.
        ///
        /// __Default value:__ `"top"`.
        /// </summary>
        [JsonProperty("titleBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? TitleBaseline { get; set; }

        /// <summary>
        /// The color of the legend title, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("titleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleColor { get; set; }

        /// <summary>
        /// The font of the legend title.
        /// </summary>
        [JsonProperty("titleFont", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFont { get; set; }

        /// <summary>
        /// The font size of the legend title.
        /// </summary>
        [JsonProperty("titleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// The font style of the legend title.
        /// </summary>
        [JsonProperty("titleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// The font weight of the legend title.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("titleFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? TitleFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of legend titles.
        ///
        /// __Default value:__ `180`.
        /// </summary>
        [JsonProperty("titleLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLimit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("titleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLineHeight { get; set; }

        /// <summary>
        /// Opacity of the legend title.
        /// </summary>
        [JsonProperty("titleOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleOpacity { get; set; }

        /// <summary>
        /// Orientation of the legend title.
        /// </summary>
        [JsonProperty("titleOrient", NullValueHandling = NullValueHandling.Ignore)]
        public Orient? TitleOrient { get; set; }

        /// <summary>
        /// The padding, in pixels, between title and legend.
        ///
        /// __Default value:__ `5`.
        /// </summary>
        [JsonProperty("titlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitlePadding { get; set; }

        /// <summary>
        /// The opacity of unselected legend entries.
        ///
        /// __Default value:__ 0.35.
        /// </summary>
        [JsonProperty("unselectedOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? UnselectedOpacity { get; set; }
    }
}