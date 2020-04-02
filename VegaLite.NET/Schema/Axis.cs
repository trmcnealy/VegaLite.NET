using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class Axis
    {
        /// <summary>
        /// An interpolation fraction indicating where, for `band` scales, axis ticks should be
        /// positioned. A value of `0` places ticks at the left edge of their bands. A value of `0.5`
        /// places ticks in the middle of their bands.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("bandPosition",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPosition { get; set; }

        /// <summary>
        /// A boolean flag indicating if the domain (the axis baseline) should be included as part of
        /// the axis.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("domain",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domain { get; set; }

        /// <summary>
        /// Color of axis domain line.
        ///
        /// __Default value:__ `"gray"`.
        /// </summary>
        [JsonProperty("domainColor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string DomainColor { get; set; }

        /// <summary>
        /// An array of alternating [stroke, space] lengths for dashed domain lines.
        /// </summary>
        [JsonProperty("domainDash",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DomainDash { get; set; }

        /// <summary>
        /// The pixel offset at which to start drawing with the domain dash array.
        /// </summary>
        [JsonProperty("domainDashOffset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainDashOffset { get; set; }

        /// <summary>
        /// Opacity of the axis domain line.
        /// </summary>
        [JsonProperty("domainOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainOpacity { get; set; }

        /// <summary>
        /// Stroke width of axis domain line
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("domainWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainWidth { get; set; }

        /// <summary>
        /// The text formatting pattern for labels of guides (axes, legends, headers) and text
        /// marks.
        ///
        /// - If the format type is `"number"` (e.g., for quantitative fields), this is D3's [number
        /// format pattern](https://github.com/d3/d3-format#locale_format).
        /// - If the format type is `"time"` (e.g., for temporal fields), this is D3's [time format
        /// pattern](https://github.com/d3/d3-time-format#locale_format).
        ///
        /// See the [format documentation](https://vega.github.io/vega-lite/docs/format.html) for
        /// more examples.
        ///
        /// __Default value:__  Derived from
        /// [numberFormat](https://vega.github.io/vega-lite/docs/config.html#format) config for
        /// number format and from
        /// [timeFormat](https://vega.github.io/vega-lite/docs/config.html#format) config for time
        /// format.
        /// </summary>
        [JsonProperty("format",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// The format type for labels (`"number"` or `"time"`).
        ///
        /// __Default value:__
        /// - `"time"` for temporal fields and ordinal and nomimal fields with `timeUnit`.
        /// - `"number"` for quantitative fields as well as ordinal and nomimal fields without
        /// `timeUnit`.
        /// </summary>
        [JsonProperty("formatType",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FormatType? FormatType { get; set; }

        /// <summary>
        /// A boolean flag indicating if grid lines should be included as part of the axis
        ///
        /// __Default value:__ `true` for [continuous
        /// scales](https://vega.github.io/vega-lite/docs/scale.html#continuous) that are not binned;
        /// otherwise, `false`.
        /// </summary>
        [JsonProperty("grid",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Grid { get; set; }

        [JsonProperty("gridColor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Color? GridColor { get; set; }

        [JsonProperty("gridDash",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Dash? GridDash { get; set; }

        [JsonProperty("gridDashOffset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? GridDashOffset { get; set; }

        [JsonProperty("gridOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridOpacity? GridOpacity { get; set; }

        [JsonProperty("gridWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? GridWidth { get; set; }

        [JsonProperty("labelAlign",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlign? LabelAlign { get; set; }

        /// <summary>
        /// The rotation angle of the axis labels.
        ///
        /// __Default value:__ `-90` for nominal and ordinal fields; `0` otherwise.
        /// </summary>
        [JsonProperty("labelAngle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelAngle { get; set; }

        [JsonProperty("labelBaseline",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TextBaseline? LabelBaseline { get; set; }

        /// <summary>
        /// Indicates if labels should be hidden if they exceed the axis range. If `false` (the
        /// default) no bounds overlap analysis is performed. If `true`, labels will be hidden if
        /// they exceed the axis range by more than 1 pixel. If this property is a number, it
        /// specifies the pixel tolerance: the maximum amount by which a label bounding box may
        /// exceed the axis range.
        ///
        /// __Default value:__ `false`.
        /// </summary>
        [JsonProperty("labelBound",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Label? LabelBound { get; set; }

        [JsonProperty("labelColor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Color? LabelColor { get; set; }

        /// <summary>
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

        /// <summary>
        /// Indicates if the first and last axis labels should be aligned flush with the scale range.
        /// Flush alignment for a horizontal axis will left-align the first label and right-align the
        /// last label. For vertical axes, bottom and top text baselines are applied instead. If this
        /// property is a number, it also indicates the number of pixels by which to offset the first
        /// and last labels; for example, a value of 2 will flush-align the first and last labels and
        /// also push them 2 pixels outward from the center of the axis. The additional adjustment
        /// can sometimes help the labels better visually group with corresponding axis ticks.
        ///
        /// __Default value:__ `true` for axis of a continuous x-scale. Otherwise, `false`.
        /// </summary>
        [JsonProperty("labelFlush",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Label? LabelFlush { get; set; }

        /// <summary>
        /// Indicates the number of pixels by which to offset flush-adjusted labels. For example, a
        /// value of `2` will push flush-adjusted labels 2 pixels outward from the center of the
        /// axis. Offsets can help the labels better visually group with corresponding axis ticks.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("labelFlushOffset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelFlushOffset { get; set; }

        [JsonProperty("labelFont",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? LabelFont { get; set; }

        [JsonProperty("labelFontSize",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? LabelFontSize { get; set; }

        [JsonProperty("labelFontStyle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LabelFontStyle? LabelFontStyle { get; set; }

        [JsonProperty("labelFontWeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LabelFontWeightUnion? LabelFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of axis tick labels.
        ///
        /// __Default value:__ `180`
        /// </summary>
        [JsonProperty("labelLimit",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelLimit { get; set; }

        [JsonProperty("labelOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? LabelOpacity { get; set; }

        /// <summary>
        /// The strategy to use for resolving overlap of axis labels. If `false` (the default), no
        /// overlap reduction is attempted. If set to `true` or `"parity"`, a strategy of removing
        /// every other label is used (this works well for standard linear axes). If set to
        /// `"greedy"`, a linear scan of the labels is performed, removing any labels that overlaps
        /// with the last visible label (this often works better for log-scaled axes).
        ///
        /// __Default value:__ `true` for non-nominal fields with non-log scales; `"greedy"` for log
        /// scales; otherwise `false`.
        /// </summary>
        [JsonProperty("labelOverlap",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlap? LabelOverlap { get; set; }

        /// <summary>
        /// The padding, in pixels, between axis and text labels.
        ///
        /// __Default value:__ `2`
        /// </summary>
        [JsonProperty("labelPadding",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelPadding { get; set; }

        /// <summary>
        /// A boolean flag indicating if labels should be included as part of the axis.
        ///
        /// __Default value:__ `true`.
        /// </summary>
        [JsonProperty("labels",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Labels { get; set; }

        /// <summary>
        /// The minimum separation that must be between label bounding boxes for them to be
        /// considered non-overlapping (default `0`). This property is ignored if *labelOverlap*
        /// resolution is not enabled.
        /// </summary>
        [JsonProperty("labelSeparation",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelSeparation { get; set; }

        /// <summary>
        /// The maximum extent in pixels that axis ticks and labels should use. This determines a
        /// maximum offset value for axis titles.
        ///
        /// __Default value:__ `undefined`.
        /// </summary>
        [JsonProperty("maxExtent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxExtent { get; set; }

        /// <summary>
        /// The minimum extent in pixels that axis ticks and labels should use. This determines a
        /// minimum offset value for axis titles.
        ///
        /// __Default value:__ `30` for y-axis; `undefined` for x-axis.
        /// </summary>
        [JsonProperty("minExtent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? MinExtent { get; set; }

        /// <summary>
        /// The offset, in pixels, by which to displace the axis from the edge of the enclosing group
        /// or data rectangle.
        ///
        /// __Default value:__ derived from the [axis
        /// config](https://vega.github.io/vega-lite/docs/config.html#facet-scale-config)'s `offset`
        /// (`0` by default)
        /// </summary>
        [JsonProperty("offset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        /// <summary>
        /// The orientation of the axis. One of `"top"`, `"bottom"`, `"left"` or `"right"`. The
        /// orientation can be used to further specialize the axis type (e.g., a y-axis oriented
        /// towards the right edge of the chart).
        ///
        /// __Default value:__ `"bottom"` for x-axes and `"left"` for y-axes.
        /// </summary>
        [JsonProperty("orient",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Orient? Orient { get; set; }

        /// <summary>
        /// The anchor position of the axis in pixels. For x-axes with top or bottom orientation,
        /// this sets the axis group x coordinate. For y-axes with left or right orientation, this
        /// sets the axis group y coordinate.
        ///
        /// __Default value__: `0`
        /// </summary>
        [JsonProperty("position",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Position { get; set; }

        /// <summary>
        /// For band scales, indicates if ticks and grid lines should be placed at the center of a
        /// band (default) or at the band extents to indicate intervals.
        /// </summary>
        [JsonProperty("tickBand",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TickBand? TickBand { get; set; }

        [JsonProperty("tickColor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Color? TickColor { get; set; }

        /// <summary>
        /// A desired number of ticks, for axes visualizing quantitative scales. The resulting number
        /// may be different so that values are "nice" (multiples of 2, 5, 10) and lie within the
        /// underlying scale's range.
        ///
        /// __Default value__: Determine using a formula `ceil(width/40)` for x and `ceil(height/40)`
        /// for y.
        /// </summary>
        [JsonProperty("tickCount",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TickCount { get; set; }

        [JsonProperty("tickDash",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Dash? TickDash { get; set; }

        [JsonProperty("tickDashOffset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? TickDashOffset { get; set; }

        /// <summary>
        /// Boolean flag indicating if an extra axis tick should be added for the initial position of
        /// the axis. This flag is useful for styling axes for `band` scales such that ticks are
        /// placed on band boundaries rather in the middle of a band. Use in conjunction with
        /// `"bandPosition": 1` and an axis `"padding"` value of `0`.
        /// </summary>
        [JsonProperty("tickExtra",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? TickExtra { get; set; }

        /// <summary>
        /// The minimum desired step between axis ticks, in terms of scale domain values. For
        /// example, a value of `1` indicates that ticks should not be less than 1 unit apart. If
        /// `tickMinStep` is specified, the `tickCount` value will be adjusted, if necessary, to
        /// enforce the minimum step value.
        ///
        /// __Default value__: `undefined`
        /// </summary>
        [JsonProperty("tickMinStep",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TickMinStep { get; set; }

        /// <summary>
        /// Position offset in pixels to apply to ticks, labels, and gridlines.
        /// </summary>
        [JsonProperty("tickOffset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TickOffset { get; set; }

        [JsonProperty("tickOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? TickOpacity { get; set; }

        /// <summary>
        /// Boolean flag indicating if pixel position values should be rounded to the nearest
        /// integer.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("tickRound",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? TickRound { get; set; }

        /// <summary>
        /// Boolean value that determines whether the axis should include ticks.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("ticks",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticks { get; set; }

        /// <summary>
        /// The size in pixels of axis ticks.
        ///
        /// __Default value:__ `5`
        /// </summary>
        [JsonProperty("tickSize",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TickSize { get; set; }

        [JsonProperty("tickWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? TickWidth { get; set; }

        /// <summary>
        /// A title for the field. If `null`, the title will be removed.
        ///
        /// __Default value:__  derived from the field's name and transformation function
        /// (`aggregate`, `bin` and `timeUnit`). If the field has an aggregate function, the function
        /// is displayed as part of the title (e.g., `"Sum of Profit"`). If the field is binned or
        /// has a time unit applied, the applied function is shown in parentheses (e.g., `"Profit
        /// (binned)"`, `"Transaction Date (year-month)"`). Otherwise, the title is simply the field
        /// name.
        ///
        /// __Notes__:
        ///
        /// 1) You can customize the default field title format by providing the
        /// [`fieldTitle`](https://vega.github.io/vega-lite/docs/config.html#top-level-config)
        /// property in the [config](https://vega.github.io/vega-lite/docs/config.html) or
        /// [`fieldTitle` function via the `compile` function's
        /// options](https://vega.github.io/vega-lite/docs/compile.html#field-title).
        ///
        /// 2) If both field definition's `title` and axis, header, or legend `title` are defined,
        /// axis/header/legend title will be used.
        /// </summary>
        [JsonProperty("title",
                      NullValueHandling = NullValueHandling.Ignore)]
        public PurpleText? Title { get; set; }

        /// <summary>
        /// Horizontal text alignment of axis titles.
        /// </summary>
        [JsonProperty("titleAlign",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Align? TitleAlign { get; set; }

        /// <summary>
        /// Text anchor position for placing axis titles.
        /// </summary>
        [JsonProperty("titleAnchor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? TitleAnchor { get; set; }

        /// <summary>
        /// Angle in degrees of axis titles.
        /// </summary>
        [JsonProperty("titleAngle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleAngle { get; set; }

        /// <summary>
        /// Vertical text baseline for axis titles.
        /// </summary>
        [JsonProperty("titleBaseline",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? TitleBaseline { get; set; }

        /// <summary>
        /// Color of the title, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("titleColor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string TitleColor { get; set; }

        /// <summary>
        /// Font of the title. (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("titleFont",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFont { get; set; }

        /// <summary>
        /// Font size of the title.
        /// </summary>
        [JsonProperty("titleFontSize",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// Font style of the title.
        /// </summary>
        [JsonProperty("titleFontStyle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Font weight of the title.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("titleFontWeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? TitleFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of axis titles.
        /// </summary>
        [JsonProperty("titleLimit",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLimit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("titleLineHeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLineHeight { get; set; }

        /// <summary>
        /// Opacity of the axis title.
        /// </summary>
        [JsonProperty("titleOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleOpacity { get; set; }

        /// <summary>
        /// The padding, in pixels, between title and axis.
        /// </summary>
        [JsonProperty("titlePadding",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitlePadding { get; set; }

        /// <summary>
        /// X-coordinate of the axis title relative to the axis group.
        /// </summary>
        [JsonProperty("titleX",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleX { get; set; }

        /// <summary>
        /// Y-coordinate of the axis title relative to the axis group.
        /// </summary>
        [JsonProperty("titleY",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleY { get; set; }

        /// <summary>
        /// Translation offset in pixels applied to the axis group mark x and y. If specified,
        /// overrides the default behavior of a 0.5 offset to pixel-align stroked lines.
        /// </summary>
        [JsonProperty("translate",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Translate { get; set; }

        /// <summary>
        /// Explicitly set the visible axis tick values.
        /// </summary>
        [JsonProperty("values",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<Equal> Values { get; set; }

        /// <summary>
        /// A non-negative integer indicating the z-index of the axis.
        /// If zindex is 0, axes should be drawn behind all chart elements.
        /// To put them in front, set `zindex` to `1` or more.
        ///
        /// __Default value:__ `0` (behind the marks).
        /// </summary>
        [JsonProperty("zindex",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }
}
