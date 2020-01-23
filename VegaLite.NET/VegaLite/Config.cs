using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Vega-Lite configuration object. This property can only be defined at the top-level of a
    /// specification.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Area-Specific Config
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public AreaConfig Area { get; set; }

        /// <summary>
        /// How the visualization size should be determined. If a string, should be one of `"pad"`,
        /// `"fit"` or `"none"`.
        /// Object values can additionally specify parameters for content sizing and automatic
        /// resizing.
        ///
        /// __Default value__: `pad`
        /// </summary>
        [JsonProperty("autosize", NullValueHandling = NullValueHandling.Ignore)]
        public Autosize? Autosize { get; set; }

        /// <summary>
        /// Axis configuration, which determines default properties for all `x` and `y`
        /// [axes](https://vega.github.io/vega-lite/docs/axis.html). For a full list of axis
        /// configuration options, please see the [corresponding section of the axis
        /// documentation](https://vega.github.io/vega-lite/docs/axis.html#config).
        /// </summary>
        [JsonProperty("axis", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig Axis { get; set; }

        /// <summary>
        /// Specific axis config for axes with "band" scales.
        /// </summary>
        [JsonProperty("axisBand", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisBand { get; set; }

        /// <summary>
        /// Specific axis config for x-axis along the bottom edge of the chart.
        /// </summary>
        [JsonProperty("axisBottom", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisBottom { get; set; }

        /// <summary>
        /// Specific axis config for y-axis along the left edge of the chart.
        /// </summary>
        [JsonProperty("axisLeft", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisLeft { get; set; }

        /// <summary>
        /// Specific axis config for y-axis along the right edge of the chart.
        /// </summary>
        [JsonProperty("axisRight", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisRight { get; set; }

        /// <summary>
        /// Specific axis config for x-axis along the top edge of the chart.
        /// </summary>
        [JsonProperty("axisTop", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisTop { get; set; }

        /// <summary>
        /// X-axis specific config.
        /// </summary>
        [JsonProperty("axisX", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisX { get; set; }

        /// <summary>
        /// Y-axis specific config.
        /// </summary>
        [JsonProperty("axisY", NullValueHandling = NullValueHandling.Ignore)]
        public AxisConfig AxisY { get; set; }

        /// <summary>
        /// CSS color property to use as the background of the entire view.
        ///
        /// __Default value:__ `"white"`
        /// </summary>
        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }

        /// <summary>
        /// Bar-Specific Config
        /// </summary>
        [JsonProperty("bar", NullValueHandling = NullValueHandling.Ignore)]
        public RectConfig Bar { get; set; }

        /// <summary>
        /// Box Config
        /// </summary>
        [JsonProperty("boxplot", NullValueHandling = NullValueHandling.Ignore)]
        public BoxPlotConfig Boxplot { get; set; }

        /// <summary>
        /// Circle-Specific Config
        /// </summary>
        [JsonProperty("circle", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Circle { get; set; }

        /// <summary>
        /// Default configuration for all concatenation view composition operators (`concat`,
        /// `hconcat`, and `vconcat`)
        /// </summary>
        [JsonProperty("concat", NullValueHandling = NullValueHandling.Ignore)]
        public CompositionConfig Concat { get; set; }

        /// <summary>
        /// Default axis and legend title for count fields.
        ///
        /// __Default value:__ `'Count of Records`.
        /// </summary>
        [JsonProperty("countTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string CountTitle { get; set; }

        /// <summary>
        /// ErrorBand Config
        /// </summary>
        [JsonProperty("errorband", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorBandConfig Errorband { get; set; }

        /// <summary>
        /// ErrorBar Config
        /// </summary>
        [JsonProperty("errorbar", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorBarConfig Errorbar { get; set; }

        /// <summary>
        /// Default configuration for the `facet` view composition operator
        /// </summary>
        [JsonProperty("facet", NullValueHandling = NullValueHandling.Ignore)]
        public CompositionConfig Facet { get; set; }

        /// <summary>
        /// Defines how Vega-Lite generates title for fields. There are three possible styles:
        /// - `"verbal"` (Default) - displays function in a verbal style (e.g., "Sum of field",
        /// "Year-month of date", "field (binned)").
        /// - `"function"` - displays function using parentheses and capitalized texts (e.g.,
        /// "SUM(field)", "YEARMONTH(date)", "BIN(field)").
        /// - `"plain"` - displays only the field name without functions (e.g., "field", "date",
        /// "field").
        /// </summary>
        [JsonProperty("fieldTitle", NullValueHandling = NullValueHandling.Ignore)]
        public FieldTitle? FieldTitle { get; set; }

        /// <summary>
        /// Geoshape-Specific Config
        /// </summary>
        [JsonProperty("geoshape", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Geoshape { get; set; }

        /// <summary>
        /// Header configuration, which determines default properties for all
        /// [headers](https://vega.github.io/vega-lite/docs/header.html).
        ///
        /// For a full list of header configuration options, please see the [corresponding section of
        /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderConfig Header { get; set; }

        /// <summary>
        /// Header configuration, which determines default properties for column
        /// [headers](https://vega.github.io/vega-lite/docs/header.html).
        ///
        /// For a full list of header configuration options, please see the [corresponding section of
        /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
        /// </summary>
        [JsonProperty("headerColumn", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderConfig HeaderColumn { get; set; }

        /// <summary>
        /// Header configuration, which determines default properties for non-row/column facet
        /// [headers](https://vega.github.io/vega-lite/docs/header.html).
        ///
        /// For a full list of header configuration options, please see the [corresponding section of
        /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
        /// </summary>
        [JsonProperty("headerFacet", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderConfig HeaderFacet { get; set; }

        /// <summary>
        /// Header configuration, which determines default properties for row
        /// [headers](https://vega.github.io/vega-lite/docs/header.html).
        ///
        /// For a full list of header configuration options, please see the [corresponding section of
        /// in the header documentation](https://vega.github.io/vega-lite/docs/header.html#config).
        /// </summary>
        [JsonProperty("headerRow", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderConfig HeaderRow { get; set; }

        /// <summary>
        /// Image-specific Config
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public RectConfig Image { get; set; }

        /// <summary>
        /// Legend configuration, which determines default properties for all
        /// [legends](https://vega.github.io/vega-lite/docs/legend.html). For a full list of legend
        /// configuration options, please see the [corresponding section of in the legend
        /// documentation](https://vega.github.io/vega-lite/docs/legend.html#config).
        /// </summary>
        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public LegendConfig Legend { get; set; }

        /// <summary>
        /// Line-Specific Config
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public LineConfig Line { get; set; }

        /// <summary>
        /// Mark Config
        /// </summary>
        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Mark { get; set; }

        /// <summary>
        /// D3 Number format for guide labels and text marks. For example "s" for SI units. Use [D3's
        /// number format pattern](https://github.com/d3/d3-format#locale_format).
        /// </summary>
        [JsonProperty("numberFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string NumberFormat { get; set; }

        /// <summary>
        /// The default visualization padding, in pixels, from the edge of the visualization canvas
        /// to the data rectangle. If a number, specifies padding for all sides.
        /// If an object, the value should have the format `{"left": 5, "top": 5, "right": 5,
        /// "bottom": 5}` to specify padding for each side of the visualization.
        ///
        /// __Default value__: `5`
        /// </summary>
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public Padding? Padding { get; set; }

        /// <summary>
        /// Point-Specific Config
        /// </summary>
        [JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Point { get; set; }

        /// <summary>
        /// Projection configuration, which determines default properties for all
        /// [projections](https://vega.github.io/vega-lite/docs/projection.html). For a full list of
        /// projection configuration options, please see the [corresponding section of the projection
        /// documentation](https://vega.github.io/vega-lite/docs/projection.html#config).
        /// </summary>
        [JsonProperty("projection", NullValueHandling = NullValueHandling.Ignore)]
        public Projection Projection { get; set; }

        /// <summary>
        /// An object hash that defines default range arrays or schemes for using with scales.
        /// For a full list of scale range configuration options, please see the [corresponding
        /// section of the scale
        /// documentation](https://vega.github.io/vega-lite/docs/scale.html#config).
        /// </summary>
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public RangeConfig Range { get; set; }

        /// <summary>
        /// Rect-Specific Config
        /// </summary>
        [JsonProperty("rect", NullValueHandling = NullValueHandling.Ignore)]
        public RectConfig Rect { get; set; }

        /// <summary>
        /// Default configuration for the `repeat` view composition operator
        /// </summary>
        [JsonProperty("repeat", NullValueHandling = NullValueHandling.Ignore)]
        public CompositionConfig Repeat { get; set; }

        /// <summary>
        /// Rule-Specific Config
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Rule { get; set; }

        /// <summary>
        /// Scale configuration determines default properties for all
        /// [scales](https://vega.github.io/vega-lite/docs/scale.html). For a full list of scale
        /// configuration options, please see the [corresponding section of the scale
        /// documentation](https://vega.github.io/vega-lite/docs/scale.html#config).
        /// </summary>
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleConfig Scale { get; set; }

        /// <summary>
        /// An object hash for defining default properties for each type of selections.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionConfig Selection { get; set; }

        /// <summary>
        /// Square-Specific Config
        /// </summary>
        [JsonProperty("square", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Square { get; set; }

        /// <summary>
        /// An object hash that defines key-value mappings to determine default properties for marks
        /// with a given [style](https://vega.github.io/vega-lite/docs/mark.html#mark-def). The keys
        /// represent styles names; the values have to be valid [mark configuration
        /// objects](https://vega.github.io/vega-lite/docs/mark.html#config).
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, BaseMarkConfig> Style { get; set; }

        /// <summary>
        /// Text-Specific Config
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public MarkConfig Text { get; set; }

        /// <summary>
        /// Tick-Specific Config
        /// </summary>
        [JsonProperty("tick", NullValueHandling = NullValueHandling.Ignore)]
        public TickConfig Tick { get; set; }

        /// <summary>
        /// Default time format for raw time values (without time units) in text marks, legend labels
        /// and header labels.
        ///
        /// __Default value:__ `"%b %d, %Y"`
        /// __Note:__ Axes automatically determine format each label automatically so this config
        /// would not affect axes.
        /// </summary>
        [JsonProperty("timeFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// Title configuration, which determines default properties for all
        /// [titles](https://vega.github.io/vega-lite/docs/title.html). For a full list of title
        /// configuration options, please see the [corresponding section of the title
        /// documentation](https://vega.github.io/vega-lite/docs/title.html#config).
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public ExcludeMappedValueRefBaseTitle Title { get; set; }

        /// <summary>
        /// Trail-Specific Config
        /// </summary>
        [JsonProperty("trail", NullValueHandling = NullValueHandling.Ignore)]
        public LineConfig Trail { get; set; }

        /// <summary>
        /// Default properties for [single view
        /// plots](https://vega.github.io/vega-lite/docs/spec.html#single).
        /// </summary>
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewConfig View { get; set; }
    }
}