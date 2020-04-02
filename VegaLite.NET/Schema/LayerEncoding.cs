using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// A shared key-value mapping between encoding channels and definition of fields in the
    /// underlying layers.
    ///
    /// A key-value mapping between encoding channels and definition of fields.
    /// </summary>
    public class LayerEncoding
    {
        /// <summary>
        /// Color of the marks – either fill or stroke color based on  the `filled` property of mark
        /// definition.
        /// By default, `color` represents fill color for `"area"`, `"bar"`, `"tick"`,
        /// `"text"`, `"trail"`, `"circle"`, and `"square"` / stroke color for `"line"` and
        /// `"point"`.
        ///
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_
        /// 1) For fine-grained control over both fill and stroke colors of the marks, please use the
        /// `fill` and `stroke` channels. The `fill` or `stroke` encodings have higher precedence
        /// than `color`, thus may override the `color` encoding if conflicting encodings are
        /// specified.
        /// 2) See the scale documentation for more information about customizing [color
        /// scheme](https://vega.github.io/vega-lite/docs/scale.html#scheme).
        /// </summary>
        [JsonProperty("color",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Color { get; set; }

        /// <summary>
        /// Additional levels of detail for grouping data in aggregate views and
        /// in line, trail, and area marks without mapping data to a specific visual channel.
        /// </summary>
        [JsonProperty("detail",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Detail? Detail { get; set; }

        /// <summary>
        /// Fill color of the marks.
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_ The `fill` encoding has higher precedence than `color`, thus may override the
        /// `color` encoding if conflicting encodings are specified.
        /// </summary>
        [JsonProperty("fill",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Fill { get; set; }

        /// <summary>
        /// Fill opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `fillOpacity` property.
        /// </summary>
        [JsonProperty("fillOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber FillOpacity { get; set; }

        /// <summary>
        /// A URL to load upon mouse click.
        /// </summary>
        [JsonProperty("href",
                      NullValueHandling = NullValueHandling.Ignore)]
        public HrefClass Href { get; set; }

        /// <summary>
        /// A data field to use as a unique key for data binding. When a visualization’s data is
        /// updated, the key value will be used to match data elements to existing mark instances.
        /// Use a key channel to enable object constancy for transitions over dynamic data.
        /// </summary>
        [JsonProperty("key",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TypedFieldDef Key { get; set; }

        /// <summary>
        /// Latitude position of geographically projected marks.
        /// </summary>
        [JsonProperty("latitude",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LatitudeClass Latitude { get; set; }

        /// <summary>
        /// Latitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`, and
        /// `"rule"`.
        /// </summary>
        [JsonProperty("latitude2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class Latitude2 { get; set; }

        /// <summary>
        /// Longitude position of geographically projected marks.
        /// </summary>
        [JsonProperty("longitude",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LatitudeClass Longitude { get; set; }

        /// <summary>
        /// Longitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`,
        /// and  `"rule"`.
        /// </summary>
        [JsonProperty("longitude2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class Longitude2 { get; set; }

        /// <summary>
        /// Opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `opacity` property.
        /// </summary>
        [JsonProperty("opacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber Opacity { get; set; }

        /// <summary>
        /// Order of the marks.
        /// - For stacked marks, this `order` channel encodes [stack
        /// order](https://vega.github.io/vega-lite/docs/stack.html#order).
        /// - For line and trail marks, this `order` channel encodes order of data points in the
        /// lines. This can be useful for creating [a connected
        /// scatterplot](https://vega.github.io/vega-lite/examples/connected_scatterplot.html).
        /// Setting `order` to `{"value": null}` makes the line marks use the original order in the
        /// data sources.
        /// - Otherwise, this `order` channel encodes layer order of the marks.
        ///
        /// __Note__: In aggregate plots, `order` field should be `aggregate`d to avoid creating
        /// additional aggregation grouping.
        /// </summary>
        [JsonProperty("order",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Order? Order { get; set; }

        /// <summary>
        /// Shape of the mark.
        ///
        /// 1. For `point` marks the supported values include:
        /// - plotting shapes: `"circle"`, `"square"`, `"cross"`, `"diamond"`, `"triangle-up"`,
        /// `"triangle-down"`, `"triangle-right"`, or `"triangle-left"`.
        /// - the line symbol `"stroke"`
        /// - centered directional shapes `"arrow"`, `"wedge"`, or `"triangle"`
        /// - a custom [SVG path
        /// string](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial/Paths) (For correct
        /// sizing, custom shape paths should be defined within a square bounding box with
        /// coordinates ranging from -1 to 1 along both the x and y dimensions.)
        ///
        /// 2. For `geoshape` marks it should be a field definition of the geojson data
        ///
        /// __Default value:__ If undefined, the default shape depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#point-config)'s `shape`
        /// property. (`"circle"` if unset.)
        /// </summary>
        [JsonProperty("shape",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefTypeForShapeStringNull Shape { get; set; }

        /// <summary>
        /// Size of the mark.
        /// - For `"point"`, `"square"` and `"circle"`, – the symbol size, or pixel area of the mark.
        /// - For `"bar"` and `"tick"` – the bar and tick's size.
        /// - For `"text"` – the text's font size.
        /// - Size is unsupported for `"line"`, `"area"`, and `"rect"`. (Use `"trail"` instead of
        /// line with varying size)
        /// </summary>
        [JsonProperty("size",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber Size { get; set; }

        /// <summary>
        /// Stroke color of the marks.
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_ The `stroke` encoding has higher precedence than `color`, thus may override the
        /// `color` encoding if conflicting encodings are specified.
        /// </summary>
        [JsonProperty("stroke",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Stroke { get; set; }

        /// <summary>
        /// Stroke opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeOpacity`
        /// property.
        /// </summary>
        [JsonProperty("strokeOpacity",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber StrokeOpacity { get; set; }

        /// <summary>
        /// Stroke width of the marks.
        ///
        /// __Default value:__ If undefined, the default stroke width depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeWidth` property.
        /// </summary>
        [JsonProperty("strokeWidth",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber StrokeWidth { get; set; }

        /// <summary>
        /// Text of the `text` mark.
        /// </summary>
        [JsonProperty("text",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionStringFieldDefText Text { get; set; }

        /// <summary>
        /// The tooltip text to show upon mouse hover. Specifying `tooltip` encoding overrides [the
        /// `tooltip` property in the mark
        /// definition](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
        ///
        /// See the [`tooltip`](https://vega.github.io/vega-lite/docs/tooltip.html) documentation for
        /// a detailed discussion about tooltip in Vega-Lite.
        /// </summary>
        [JsonProperty("tooltip",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Tooltip? Tooltip { get; set; }

        /// <summary>
        /// The URL of an image mark.
        /// </summary>
        [JsonProperty("url",
                      NullValueHandling = NullValueHandling.Ignore)]
        public HrefClass Url { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x",
                      NullValueHandling = NullValueHandling.Ignore)]
        public XClass X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public X2Class X2 { get; set; }

        /// <summary>
        /// Error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("xError",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class XError { get; set; }

        /// <summary>
        /// Secondary error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("xError2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class XError2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y",
                      NullValueHandling = NullValueHandling.Ignore)]
        public YClass Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Y2Class Y2 { get; set; }

        /// <summary>
        /// Error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("yError",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class YError { get; set; }

        /// <summary>
        /// Secondary error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("yError2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class YError2 { get; set; }
    }
}
