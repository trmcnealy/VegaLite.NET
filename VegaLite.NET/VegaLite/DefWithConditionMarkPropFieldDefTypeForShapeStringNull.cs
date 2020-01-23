using Newtonsoft.Json;

namespace VegaLite
{
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
    ///
    /// A FieldDef with Condition<ValueDef>
    /// {
    /// condition: {value: ...},
    /// field: ...,
    /// ...
    /// }
    /// </summary>
    public class DefWithConditionMarkPropFieldDefTypeForShapeStringNull
    {
        /// <summary>
        /// Aggregation function for the field
        /// (e.g., `"mean"`, `"sum"`, `"median"`, `"min"`, `"max"`, `"count"`).
        ///
        /// __Default value:__ `undefined` (None)
        ///
        /// __See also:__ [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html)
        /// documentation.
        /// </summary>
        [JsonProperty("aggregate", NullValueHandling = NullValueHandling.Ignore)]
        public Aggregate? Aggregate { get; set; }

        /// <summary>
        /// A flag for binning a `quantitative` field, [an object defining binning
        /// parameters](https://vega.github.io/vega-lite/docs/bin.html#params), or indicating that
        /// the data for `x` or `y` channel are binned before they are imported into Vega-Lite
        /// (`"binned"`).
        ///
        /// - If `true`, default [binning parameters](https://vega.github.io/vega-lite/docs/bin.html)
        /// will be applied.
        ///
        /// - If `"binned"`, this indicates that the data for the `x` (or `y`) channel are already
        /// binned. You can map the bin-start field to `x` (or `y`) and the bin-end field to `x2` (or
        /// `y2`). The scale and axis will be formatted similar to binning in Vega-Lite.  To adjust
        /// the axis ticks based on the bin step, you can also set the axis's
        /// [`tickMinStep`](https://vega.github.io/vega-lite/docs/axis.html#ticks) property.
        ///
        /// __Default value:__ `false`
        ///
        /// __See also:__ [`bin`](https://vega.github.io/vega-lite/docs/bin.html) documentation.
        /// </summary>
        [JsonProperty("bin", NullValueHandling = NullValueHandling.Ignore)]
        public BoolBinParams? Bin { get; set; }

        /// <summary>
        /// One or more value definition(s) with [a selection or a test
        /// predicate](https://vega.github.io/vega-lite/docs/condition.html).
        ///
        /// __Note:__ A field definition's `condition` property can only contain [conditional value
        /// definitions](https://vega.github.io/vega-lite/docs/condition.html#value)
        /// since Vega-Lite only allows at most one encoded field per encoding channel.
        ///
        /// A field definition or one or more value definition(s) with a selection predicate.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ShapeCondition? Condition { get; set; }

        /// <summary>
        /// __Required.__ A string defining the name of the field from which to pull a data value
        /// or an object defining iterated values from the
        /// [`repeat`](https://vega.github.io/vega-lite/docs/repeat.html) operator.
        ///
        /// __See also:__ [`field`](https://vega.github.io/vega-lite/docs/field.html) documentation.
        ///
        /// __Notes:__
        /// 1)  Dots (`.`) and brackets (`[` and `]`) can be used to access nested objects (e.g.,
        /// `"field": "foo.bar"` and `"field": "foo['bar']"`).
        /// If field names contain dots or brackets but are not nested, you can use `\\` to escape
        /// dots and brackets (e.g., `"a\\.b"` and `"a\\[0\\]"`).
        /// See more details about escaping in the [field
        /// documentation](https://vega.github.io/vega-lite/docs/field.html).
        /// 2) `field` is not required if `aggregate` is `count`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining properties of the legend.
        /// If `null`, the legend for the encoding channel will be removed.
        ///
        /// __Default value:__ If undefined, default [legend
        /// properties](https://vega.github.io/vega-lite/docs/legend.html) are applied.
        ///
        /// __See also:__ [`legend`](https://vega.github.io/vega-lite/docs/legend.html) documentation.
        /// </summary>
        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public Legend Legend { get; set; }

        /// <summary>
        /// An object defining properties of the channel's scale, which is the function that
        /// transforms values in the data domain (numbers, dates, strings, etc) to visual values
        /// (pixels, colors, sizes) of the encoding channels.
        ///
        /// If `null`, the scale will be [disabled and the data value will be directly
        /// encoded](https://vega.github.io/vega-lite/docs/scale.html#disable).
        ///
        /// __Default value:__ If undefined, default [scale
        /// properties](https://vega.github.io/vega-lite/docs/scale.html) are applied.
        ///
        /// __See also:__ [`scale`](https://vega.github.io/vega-lite/docs/scale.html) documentation.
        /// </summary>
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public Scale Scale { get; set; }

        /// <summary>
        /// Sort order for the encoded field.
        ///
        /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
        /// `"descending"`.
        ///
        /// For discrete fields, `sort` can be one of the following:
        /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
        /// JavaScript.
        /// - [A string indicating an encoding channel name to sort
        /// by](https://vega.github.io/vega-lite/docs/sort.html#sort-by-encoding) (e.g., `"x"` or
        /// `"y"`) with an optional minus prefix for descending sort (e.g., `"-x"` to sort by
        /// x-field, descending). This channel string is short-form of [a sort-by-encoding
        /// definition](https://vega.github.io/vega-lite/docs/sort.html#sort-by-encoding). For
        /// example, `"sort": "-x"` is equivalent to `"sort": {"encoding": "x", "order":
        /// "descending"}`.
        /// - [A sort field definition](https://vega.github.io/vega-lite/docs/sort.html#sort-field)
        /// for sorting by another field.
        /// - [An array specifying the field values in preferred
        /// order](https://vega.github.io/vega-lite/docs/sort.html#sort-array). In this case, the
        /// sort order will obey the values in the array, followed by any unspecified values in their
        /// original order. For discrete time field, values in the sort array can be [date-time
        /// definition objects](types#datetime). In addition, for time units `"month"` and `"day"`,
        /// the values can be the month or day names (case insensitive) or their 3-letter initials
        /// (e.g., `"Mon"`, `"Tue"`).
        /// - `null` indicating no sort.
        ///
        /// __Default value:__ `"ascending"`
        ///
        /// __Note:__ `null` and sorting by another channel is not supported for `row` and `column`.
        ///
        /// __See also:__ [`sort`](https://vega.github.io/vega-lite/docs/sort.html) documentation.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortUnion? Sort { get; set; }

        /// <summary>
        /// Time unit (e.g., `year`, `yearmonth`, `month`, `hours`) for a temporal field.
        /// or [a temporal field that gets casted as
        /// ordinal](https://vega.github.io/vega-lite/docs/type.html#cast).
        ///
        /// __Default value:__ `undefined` (None)
        ///
        /// __See also:__ [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html)
        /// documentation.
        /// </summary>
        [JsonProperty("timeUnit", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnit? TimeUnit { get; set; }

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
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleText? Title { get; set; }

        /// <summary>
        /// The encoded field's type of measurement (`"quantitative"`, `"temporal"`, `"ordinal"`, or
        /// `"nominal"`).
        /// It can also be a `"geojson"` type for encoding
        /// ['geoshape'](https://vega.github.io/vega-lite/docs/geoshape.html).
        ///
        ///
        /// __Note:__
        ///
        /// - DataSource values for a temporal field can be either a date-time string (e.g., `"2015-03-07
        /// 12:32:17"`, `"17:01"`, `"2015-03-16"`. `"2015"`) or a timestamp number (e.g.,
        /// `1552199579097`).
        /// - DataSource `type` describes the semantics of the data rather than the primitive data types
        /// (number, string, etc.). The same primitive data type can have different types of
        /// measurement. For example, numeric data can represent quantitative, ordinal, or nominal
        /// data.
        /// - When using with [`bin`](https://vega.github.io/vega-lite/docs/bin.html), the `type`
        /// property can be either `"quantitative"` (for using a linear bin scale) or [`"ordinal"`
        /// (for using an ordinal bin
        /// scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
        /// - When using with [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html), the
        /// `type` property can be either `"temporal"` (for using a temporal scale) or [`"ordinal"`
        /// (for using an ordinal scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
        /// - When using with [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html),
        /// the `type` property refers to the post-aggregation data type. For example, we can
        /// calculate count `distinct` of a categorical field `"cat"` using `{"aggregate":
        /// "distinct", "field": "cat", "type": "quantitative"}`. The `"type"` of the aggregate
        /// output is `"quantitative"`.
        /// - Secondary channels (e.g., `x2`, `y2`, `xError`, `yError`) do not have `type` as they
        /// have exactly the same type as their primary channels (e.g., `x`, `y`).
        ///
        /// __See also:__ [`type`](https://vega.github.io/vega-lite/docs/type.html) documentation.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeForShape? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}