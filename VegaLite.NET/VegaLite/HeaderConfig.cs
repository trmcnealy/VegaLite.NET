using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Header configuration, which determines default properties for all
    /// [headers](https://vega.github.io/vega-lite/docs/header.html).
    ///
    /// For a full list of header configuration options, please see the [corresponding section of
    /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
    ///
    /// Header configuration, which determines default properties for column
    /// [headers](https://vega.github.io/vega-lite/docs/header.html).
    ///
    /// For a full list of header configuration options, please see the [corresponding section of
    /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
    ///
    /// Header configuration, which determines default properties for non-row/column facet
    /// [headers](https://vega.github.io/vega-lite/docs/header.html).
    ///
    /// For a full list of header configuration options, please see the [corresponding section of
    /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
    ///
    /// Header configuration, which determines default properties for row
    /// [headers](https://vega.github.io/vega-lite/docs/header.html).
    ///
    /// For a full list of header configuration options, please see the [corresponding section of
    /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
    /// </summary>
    public class HeaderConfig
    {
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
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// The format type for labels (`"number"` or `"time"`).
        ///
        /// __Default value:__
        /// - `"time"` for temporal fields and ordinal and nomimal fields with `timeUnit`.
        /// - `"number"` for quantitative fields as well as ordinal and nomimal fields without
        /// `timeUnit`.
        /// </summary>
        [JsonProperty("formatType", NullValueHandling = NullValueHandling.Ignore)]
        public FormatType? FormatType { get; set; }

        /// <summary>
        /// Horizontal text alignment of header labels. One of `"left"`, `"center"`, or `"right"`.
        /// </summary>
        [JsonProperty("labelAlign", NullValueHandling = NullValueHandling.Ignore)]
        public Align? LabelAlign { get; set; }

        /// <summary>
        /// The anchor position for placing the labels. One of `"start"`, `"middle"`, or `"end"`. For
        /// example, with a label orientation of top these anchor positions map to a left-, center-,
        /// or right-aligned label.
        /// </summary>
        [JsonProperty("labelAnchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? LabelAnchor { get; set; }

        /// <summary>
        /// The rotation angle of the header labels.
        ///
        /// __Default value:__ `0` for column header, `-90` for row header.
        /// </summary>
        [JsonProperty("labelAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelAngle { get; set; }

        /// <summary>
        /// The color of the header label, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("labelColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelColor { get; set; }

        /// <summary>
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the header's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

        /// <summary>
        /// The font of the header label.
        /// </summary>
        [JsonProperty("labelFont", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelFont { get; set; }

        /// <summary>
        /// The font size of the header label, in pixels.
        /// </summary>
        [JsonProperty("labelFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelFontSize { get; set; }

        /// <summary>
        /// The font style of the header label.
        /// </summary>
        [JsonProperty("labelFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelFontStyle { get; set; }

        /// <summary>
        /// The maximum length of the header label in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("labelLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelLimit { get; set; }

        /// <summary>
        /// The orientation of the header label. One of `"top"`, `"bottom"`, `"left"` or `"right"`.
        /// </summary>
        [JsonProperty("labelOrient", NullValueHandling = NullValueHandling.Ignore)]
        public Orient? LabelOrient { get; set; }

        /// <summary>
        /// The padding, in pixel, between facet header's label and the plot.
        ///
        /// __Default value:__ `10`
        /// </summary>
        [JsonProperty("labelPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelPadding { get; set; }

        /// <summary>
        /// A boolean flag indicating if labels should be included as part of the header.
        ///
        /// __Default value:__ `true`.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Labels { get; set; }

        /// <summary>
        /// Set to null to disable title for the axis, legend, or header.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public object Title { get; set; }

        /// <summary>
        /// Horizontal text alignment (to the anchor) of header titles.
        /// </summary>
        [JsonProperty("titleAlign", NullValueHandling = NullValueHandling.Ignore)]
        public Align? TitleAlign { get; set; }

        /// <summary>
        /// The anchor position for placing the title. One of `"start"`, `"middle"`, or `"end"`. For
        /// example, with an orientation of top these anchor positions map to a left-, center-, or
        /// right-aligned title.
        /// </summary>
        [JsonProperty("titleAnchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? TitleAnchor { get; set; }

        /// <summary>
        /// The rotation angle of the header title.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("titleAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleAngle { get; set; }

        /// <summary>
        /// Vertical text baseline for the header title. One of `"top"`, `"bottom"`, `"middle"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("titleBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? TitleBaseline { get; set; }

        /// <summary>
        /// Color of the header title, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("titleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleColor { get; set; }

        /// <summary>
        /// Font of the header title. (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("titleFont", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFont { get; set; }

        /// <summary>
        /// Font size of the header title.
        /// </summary>
        [JsonProperty("titleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// The font style of the header title.
        /// </summary>
        [JsonProperty("titleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Font weight of the header title.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("titleFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? TitleFontWeight { get; set; }

        /// <summary>
        /// The maximum length of the header title in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("titleLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLimit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("titleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLineHeight { get; set; }

        /// <summary>
        /// The orientation of the header title. One of `"top"`, `"bottom"`, `"left"` or `"right"`.
        /// </summary>
        [JsonProperty("titleOrient", NullValueHandling = NullValueHandling.Ignore)]
        public Orient? TitleOrient { get; set; }

        /// <summary>
        /// The padding, in pixel, between facet header's title and the label.
        ///
        /// __Default value:__ `10`
        /// </summary>
        [JsonProperty("titlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitlePadding { get; set; }
    }
}