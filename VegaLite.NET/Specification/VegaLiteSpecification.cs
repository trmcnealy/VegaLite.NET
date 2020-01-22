using System;
using System.Collections.Generic;

using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

//TODO Finish moving classes to individual files
namespace VegaLite
{
    /// <summary>
    /// A Vega-Lite top-level specification.
    /// This is the root class for all Vega-Lite specifications.
    /// (The json schema is generated from this type.)
    /// </summary>
    public partial class Specification
    {
        /// <summary>
        /// URL to [JSON schema](http://json-schema.org/) for a Vega-Lite specification. Unless you
        /// have a reason to change this, use `https://vega.github.io/schema/vega-lite/v4.json`.
        /// Setting the `$schema` property allows automatic validation and autocomplete in editors
        /// that support JSON schema.
        /// </summary>
        [JsonProperty("$schema", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Schema { get; set; } = new Uri("https://vega.github.io/schema/vega-lite/v4.json");

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
        /// CSS color property to use as the background of the entire view.
        ///
        /// __Default value:__ `"white"`
        /// </summary>
        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }

        /// <summary>
        /// The bounds calculation method to use for determining the extent of a sub-plot. One of
        /// `full` (the default) or `flush`.
        ///
        /// - If set to `full`, the entire calculated bounds (including axes, title, and legend) will
        /// be used.
        /// - If set to `flush`, only the specified width and height values for the sub-view will be
        /// used. The `flush` setting can be useful when attempting to place sub-plots without axes
        /// or legends into a uniform grid structure.
        ///
        /// __Default value:__ `"full"`
        /// </summary>
        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        public BoundsEnum? Bounds { get; set; }

        /// <summary>
        /// Vega-Lite configuration object. This property can only be defined at the top-level of a
        /// specification.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Config Config { get; set; }

        /// <summary>
        /// An object describing the data source. Set to `null` to ignore the parent's data source.
        /// If no data is set, it is derived from the parent.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataSource Data { get; set; }

        /// <summary>
        /// A global data store for named datasets. This is a mapping from names to inline datasets.
        /// This can be an array of objects or primitive values or a string. Arrays of primitive
        /// values are ingested as objects with a `data` property.
        /// </summary>
        [JsonProperty("datasets", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, InlineDataset> Datasets { get; set; }

        /// <summary>
        /// Description of this mark for commenting purpose.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// A key-value mapping between encoding channels and definition of fields.
        ///
        /// A shared key-value mapping between encoding channels and definition of fields in the
        /// underlying layers.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public Encoding Encoding { get; set; }

        /// <summary>
        /// The height of a visualization.
        ///
        /// - For a plot with a continuous y-field, height should be a number.
        /// - For a plot with either a discrete y-field or no y-field, height can be either a number
        /// indicating a fixed height or an object in the form of `{step: number}` defining the
        /// height per discrete step. (No y-field is equivalent to having one discrete step.)
        /// - To enable responsive sizing on height, it should be set to `"container"`.
        ///
        /// __Default value:__ Based on `config.view.continuousHeight` for a plot with a continuous
        /// y-field and `config.view.discreteHeight` otherwise.
        ///
        /// __Note:__ For plots with [`row` and `column`
        /// channels](https://vega.github.io/vega-lite/docs/encoding.html#facet), this represents the
        /// height of a single view and the `"container"` option cannot be used.
        ///
        /// __See also:__ [`height`](https://vega.github.io/vega-lite/docs/size.html) documentation.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public HeightUnion? Height { get; set; }

        /// <summary>
        /// A string describing the mark type (one of `"bar"`, `"circle"`, `"square"`, `"tick"`,
        /// `"line"`,
        /// `"area"`, `"point"`, `"rule"`, `"geoshape"`, and `"text"`) or a [mark definition
        /// object](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
        /// </summary>
        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        public AnyMark? Mark { get; set; }

        /// <summary>
        /// Name of the visualization for later reference.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// An object defining properties of geographic projection, which will be applied to `shape`
        /// path for `"geoshape"` marks
        /// and to `latitude` and `"longitude"` channels for other marks.
        ///
        /// An object defining properties of the geographic projection shared by underlying layers.
        /// </summary>
        [JsonProperty("projection", NullValueHandling = NullValueHandling.Ignore)]
        public Projection Projection { get; set; }

        /// <summary>
        /// Scale, axis, and legend resolutions for view composition specifications.
        /// </summary>
        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public Resolve Resolve { get; set; }

        /// <summary>
        /// A key-value mapping between selection names and definitions.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, SelectionDef> Selection { get; set; }

        /// <summary>
        /// Title for the plot.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public LayerTitle? Title { get; set; }

        /// <summary>
        /// An array of data transformations such as filter and new field calculation.
        /// </summary>
        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public List<Transform> Transform { get; set; }

        /// <summary>
        /// Optional metadata that will be passed to Vega.
        /// This object is completely ignored by Vega and Vega-Lite and can be used for custom
        /// metadata.
        /// </summary>
        [JsonProperty("usermeta", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Usermeta { get; set; }

        /// <summary>
        /// An object defining the view background's fill and stroke.
        ///
        /// __Default value:__ none (transparent)
        /// </summary>
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewBackground View { get; set; }

        /// <summary>
        /// The width of a visualization.
        ///
        /// - For a plot with a continuous x-field, width should be a number.
        /// - For a plot with either a discrete x-field or no x-field, width can be either a number
        /// indicating a fixed width or an object in the form of `{step: number}` defining the width
        /// per discrete step. (No x-field is equivalent to having one discrete step.)
        /// - To enable responsive sizing on width, it should be set to `"container"`.
        ///
        /// __Default value:__
        /// Based on `config.view.continuousWidth` for a plot with a continuous x-field and
        /// `config.view.discreteWidth` otherwise.
        ///
        /// __Note:__ For plots with [`row` and `column`
        /// channels](https://vega.github.io/vega-lite/docs/encoding.html#facet), this represents the
        /// width of a single view and the `"container"` option cannot be used.
        ///
        /// __See also:__ [`width`](https://vega.github.io/vega-lite/docs/size.html) documentation.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public HeightUnion? Width { get; set; }

        /// <summary>
        /// The alignment to apply to grid rows and columns.
        /// The supported string values are `"all"`, `"each"`, and `"none"`.
        ///
        /// - For `"none"`, a flow layout will be used, in which adjacent subviews are simply placed
        /// one after the other.
        /// - For `"each"`, subviews will be aligned into a clean grid structure, but each row or
        /// column may be of variable size.
        /// - For `"all"`, subviews will be aligned and each row or column will be sized identically
        /// based on the maximum observed size. String values for this property will be applied to
        /// both grid rows and columns.
        ///
        /// Alternatively, an object value of the form `{"row": string, "column": string}` can be
        /// used to supply different alignments for rows and columns.
        ///
        /// __Default value:__ `"all"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public AlignUnion? Align { get; set; }

        /// <summary>
        /// Boolean flag indicating if subviews should be centered relative to their respective rows
        /// or columns.
        ///
        /// An object value of the form `{"row": boolean, "column": boolean}` can be used to supply
        /// different centering values for rows and columns.
        ///
        /// __Default value:__ `false`
        ///
        /// Boolean flag indicating if subviews should be centered relative to their respective rows
        /// or columns.
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public SpecificationCenter? Center { get; set; }

        /// <summary>
        /// The number of columns to include in the view composition layout.
        ///
        /// __Default value__: `undefined` -- An infinite number of columns (a single row) will be
        /// assumed. This is equivalent to
        /// `hconcat` (for `concat`) and to using the `column` channel (for `facet` and `repeat`).
        ///
        /// __Note__:
        ///
        /// 1) This property is only for:
        /// - the general (wrappable) `concat` operator (not `hconcat`/`vconcat`)
        /// - the `facet` and `repeat` operator with one field/repetition definition (without
        /// row/column nesting)
        ///
        /// 2) Setting the `columns` to `1` is equivalent to `vconcat` (for `concat`) and to using
        /// the `row` channel (for `facet` and `repeat`).
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public double? Columns { get; set; }

        /// <summary>
        /// Definition for how to facet the data. One of:
        /// 1) [a field definition for faceting the plot by one
        /// field](https://vega.github.io/vega-lite/docs/facet.html#field-def)
        /// 2) [An object that maps `row` and `column` channels to their field
        /// definitions](https://vega.github.io/vega-lite/docs/facet.html#mapping)
        /// </summary>
        [JsonProperty("facet", NullValueHandling = NullValueHandling.Ignore)]
        public Facet Facet { get; set; }

        /// <summary>
        /// The spacing in pixels between sub-views of the composition operator.
        /// An object of the form `{"row": number, "column": number}` can be used to set
        /// different spacing values for rows and columns.
        ///
        /// __Default value__: Depends on `"spacing"` property of [the view composition
        /// configuration](https://vega.github.io/vega-lite/docs/config.html#view-config) (`20` by
        /// default)
        ///
        /// The spacing in pixels between sub-views of the concat operator.
        ///
        /// __Default value__: `10`
        /// </summary>
        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public Spacing? Spacing { get; set; }

        /// <summary>
        /// A specification of the view that gets faceted.
        ///
        /// A specification of the view that gets repeated.
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public SpecClass Spec { get; set; }

        /// <summary>
        /// Layer or single view specifications to be layered.
        ///
        /// __Note__: Specifications inside `layer` cannot use `row` and `column` channels as
        /// layering facet specifications is not allowed. Instead, use the [facet
        /// operator](https://vega.github.io/vega-lite/docs/facet.html) and place a layer inside a
        /// facet.
        /// </summary>
        [JsonProperty("layer", NullValueHandling = NullValueHandling.Ignore)]
        public List<LayerSpec> Layer { get; set; }

        /// <summary>
        /// Definition for fields to be repeated. One of:
        /// 1) An array of fields to be repeated. If `"repeat"` is an array, the field can be
        /// referred using `{"repeat": "repeat"}`
        /// 2) An object that mapped `"row"` and/or `"column"` to the listed of fields to be repeated
        /// along the particular orientations. The objects `{"repeat": "row"}` and `{"repeat":
        /// "column"}` can be used to refer to the repeated field respectively.
        /// </summary>
        [JsonProperty("repeat", NullValueHandling = NullValueHandling.Ignore)]
        public RepeatUnion? Repeat { get; set; }

        /// <summary>
        /// A list of views to be concatenated.
        /// </summary>
        [JsonProperty("concat", NullValueHandling = NullValueHandling.Ignore)]
        public List<Spec> Concat { get; set; }

        /// <summary>
        /// A list of views to be concatenated and put into a column.
        /// </summary>
        [JsonProperty("vconcat", NullValueHandling = NullValueHandling.Ignore)]
        public List<Spec> Vconcat { get; set; }

        /// <summary>
        /// A list of views to be concatenated and put into a row.
        /// </summary>
        [JsonProperty("hconcat", NullValueHandling = NullValueHandling.Ignore)]
        public List<Spec> Hconcat { get; set; }
    }

    public partial class DataSource : DynamicObject
    {
        /// <summary>
        /// An object that specifies the format for parsing the data.
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public DataFormat Format { get; set; }

        /// <summary>
        /// Provide a placeholder name and bind data at runtime.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// An URL from which to load the data set. Use the `format.type` property
        /// to ensure the loaded data is correctly parsed.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The full data set, included inline. This can be an array of objects or primitive values,
        /// an object, or a string.
        /// Arrays of primitive values are ingested as objects with a `data` property. Strings are
        /// parsed according to the specified format type.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        
        public dynamic? Values { get; set; }

        /// <summary>
        /// Generate a sequence of numbers.
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public SequenceParams Sequence { get; set; }

        /// <summary>
        /// Generate sphere GeoJSON data for the full globe.
        /// </summary>
        [JsonProperty("sphere", NullValueHandling = NullValueHandling.Ignore)]
        public SphereUnion? Sphere { get; set; }

        /// <summary>
        /// Generate graticule GeoJSON data for geographic reference lines.
        /// </summary>
        [JsonProperty("graticule", NullValueHandling = NullValueHandling.Ignore)]
        public Graticule? Graticule { get; set; }
    }

    /// <summary>
    /// An object that specifies the format for parsing the data.
    /// </summary>
    public partial class DataFormat
    {
        /// <summary>
        /// If set to `null`, disable type inference based on the spec and only use type inference
        /// based on the data.
        /// Alternatively, a parsing directive object can be provided for explicit data types. Each
        /// property of the object corresponds to a field name, and the value to the desired data
        /// type (one of `"number"`, `"boolean"`, `"date"`, or null (do not parse the field)).
        /// For example, `"parse": {"modified_on": "date"}` parses the `modified_on` field in each
        /// input record a Date value.
        ///
        /// For `"date"`, we parse data based using Javascript's
        /// [`Date.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/parse).
        /// For Specific date formats can be provided (e.g., `{foo: "date:'%m%d%Y'"}`), using the
        /// [d3-time-format syntax](https://github.com/d3/d3-time-format#locale_format). UTC date
        /// format parsing is supported similarly (e.g., `{foo: "utc:'%m%d%Y'"}`). See more about
        /// [UTC time](https://vega.github.io/vega-lite/docs/timeunit.html#utc)
        /// </summary>
        [JsonProperty("parse", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Parse { get; set; }

        /// <summary>
        /// Type of input data: `"json"`, `"csv"`, `"tsv"`, `"dsv"`.
        ///
        /// __Default value:__  The default format type is determined by the extension of the file
        /// URL.
        /// If no extension is detected, `"json"` will be used by default.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public DataFormatType? Type { get; set; }

        /// <summary>
        /// The delimiter between records. The delimiter must be a single character (i.e., a single
        /// 16-bit code unit); so, ASCII delimiters are fine, but emoji delimiters are not.
        /// </summary>
        [JsonProperty("delimiter", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxLengthCheckConverter))]
        public string Delimiter { get; set; }

        /// <summary>
        /// The JSON property containing the desired data.
        /// This parameter can be used when the loaded JSON file may have surrounding structure or
        /// meta-data.
        /// For example `"property": "values.features"` is equivalent to retrieving
        /// `json.values.features`
        /// from the loaded JSON object.
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }

        /// <summary>
        /// The name of the TopoJSON object set to convert to a GeoJSON feature collection.
        /// For example, in a map of the world, there may be an object set named `"countries"`.
        /// Using the feature property, we can extract this set and generate a GeoJSON feature object
        /// for each country.
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

        /// <summary>
        /// The name of the TopoJSON object set to convert to mesh.
        /// Similar to the `feature` option, `mesh` extracts a named TopoJSON object set.
        /// Unlike the `feature` option, the corresponding geo data is returned as a single, unified
        /// mesh instance, not as individual GeoJSON features.
        /// Extracting a mesh is useful for more efficiently drawing borders or other geographic
        /// elements that you do not need to associate with specific regions such as individual
        /// countries, states or counties.
        /// </summary>
        [JsonProperty("mesh", NullValueHandling = NullValueHandling.Ignore)]
        public string Mesh { get; set; }
    }

    public partial class GraticuleParams
    {
        /// <summary>
        /// Sets both the major and minor extents to the same values.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> Extent { get; set; }

        /// <summary>
        /// The major extent of the graticule as a two-element array of coordinates.
        /// </summary>
        [JsonProperty("extentMajor", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> ExtentMajor { get; set; }

        /// <summary>
        /// The minor extent of the graticule as a two-element array of coordinates.
        /// </summary>
        [JsonProperty("extentMinor", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> ExtentMinor { get; set; }

        /// <summary>
        /// The precision of the graticule in degrees.
        ///
        /// __Default value:__ `2.5`
        /// </summary>
        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public double? Precision { get; set; }

        /// <summary>
        /// Sets both the major and minor step angles to the same values.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Step { get; set; }

        /// <summary>
        /// The major step angles of the graticule.
        ///
        ///
        /// __Default value:__ `[90, 360]`
        /// </summary>
        [JsonProperty("stepMajor", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StepMajor { get; set; }

        /// <summary>
        /// The minor step angles of the graticule.
        ///
        /// __Default value:__ `[10, 10]`
        /// </summary>
        [JsonProperty("stepMinor", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StepMinor { get; set; }
    }

    /// <summary>
    /// Generate a sequence of numbers.
    /// </summary>
    public partial class SequenceParams
    {
        /// <summary>
        /// The name of the generated sequence field.
        ///
        /// __Default value:__ `"data"`
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        /// <summary>
        /// The starting value of the sequence (inclusive).
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public double Start { get; set; }

        /// <summary>
        /// The step value between sequence entries.
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// The ending value of the sequence (exclusive).
        /// </summary>
        [JsonProperty("stop", NullValueHandling = NullValueHandling.Ignore)]
        public double Stop { get; set; }
    }

    public partial class SphereClass
    {
    }

    /// <summary>
    /// A key-value mapping between encoding channels and definition of fields.
    ///
    /// A shared key-value mapping between encoding channels and definition of fields in the
    /// underlying layers.
    /// </summary>
    public partial class Encoding
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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Color { get; set; }

        /// <summary>
        /// A field definition for the horizontal facet of trellis plots.
        /// </summary>
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public RowColumnEncodingFieldDef Column { get; set; }

        /// <summary>
        /// Additional levels of detail for grouping data in aggregate views and
        /// in line, trail, and area marks without mapping data to a specific visual channel.
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public Detail? Detail { get; set; }

        /// <summary>
        /// A field definition for the (flexible) facet of trellis plots.
        ///
        /// If either `row` or `column` is specified, this channel will be ignored.
        /// </summary>
        [JsonProperty("facet", NullValueHandling = NullValueHandling.Ignore)]
        public FacetEncodingFieldDef Facet { get; set; }

        /// <summary>
        /// Fill color of the marks.
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_ The `fill` encoding has higher precedence than `color`, thus may override the
        /// `color` encoding if conflicting encodings are specified.
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Fill { get; set; }

        /// <summary>
        /// Fill opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `fillOpacity` property.
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber FillOpacity { get; set; }

        /// <summary>
        /// A URL to load upon mouse click.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public HrefClass Href { get; set; }

        /// <summary>
        /// A data field to use as a unique key for data binding. When a visualization’s data is
        /// updated, the key value will be used to match data elements to existing mark instances.
        /// Use a key channel to enable object constancy for transitions over dynamic data.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public TypedFieldDef Key { get; set; }

        /// <summary>
        /// Latitude position of geographically projected marks.
        /// </summary>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public LatitudeClass Latitude { get; set; }

        /// <summary>
        /// Latitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`, and
        /// `"rule"`.
        /// </summary>
        [JsonProperty("latitude2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class Latitude2 { get; set; }

        /// <summary>
        /// Longitude position of geographically projected marks.
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public LatitudeClass Longitude { get; set; }

        /// <summary>
        /// Longitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`,
        /// and  `"rule"`.
        /// </summary>
        [JsonProperty("longitude2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class Longitude2 { get; set; }

        /// <summary>
        /// Opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `opacity` property.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Order? Order { get; set; }

        /// <summary>
        /// A field definition for the vertical facet of trellis plots.
        /// </summary>
        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public RowColumnEncodingFieldDef Row { get; set; }

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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefTypeForShapeStringNull Shape { get; set; }

        /// <summary>
        /// Size of the mark.
        /// - For `"point"`, `"square"` and `"circle"`, – the symbol size, or pixel area of the mark.
        /// - For `"bar"` and `"tick"` – the bar and tick's size.
        /// - For `"text"` – the text's font size.
        /// - Size is unsupported for `"line"`, `"area"`, and `"rect"`. (Use `"trail"` instead of
        /// line with varying size)
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber Size { get; set; }

        /// <summary>
        /// Stroke color of the marks.
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_ The `stroke` encoding has higher precedence than `color`, thus may override the
        /// `color` encoding if conflicting encodings are specified.
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Stroke { get; set; }

        /// <summary>
        /// Stroke opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeOpacity`
        /// property.
        /// </summary>
        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber StrokeOpacity { get; set; }

        /// <summary>
        /// Stroke width of the marks.
        ///
        /// __Default value:__ If undefined, the default stroke width depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeWidth` property.
        /// </summary>
        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber StrokeWidth { get; set; }

        /// <summary>
        /// Text of the `text` mark.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionStringFieldDefText Text { get; set; }

        /// <summary>
        /// The tooltip text to show upon mouse hover. Specifying `tooltip` encoding overrides [the
        /// `tooltip` property in the mark
        /// definition](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
        ///
        /// See the [`tooltip`](https://vega.github.io/vega-lite/docs/tooltip.html) documentation for
        /// a detailed discussion about tooltip in Vega-Lite.
        /// </summary>
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Tooltip? Tooltip { get; set; }

        /// <summary>
        /// The URL of an image mark.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public HrefClass Url { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XClass X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public X2Class X2 { get; set; }

        /// <summary>
        /// Error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("xError", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class XError { get; set; }

        /// <summary>
        /// Secondary error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("xError2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class XError2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YClass Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public Y2Class Y2 { get; set; }

        /// <summary>
        /// Error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("yError", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class YError { get; set; }

        /// <summary>
        /// Secondary error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("yError2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class YError2 { get; set; }
    }

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
    ///
    /// Fill color of the marks.
    /// __Default value:__ If undefined, the default color depends on [mark
    /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
    ///
    /// _Note:_ The `fill` encoding has higher precedence than `color`, thus may override the
    /// `color` encoding if conflicting encodings are specified.
    ///
    /// Stroke color of the marks.
    /// __Default value:__ If undefined, the default color depends on [mark
    /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
    ///
    /// _Note:_ The `stroke` encoding has higher precedence than `color`, thus may override the
    /// `color` encoding if conflicting encodings are specified.
    ///
    /// A FieldDef with Condition<ValueDef>
    /// {
    /// condition: {value: ...},
    /// field: ...,
    /// ...
    /// }
    /// </summary>
    public partial class DefWithConditionMarkPropFieldDefGradientStringNull
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
        public PurpleBin? Bin { get; set; }

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
        public ColorCondition? Condition { get; set; }

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
        [JsonProperty("field")]
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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueUnion? Value { get; set; }
    }

    public partial class ArgmDef
    {
        [JsonProperty("argmax", NullValueHandling = NullValueHandling.Ignore)]
        public string Argmax { get; set; }

        [JsonProperty("argmin", NullValueHandling = NullValueHandling.Ignore)]
        public string Argmin { get; set; }
    }

    /// <summary>
    /// Binning properties or boolean flag for determining whether to bin data or not.
    /// </summary>
    public partial class BinParams
    {
        /// <summary>
        /// A value in the binned domain at which to anchor the bins, shifting the bin boundaries if
        /// necessary to ensure that a boundary aligns with the anchor value.
        ///
        /// __Default value:__ the minimum bin extent value
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public double? Anchor { get; set; }

        /// <summary>
        /// The number base to use for automatic bin determination (default is base 10).
        ///
        /// __Default value:__ `10`
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public double? Base { get; set; }

        /// <summary>
        /// When set to `true`, Vega-Lite treats the input data as already binned.
        /// </summary>
        [JsonProperty("binned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Binned { get; set; }

        /// <summary>
        /// Scale factors indicating allowable subdivisions. The default value is [5, 2], which
        /// indicates that for base 10 numbers (the default base), the method may consider dividing
        /// bin sizes by 5 and/or 2. For example, for an initial step size of 10, the method can
        /// check if bin sizes of 2 (= 10/5), 5 (= 10/2), or 1 (= 10/(5*2)) might also satisfy the
        /// given constraints.
        ///
        /// __Default value:__ `[5, 2]`
        /// </summary>
        [JsonProperty("divide", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Divide { get; set; }

        /// <summary>
        /// A two-element (`[min, max]`) array indicating the range of desired bin values.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public BinExtent? Extent { get; set; }

        /// <summary>
        /// Maximum number of bins.
        ///
        /// __Default value:__ `6` for `row`, `column` and `shape` channels; `10` for other channels
        /// </summary>
        [JsonProperty("maxbins", NullValueHandling = NullValueHandling.Ignore)]
        public double? Maxbins { get; set; }

        /// <summary>
        /// A minimum allowable step size (particularly useful for integer values).
        /// </summary>
        [JsonProperty("minstep", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minstep { get; set; }

        /// <summary>
        /// If true, attempts to make the bin boundaries use human-friendly boundaries, such as
        /// multiples of ten.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("nice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nice { get; set; }

        /// <summary>
        /// An exact step size to use between bins.
        ///
        /// __Note:__ If provided, options such as maxbins will be ignored.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// An array of allowable step sizes to choose from.
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Steps { get; set; }
    }

    public partial class BinExtentClass
    {
        /// <summary>
        /// The field name to extract selected values for, when a selection is
        /// [projected](https://vega.github.io/vega-lite/docs/project.html)
        /// over multiple fields or encodings.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The name of a selection.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public string Selection { get; set; }

        /// <summary>
        /// The encoding channel to extract selected values for, when a selection is
        /// [projected](https://vega.github.io/vega-lite/docs/project.html)
        /// over multiple fields or encodings.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public SingleDefUnitChannel? Encoding { get; set; }
    }

    public partial class ConditionalValueDefGradientStringNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueUnion Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }

    public partial class Selection
    {
        [JsonProperty("not", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Not { get; set; }

        [JsonProperty("and", NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectionOperand> And { get; set; }

        [JsonProperty("or", NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectionOperand> Or { get; set; }
    }

    public partial class Predicate
    {
        [JsonProperty("not", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Not { get; set; }

        [JsonProperty("and", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogicalOperandPredicate> And { get; set; }

        [JsonProperty("or", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogicalOperandPredicate> Or { get; set; }

        /// <summary>
        /// The value that the field should be equal to.
        /// </summary>
        [JsonProperty("equal", NullValueHandling = NullValueHandling.Ignore)]
        public Equal? Equal { get; set; }

        /// <summary>
        /// Field to be filtered.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// Time unit for the field to be filtered.
        /// </summary>
        [JsonProperty("timeUnit", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnit? TimeUnit { get; set; }

        /// <summary>
        /// An array of inclusive minimum and maximum values
        /// for a field value of a data item to be included in the filtered data.
        /// </summary>
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public List<PurpleRange> Range { get; set; }

        /// <summary>
        /// A set of values that the `field`'s value should be a member of,
        /// for a data item included in the filtered data.
        /// </summary>
        [JsonProperty("oneOf", NullValueHandling = NullValueHandling.Ignore)]
        public List<Equal> OneOf { get; set; }

        /// <summary>
        /// The value that the field should be less than.
        /// </summary>
        [JsonProperty("lt", NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Lt { get; set; }

        /// <summary>
        /// The value that the field should be greater than.
        /// </summary>
        [JsonProperty("gt", NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Gt { get; set; }

        /// <summary>
        /// The value that the field should be less than or equals to.
        /// </summary>
        [JsonProperty("lte", NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Lte { get; set; }

        /// <summary>
        /// The value that the field should be greater than or equals to.
        /// </summary>
        [JsonProperty("gte", NullValueHandling = NullValueHandling.Ignore)]
        public Lt? Gte { get; set; }

        /// <summary>
        /// If set to true the field's value has to be valid, meaning both not `null` and not
        /// [`NaN`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/NaN).
        /// </summary>
        [JsonProperty("valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Valid { get; set; }

        /// <summary>
        /// Filter using a selection name.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }

    /// <summary>
    /// Object for defining datetime in Vega-Lite Filter.
    /// If both month and quarter are provided, month has higher precedence.
    /// `day` cannot be combined with other date.
    /// We accept string for month and day names.
    /// </summary>
    public partial class DateTime
    {
        /// <summary>
        /// Integer value representing the date from 1-31.
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public double? Date { get; set; }

        /// <summary>
        /// Value representing the day of a week. This can be one of:
        /// (1) integer value -- `1` represents Monday;
        /// (2) case-insensitive day name (e.g., `"Monday"`);
        /// (3) case-insensitive, 3-character short day name (e.g., `"Mon"`).
        ///
        /// **Warning:** A DateTime definition object with `day`** should not be combined with
        /// `year`, `quarter`, `month`, or `date`.
        /// </summary>
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public Day? Day { get; set; }

        /// <summary>
        /// Integer value representing the hour of a day from 0-23.
        /// </summary>
        [JsonProperty("hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; }

        /// <summary>
        /// Integer value representing the millisecond segment of time.
        /// </summary>
        [JsonProperty("milliseconds", NullValueHandling = NullValueHandling.Ignore)]
        public double? Milliseconds { get; set; }

        /// <summary>
        /// Integer value representing the minute segment of time from 0-59.
        /// </summary>
        [JsonProperty("minutes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minutes { get; set; }

        /// <summary>
        /// One of:
        /// (1) integer value representing the month from `1`-`12`. `1` represents January;
        /// (2) case-insensitive month name (e.g., `"January"`);
        /// (3) case-insensitive, 3-character short month name (e.g., `"Jan"`).
        /// </summary>
        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public Month? Month { get; set; }

        /// <summary>
        /// Integer value representing the quarter of the year (from 1-4).
        /// </summary>
        [JsonProperty("quarter", NullValueHandling = NullValueHandling.Ignore)]
        public double? Quarter { get; set; }

        /// <summary>
        /// Integer value representing the second segment (0-59) of a time value
        /// </summary>
        [JsonProperty("seconds", NullValueHandling = NullValueHandling.Ignore)]
        public double? Seconds { get; set; }

        /// <summary>
        /// A boolean flag indicating if date time is in utc time. If false, the date time is in
        /// local time
        /// </summary>
        [JsonProperty("utc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Utc { get; set; }

        /// <summary>
        /// Integer value representing the year.
        /// </summary>
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public double? Year { get; set; }
    }

    public partial class ValueLinearGradient
    {
        /// <summary>
        /// The type of gradient. Use `"linear"` for a linear gradient.
        ///
        /// The type of gradient. Use `"radial"` for a radial gradient.
        /// </summary>
        [JsonProperty("gradient", NullValueHandling = NullValueHandling.Ignore)]
        public Gradient Gradient { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// An array of gradient stops defining the gradient color sequence.
        /// </summary>
        [JsonProperty("stops", NullValueHandling = NullValueHandling.Ignore)]
        public List<GradientStop> Stops { get; set; }

        /// <summary>
        /// The starting x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x1", NullValueHandling = NullValueHandling.Ignore)]
        public double? X1 { get; set; }

        /// <summary>
        /// The ending x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `1`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public double? X2 { get; set; }

        /// <summary>
        /// The starting y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y1", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y1 { get; set; }

        /// <summary>
        /// The ending y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y2 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the inner circle for the
        /// gradient.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("r1", NullValueHandling = NullValueHandling.Ignore)]
        public double? R1 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the outer circle for the
        /// gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("r2", NullValueHandling = NullValueHandling.Ignore)]
        public double? R2 { get; set; }
    }

    public partial class GradientStop
    {
        /// <summary>
        /// The color value at this point in the gradient.
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// The offset fraction for the color stop, indicating its position within the gradient.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public double Offset { get; set; }
    }

    public partial class ConditionalPredicateValueDefGradientStringNullClass
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueUnion? Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }

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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
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
        public StandardType? Type { get; set; }
    }

    /// <summary>
    /// Reference to a repeated value.
    /// </summary>
    public partial class RepeatRef
    {
        [JsonProperty("repeat", NullValueHandling = NullValueHandling.Ignore)]
        public RepeatEnum Repeat { get; set; }
    }

    /// <summary>
    /// Properties of a legend or boolean flag for determining whether to show it.
    /// </summary>
    public partial class Legend
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
        /// The direction of the legend, one of `"vertical"` or `"horizontal"`.
        ///
        /// __Default value:__
        /// - For top-/bottom-`orient`ed legends, `"horizontal"`
        /// - For left-/right-`orient`ed legends, `"vertical"`
        /// - For top/bottom-left/right-`orient`ed legends, `"horizontal"` for gradient legends and
        /// `"vertical"` for symbol legends.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Direction { get; set; }

        /// <summary>
        /// Background fill color for the full legend.
        /// </summary>
        [JsonProperty("fillColor", NullValueHandling = NullValueHandling.Ignore)]
        public string FillColor { get; set; }

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
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the legend's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

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
        /// overlap reduction is attempted. If set to `true` (default) or `"parity"`, a strategy of
        /// removing every other label is used. If set to `"greedy"`, a linear scan of the labels is
        /// performed, removing any label that overlaps with the last visible label (this often works
        /// better for log-scaled axes).
        ///
        /// __Default value:__ `true`.
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
        /// scene. One of `"left"`, `"right"`, `"top"`, `"bottom"`, `"top-left"`, `"top-right"`,
        /// `"bottom-left"`, `"bottom-right"`, `"none"`.
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
        /// The minimum desired step between legend ticks, in terms of scale domain values. For
        /// example, a value of `1` indicates that ticks should not be less than 1 unit apart. If
        /// `tickMinStep` is specified, the `tickCount` value will be adjusted, if necessary, to
        /// enforce the minimum step value.
        ///
        /// __Default value__: `undefined`
        /// </summary>
        [JsonProperty("tickMinStep", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickMinStep { get; set; }

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
        /// The type of the legend. Use `"symbol"` to create a discrete legend and `"gradient"` for a
        /// continuous color gradient.
        ///
        /// __Default value:__ `"gradient"` for non-binned quantitative fields and temporal fields;
        /// `"symbol"` otherwise.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public LegendType? Type { get; set; }

        /// <summary>
        /// Explicitly set the visible legend values.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<Equal> Values { get; set; }

        /// <summary>
        /// A non-negative integer indicating the z-index of the legend.
        /// If zindex is 0, legend should be drawn behind all chart elements.
        /// To put them in front, use zindex = 1.
        /// </summary>
        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }

    public partial class Scale
    {
        /// <summary>
        /// The alignment of the steps within the scale range.
        ///
        /// This value must lie in the range `[0,1]`. A value of `0.5` indicates that the steps
        /// should be centered within the range. A value of `0` or `1` may be used to shift the bands
        /// to one side, say to position them adjacent to an axis.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public double? Align { get; set; }

        /// <summary>
        /// The logarithm base of the `log` scale (default `10`).
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public double? Base { get; set; }

        /// <summary>
        /// An array of bin boundaries over the scale domain. If provided, axes and legends will use
        /// the bin boundaries to inform the choice of tick marks and text labels.
        /// </summary>
        [JsonProperty("bins", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Bins { get; set; }

        /// <summary>
        /// If `true`, values that exceed the data domain are clamped to either the minimum or
        /// maximum range value
        ///
        /// __Default value:__ derived from the [scale
        /// config](https://vega.github.io/vega-lite/docs/config.html#scale-config)'s `clamp` (`true`
        /// by default).
        /// </summary>
        [JsonProperty("clamp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clamp { get; set; }

        /// <summary>
        /// A constant determining the slope of the symlog function around zero. Only used for
        /// `symlog` scales.
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("constant", NullValueHandling = NullValueHandling.Ignore)]
        public double? Constant { get; set; }

        /// <summary>
        /// Customized domain values.
        ///
        /// For _quantitative_ fields, `domain` can take the form of a two-element array with minimum
        /// and maximum values. [Piecewise
        /// scales](https://vega.github.io/vega-lite/docs/scale.html#piecewise) can be created by
        /// providing a `domain` with more than two entries.
        /// If the input field is aggregated, `domain` can also be a string value `"unaggregated"`,
        /// indicating that the domain should include the raw data values prior to the aggregation.
        ///
        /// For _temporal_ fields, `domain` can be a two-element array minimum and maximum values, in
        /// the form of either timestamps or the [DateTime definition
        /// objects](https://vega.github.io/vega-lite/docs/types.html#datetime).
        ///
        /// For _ordinal_ and _nominal_ fields, `domain` can be an array that lists valid input
        /// values.
        ///
        /// The `selection` property can be used to [interactively
        /// determine](https://vega.github.io/vega-lite/docs/selection.html#scale-domains) the scale
        /// domain.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public DomainUnion? Domain { get; set; }

        /// <summary>
        /// The exponent of the `pow` scale.
        /// </summary>
        [JsonProperty("exponent", NullValueHandling = NullValueHandling.Ignore)]
        public double? Exponent { get; set; }

        /// <summary>
        /// The interpolation method for range values. By default, a general interpolator for
        /// numbers, dates, strings and colors (in HCL space) is used. For color ranges, this
        /// property allows interpolation in alternative color spaces. Legal values include `rgb`,
        /// `hsl`, `hsl-long`, `lab`, `hcl`, `hcl-long`, `cubehelix` and `cubehelix-long` ('-long'
        /// variants use longer paths in polar coordinate spaces). If object-valued, this property
        /// accepts an object with a string-valued _type_ property and an optional numeric _gamma_
        /// property applicable to rgb and cubehelix interpolators. For more, see the [d3-interpolate
        /// documentation](https://github.com/d3/d3-interpolate).
        ///
        /// * __Default value:__ `hcl`
        /// </summary>
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public InterpolateUnion? Interpolate { get; set; }

        /// <summary>
        /// Extending the domain so that it starts and ends on nice round values. This method
        /// typically modifies the scale’s domain, and may only extend the bounds to the nearest
        /// round value. Nicing is useful if the domain is computed from data and may be irregular.
        /// For example, for a domain of _[0.201479…, 0.996679…]_, a nice domain might be _[0.2,
        /// 1.0]_.
        ///
        /// For quantitative scales such as linear, `nice` can be either a boolean flag or a number.
        /// If `nice` is a number, it will represent a desired tick count. This allows greater
        /// control over the step size used to extend the bounds, guaranteeing that the returned
        /// ticks will exactly cover the domain.
        ///
        /// For temporal fields with time and utc scales, the `nice` value can be a string indicating
        /// the desired time interval. Legal values are `"millisecond"`, `"second"`, `"minute"`,
        /// `"hour"`, `"day"`, `"week"`, `"month"`, and `"year"`. Alternatively, `time` and `utc`
        /// scales can accept an object-valued interval specifier of the form `{"interval": "month",
        /// "step": 3}`, which includes a desired number of interval steps. Here, the domain would
        /// snap to quarter (Jan, Apr, Jul, Oct) boundaries.
        ///
        /// __Default value:__ `true` for unbinned _quantitative_ fields; `false` otherwise.
        /// </summary>
        [JsonProperty("nice", NullValueHandling = NullValueHandling.Ignore)]
        public NiceUnion? Nice { get; set; }

        /// <summary>
        /// For _[continuous](https://vega.github.io/vega-lite/docs/scale.html#continuous)_ scales,
        /// expands the scale domain to accommodate the specified number of pixels on each of the
        /// scale range. The scale range must represent pixels for this parameter to function as
        /// intended. Padding adjustment is performed prior to all other adjustments, including the
        /// effects of the `zero`, `nice`, `domainMin`, and `domainMax` properties.
        ///
        /// For _[band](https://vega.github.io/vega-lite/docs/scale.html#band)_ scales, shortcut for
        /// setting `paddingInner` and `paddingOuter` to the same value.
        ///
        /// For _[point](https://vega.github.io/vega-lite/docs/scale.html#point)_ scales, alias for
        /// `paddingOuter`.
        ///
        /// __Default value:__ For _continuous_ scales, derived from the [scale
        /// config](https://vega.github.io/vega-lite/docs/scale.html#config)'s `continuousPadding`.
        /// For _band and point_ scales, see `paddingInner` and `paddingOuter`. By default, Vega-Lite
        /// sets padding such that _width/height = number of unique values * step_.
        /// </summary>
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public double? Padding { get; set; }

        /// <summary>
        /// The inner padding (spacing) within each band step of band scales, as a fraction of the
        /// step size. This value must lie in the range [0,1].
        ///
        /// For point scale, this property is invalid as point scales do not have internal band
        /// widths (only step sizes between bands).
        ///
        /// __Default value:__ derived from the [scale
        /// config](https://vega.github.io/vega-lite/docs/scale.html#config)'s `bandPaddingInner`.
        /// </summary>
        [JsonProperty("paddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? PaddingInner { get; set; }

        /// <summary>
        /// The outer padding (spacing) at the ends of the range of band and point scales,
        /// as a fraction of the step size. This value must lie in the range [0,1].
        ///
        /// __Default value:__ derived from the [scale
        /// config](https://vega.github.io/vega-lite/docs/scale.html#config)'s `bandPaddingOuter` for
        /// band scales and `pointPadding` for point scales.
        /// By default, Vega-Lite sets outer padding such that _width/height = number of unique
        /// values * step_.
        /// </summary>
        [JsonProperty("paddingOuter", NullValueHandling = NullValueHandling.Ignore)]
        public double? PaddingOuter { get; set; }

        /// <summary>
        /// The range of the scale. One of:
        ///
        /// - A string indicating a [pre-defined named scale
        /// range](https://vega.github.io/vega-lite/docs/scale.html#range-config) (e.g., example,
        /// `"symbol"`, or `"diverging"`).
        ///
        /// - For [continuous scales](https://vega.github.io/vega-lite/docs/scale.html#continuous),
        /// two-element array indicating  minimum and maximum values, or an array with more than two
        /// entries for specifying a [piecewise
        /// scale](https://vega.github.io/vega-lite/docs/scale.html#piecewise).
        ///
        /// - For [discrete](https://vega.github.io/vega-lite/docs/scale.html#discrete) and
        /// [discretizing](https://vega.github.io/vega-lite/docs/scale.html#discretizing) scales, an
        /// array of desired output values.
        ///
        /// __Notes:__
        ///
        /// 1) For color scales you can also specify a color
        /// [`scheme`](https://vega.github.io/vega-lite/docs/scale.html#scheme) instead of `range`.
        ///
        /// 2) Any directly specified `range` for `x` and `y` channels will be ignored. Range can be
        /// customized via the view's corresponding
        /// [size](https://vega.github.io/vega-lite/docs/size.html) (`width` and `height`).
        /// </summary>
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleRange? Range { get; set; }

        /// <summary>
        /// If `true`, rounds numeric output values to integers. This can be helpful for snapping to
        /// the pixel grid.
        ///
        /// __Default value:__ `false`.
        /// </summary>
        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Round { get; set; }

        /// <summary>
        /// A string indicating a color
        /// [scheme](https://vega.github.io/vega-lite/docs/scale.html#scheme) name (e.g.,
        /// `"category10"` or `"blues"`) or a [scheme parameter
        /// object](https://vega.github.io/vega-lite/docs/scale.html#scheme-params).
        ///
        /// Discrete color schemes may be used with
        /// [discrete](https://vega.github.io/vega-lite/docs/scale.html#discrete) or
        /// [discretizing](https://vega.github.io/vega-lite/docs/scale.html#discretizing) scales.
        /// Continuous color schemes are intended for use with color scales.
        ///
        /// For the full list of supported schemes, please refer to the [Vega
        /// Scheme](https://vega.github.io/vega/docs/schemes/#reference) reference.
        /// </summary>
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Scheme? Scheme { get; set; }

        /// <summary>
        /// The type of scale. Vega-Lite supports the following categories of scale types:
        ///
        /// 1) [**Continuous Scales**](https://vega.github.io/vega-lite/docs/scale.html#continuous)
        /// -- mapping continuous domains to continuous output ranges
        /// ([`"linear"`](https://vega.github.io/vega-lite/docs/scale.html#linear),
        /// [`"pow"`](https://vega.github.io/vega-lite/docs/scale.html#pow),
        /// [`"sqrt"`](https://vega.github.io/vega-lite/docs/scale.html#sqrt),
        /// [`"symlog"`](https://vega.github.io/vega-lite/docs/scale.html#symlog),
        /// [`"log"`](https://vega.github.io/vega-lite/docs/scale.html#log),
        /// [`"time"`](https://vega.github.io/vega-lite/docs/scale.html#time),
        /// [`"utc"`](https://vega.github.io/vega-lite/docs/scale.html#utc).
        ///
        /// 2) [**Discrete Scales**](https://vega.github.io/vega-lite/docs/scale.html#discrete) --
        /// mapping discrete domains to discrete
        /// ([`"ordinal"`](https://vega.github.io/vega-lite/docs/scale.html#ordinal)) or continuous
        /// ([`"band"`](https://vega.github.io/vega-lite/docs/scale.html#band) and
        /// [`"point"`](https://vega.github.io/vega-lite/docs/scale.html#point)) output ranges.
        ///
        /// 3) [**Discretizing
        /// Scales**](https://vega.github.io/vega-lite/docs/scale.html#discretizing) -- mapping
        /// continuous domains to discrete output ranges
        /// [`"bin-ordinal"`](https://vega.github.io/vega-lite/docs/scale.html#bin-ordinal),
        /// [`"quantile"`](https://vega.github.io/vega-lite/docs/scale.html#quantile),
        /// [`"quantize"`](https://vega.github.io/vega-lite/docs/scale.html#quantize) and
        /// [`"threshold"`](https://vega.github.io/vega-lite/docs/scale.html#threshold).
        ///
        /// __Default value:__ please see the [scale type
        /// table](https://vega.github.io/vega-lite/docs/scale.html#type).
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleType? Type { get; set; }

        /// <summary>
        /// If `true`, ensures that a zero baseline value is included in the scale domain.
        ///
        /// __Default value:__ `true` for x and y channels if the quantitative field is not binned
        /// and no custom `domain` is provided; `false` otherwise.
        ///
        /// __Note:__ Log, time, and utc scales do not support `zero`.
        /// </summary>
        [JsonProperty("zero", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Zero { get; set; }
    }

    public partial class DomainClass
    {
        /// <summary>
        /// The field name to extract selected values for, when a selection is
        /// [projected](https://vega.github.io/vega-lite/docs/project.html)
        /// over multiple fields or encodings.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The name of a selection.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public string Selection { get; set; }

        /// <summary>
        /// The encoding channel to extract selected values for, when a selection is
        /// [projected](https://vega.github.io/vega-lite/docs/project.html)
        /// over multiple fields or encodings.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public SingleDefUnitChannel? Encoding { get; set; }
    }

    public partial class ScaleInterpolateParams
    {
        [JsonProperty("gamma", NullValueHandling = NullValueHandling.Ignore)]
        public double? Gamma { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleInterpolateParamsType Type { get; set; }
    }

    public partial class NiceClass
    {
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public string Interval { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double Step { get; set; }
    }

    public partial class SchemeParams
    {
        /// <summary>
        /// The number of colors to use in the scheme. This can be useful for scale types such as
        /// `"quantize"`, which use the length of the scale range to determine the number of discrete
        /// bins for the scale domain.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        /// <summary>
        /// The extent of the color range to use. For example `[0.2, 1]` will rescale the color
        /// scheme such that color values in the range _[0, 0.2)_ are excluded from the scheme.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Extent { get; set; }

        /// <summary>
        /// A color scheme name for ordinal scales (e.g., `"category10"` or `"blues"`).
        ///
        /// For the full list of supported schemes, please refer to the [Vega
        /// Scheme](https://vega.github.io/vega/docs/schemes/#reference) reference.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    /// <summary>
    /// A sort definition for sorting a discrete scale in an encoding field definition.
    /// </summary>
    public partial class EncodingSortField
    {
        /// <summary>
        /// The data [field](https://vega.github.io/vega-lite/docs/field.html) to sort by.
        ///
        /// __Default value:__ If unspecified, defaults to the field specified in the outer data
        /// reference.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public Field? Field { get; set; }

        /// <summary>
        /// An [aggregate operation](https://vega.github.io/vega-lite/docs/aggregate.html#ops) to
        /// perform on the field prior to sorting (e.g., `"count"`, `"mean"` and `"median"`).
        /// An aggregation is required when there are multiple values of the sort field for each
        /// encoded data field.
        /// The input data objects will be aggregated, grouped by the encoded data field.
        ///
        /// For a full list of operations, please see the documentation for
        /// [aggregate](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
        ///
        /// __Default value:__ `"sum"` for stacked plots. Otherwise, `"mean"`.
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public NonArgAggregateOp? Op { get; set; }

        /// <summary>
        /// The sort order. One of `"ascending"` (default), `"descending"`, or `null` (no not sort).
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Order { get; set; }

        /// <summary>
        /// The [encoding channel](https://vega.github.io/vega-lite/docs/encoding.html#channels) to
        /// sort by (e.g., `"x"`, `"y"`)
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public SortByChannel? Encoding { get; set; }
    }

    /// <summary>
    /// A field definition for the horizontal facet of trellis plots.
    ///
    /// A field definition for the vertical facet of trellis plots.
    /// </summary>
    public partial class RowColumnEncodingFieldDef
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
        /// The alignment to apply to row/column facet's subplot.
        /// The supported string values are `"all"`, `"each"`, and `"none"`.
        ///
        /// - For `"none"`, a flow layout will be used, in which adjacent subviews are simply placed
        /// one after the other.
        /// - For `"each"`, subviews will be aligned into a clean grid structure, but each row or
        /// column may be of variable size.
        /// - For `"all"`, subviews will be aligned and each row or column will be sized identically
        /// based on the maximum observed size. String values for this property will be applied to
        /// both grid rows and columns.
        ///
        /// __Default value:__ `"all"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutAlign? Align { get; set; }

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
        public PurpleBin? Bin { get; set; }

        /// <summary>
        /// Boolean flag indicating if facet's subviews should be centered relative to their
        /// respective rows or columns.
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Center { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining properties of a facet's header.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Header Header { get; set; }

        /// <summary>
        /// Sort order for the encoded field.
        ///
        /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
        /// `"descending"`.
        ///
        /// For discrete fields, `sort` can be one of the following:
        /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
        /// JavaScript.
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
        /// __Note:__ `null` is not supported for `row` and `column`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortArray? Sort { get; set; }

        /// <summary>
        /// The spacing in pixels between facet's sub-views.
        ///
        /// __Default value__: Depends on `"spacing"` property of [the view composition
        /// configuration](https://vega.github.io/vega-lite/docs/config.html#view-config) (`20` by
        /// default)
        /// </summary>
        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? Spacing { get; set; }

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
        public StandardType Type { get; set; }
    }

    /// <summary>
    /// An object defining properties of a facet's header.
    ///
    /// Headers of row / column channels for faceted plots.
    /// </summary>
    public partial class Header
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

    /// <summary>
    /// A sort definition for sorting a discrete scale in an encoding field definition.
    /// </summary>
    public partial class SortEncodingSortField
    {
        /// <summary>
        /// The data [field](https://vega.github.io/vega-lite/docs/field.html) to sort by.
        ///
        /// __Default value:__ If unspecified, defaults to the field specified in the outer data
        /// reference.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public Field? Field { get; set; }

        /// <summary>
        /// An [aggregate operation](https://vega.github.io/vega-lite/docs/aggregate.html#ops) to
        /// perform on the field prior to sorting (e.g., `"count"`, `"mean"` and `"median"`).
        /// An aggregation is required when there are multiple values of the sort field for each
        /// encoded data field.
        /// The input data objects will be aggregated, grouped by the encoded data field.
        ///
        /// For a full list of operations, please see the documentation for
        /// [aggregate](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
        ///
        /// __Default value:__ `"sum"` for stacked plots. Otherwise, `"mean"`.
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public NonArgAggregateOp? Op { get; set; }

        /// <summary>
        /// The sort order. One of `"ascending"` (default), `"descending"`, or `null` (no not sort).
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Order { get; set; }
    }

    /// <summary>
    /// Field Def without scale (and without bin: "binned" support).
    ///
    /// Definition object for a data field, its type and transformation of an encoding channel.
    ///
    /// A data field to use as a unique key for data binding. When a visualization’s data is
    /// updated, the key value will be used to match data elements to existing mark instances.
    /// Use a key channel to enable object constancy for transitions over dynamic data.
    /// </summary>
    public partial class TypedFieldDef
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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        public StandardType Type { get; set; }
    }

    /// <summary>
    /// A field definition for the (flexible) facet of trellis plots.
    ///
    /// If either `row` or `column` is specified, this channel will be ignored.
    /// </summary>
    public partial class FacetEncodingFieldDef
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
        /// The alignment to apply to grid rows and columns.
        /// The supported string values are `"all"`, `"each"`, and `"none"`.
        ///
        /// - For `"none"`, a flow layout will be used, in which adjacent subviews are simply placed
        /// one after the other.
        /// - For `"each"`, subviews will be aligned into a clean grid structure, but each row or
        /// column may be of variable size.
        /// - For `"all"`, subviews will be aligned and each row or column will be sized identically
        /// based on the maximum observed size. String values for this property will be applied to
        /// both grid rows and columns.
        ///
        /// Alternatively, an object value of the form `{"row": string, "column": string}` can be
        /// used to supply different alignments for rows and columns.
        ///
        /// __Default value:__ `"all"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public AlignUnion? Align { get; set; }

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
        public PurpleBin? Bin { get; set; }

        /// <summary>
        /// The bounds calculation method to use for determining the extent of a sub-plot. One of
        /// `full` (the default) or `flush`.
        ///
        /// - If set to `full`, the entire calculated bounds (including axes, title, and legend) will
        /// be used.
        /// - If set to `flush`, only the specified width and height values for the sub-view will be
        /// used. The `flush` setting can be useful when attempting to place sub-plots without axes
        /// or legends into a uniform grid structure.
        ///
        /// __Default value:__ `"full"`
        /// </summary>
        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        public BoundsEnum? Bounds { get; set; }

        /// <summary>
        /// Boolean flag indicating if subviews should be centered relative to their respective rows
        /// or columns.
        ///
        /// An object value of the form `{"row": boolean, "column": boolean}` can be used to supply
        /// different centering values for rows and columns.
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public SpecificationCenter? Center { get; set; }

        /// <summary>
        /// The number of columns to include in the view composition layout.
        ///
        /// __Default value__: `undefined` -- An infinite number of columns (a single row) will be
        /// assumed. This is equivalent to
        /// `hconcat` (for `concat`) and to using the `column` channel (for `facet` and `repeat`).
        ///
        /// __Note__:
        ///
        /// 1) This property is only for:
        /// - the general (wrappable) `concat` operator (not `hconcat`/`vconcat`)
        /// - the `facet` and `repeat` operator with one field/repetition definition (without
        /// row/column nesting)
        ///
        /// 2) Setting the `columns` to `1` is equivalent to `vconcat` (for `concat`) and to using
        /// the `row` channel (for `facet` and `repeat`).
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public double? Columns { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining properties of a facet's header.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Header Header { get; set; }

        /// <summary>
        /// Sort order for the encoded field.
        ///
        /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
        /// `"descending"`.
        ///
        /// For discrete fields, `sort` can be one of the following:
        /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
        /// JavaScript.
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
        /// __Note:__ `null` is not supported for `row` and `column`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortArray? Sort { get; set; }

        /// <summary>
        /// The spacing in pixels between sub-views of the composition operator.
        /// An object of the form `{"row": number, "column": number}` can be used to set
        /// different spacing values for rows and columns.
        ///
        /// __Default value__: Depends on `"spacing"` property of [the view composition
        /// configuration](https://vega.github.io/vega-lite/docs/config.html#view-config) (`20` by
        /// default)
        /// </summary>
        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public Spacing? Spacing { get; set; }

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
        public StandardType Type { get; set; }
    }

    public partial class RowColNumber
    {
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public double? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public double? Row { get; set; }
    }

    /// <summary>
    /// Fill opacity of the marks.
    ///
    /// __Default value:__ If undefined, the default opacity depends on [mark
    /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `fillOpacity`
    /// property.
    ///
    /// Opacity of the marks.
    ///
    /// __Default value:__ If undefined, the default opacity depends on [mark
    /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `opacity` property.
    ///
    /// Size of the mark.
    /// - For `"point"`, `"square"` and `"circle"`, – the symbol size, or pixel area of the mark.
    /// - For `"bar"` and `"tick"` – the bar and tick's size.
    /// - For `"text"` – the text's font size.
    /// - Size is unsupported for `"line"`, `"area"`, and `"rect"`. (Use `"trail"` instead of
    /// line with varying size)
    ///
    /// Stroke opacity of the marks.
    ///
    /// __Default value:__ If undefined, the default opacity depends on [mark
    /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeOpacity`
    /// property.
    ///
    /// Stroke width of the marks.
    ///
    /// __Default value:__ If undefined, the default stroke width depends on [mark
    /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeWidth`
    /// property.
    ///
    /// A FieldDef with Condition<ValueDef>
    /// {
    /// condition: {value: ...},
    /// field: ...,
    /// ...
    /// }
    /// </summary>
    public partial class DefWithConditionMarkPropFieldDefNumber
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
        public PurpleBin? Bin { get; set; }

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
        public ConditionUnion? Condition { get; set; }

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
        [JsonProperty("field")]
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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    public partial class ConditionalNumberValueDef
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }

    public partial class ConditionalDef
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }

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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
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
        public StandardType? Type { get; set; }
    }

    /// <summary>
    /// A URL to load upon mouse click.
    ///
    /// The URL of an image mark.
    ///
    /// A FieldDef with Condition<ValueDef>
    /// {
    /// condition: {value: ...},
    /// field: ...,
    /// ...
    /// }
    /// </summary>
    public partial class HrefClass
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
        public FluffyBin? Bin { get; set; }

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
        public HrefCondition? Condition { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels
        /// text.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionElement
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }

    public partial class ConditionalPredicateValueDefStringClass
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }

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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
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
        public StandardType? Type { get; set; }
    }

    /// <summary>
    /// Latitude position of geographically projected marks.
    ///
    /// Longitude position of geographically projected marks.
    ///
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class LatitudeClass
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
        public object Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        public LatitudeType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    /// <summary>
    /// Latitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`, and
    /// `"rule"`.
    ///
    /// Longitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`,
    /// and  `"rule"`.
    ///
    /// Error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
    ///
    /// Secondary error value of x coordinates for error specified `"errorbar"` and
    /// `"errorband"`.
    ///
    /// Error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
    ///
    /// Secondary error value of y coordinates for error specified `"errorbar"` and
    /// `"errorband"`.
    ///
    /// A field definition of a secondary channel that shares a scale with another primary
    /// channel. For example, `x2`, `xError` and `xError2` share the same scale with `x`.
    ///
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class Latitude2Class
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
        public object Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    public partial class OrderFieldDef
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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// The sort order. One of `"ascending"` (default) or `"descending"`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Sort { get; set; }

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
        public StandardType Type { get; set; }
    }

    /// <summary>
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class OrderFieldDefClass
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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// The sort order. One of `"ascending"` (default) or `"descending"`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Sort { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

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
    public partial class DefWithConditionMarkPropFieldDefTypeForShapeStringNull
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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
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

    public partial class ConditionalStringValueDef
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }

    public partial class ConditionalPredicateMarkPropFieldDefTypeForShapeClass
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }

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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
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
    }

    /// <summary>
    /// Text of the `text` mark.
    ///
    /// A FieldDef with Condition<ValueDef>
    /// {
    /// condition: {value: ...},
    /// field: ...,
    /// ...
    /// }
    /// </summary>
    public partial class DefWithConditionStringFieldDefText
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
        public FluffyBin? Bin { get; set; }

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
        public TextCondition? Condition { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels
        /// text.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Value { get; set; }
    }

    public partial class ConditionalValueDefText
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Text Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }
    }

    public partial class ConditionalPredicateValueDefTextClass
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Value { get; set; }

        /// <summary>
        /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
        /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Selection { get; set; }

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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels
        /// text.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

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
        public StandardType? Type { get; set; }
    }

    public partial class StringFieldDef
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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels
        /// text.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

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
        public StandardType Type { get; set; }
    }

    /// <summary>
    /// A FieldDef with Condition<ValueDef>
    /// {
    /// condition: {value: ...},
    /// field: ...,
    /// ...
    /// }
    /// </summary>
    public partial class FieldDefWithConditionStringFieldDefString
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
        public FluffyBin? Bin { get; set; }

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
        public HrefCondition? Condition { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels
        /// text.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelExpr { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    /// <summary>
    /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
    /// `x2` or `width`.
    ///
    /// The `value` of this channel can be a number or a string `"width"` for the width of the
    /// plot.
    ///
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class XClass
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
        /// An object defining properties of axis's gridlines, ticks and labels.
        /// If `null`, the axis for the encoding channel will be removed.
        ///
        /// __Default value:__ If undefined, default [axis
        /// properties](https://vega.github.io/vega-lite/docs/axis.html) are applied.
        ///
        /// __See also:__ [`axis`](https://vega.github.io/vega-lite/docs/axis.html) documentation.
        /// </summary>
        [JsonProperty("axis", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Axis { get; set; }

        /// <summary>
        /// For rect-based marks (`rect`, `bar`, and `image`), mark size relative to bandwidth of
        /// [band scales](https://vega.github.io/vega-lite/docs/scale.html#band) or time units. If
        /// set to `1`, the mark size is set to the bandwidth or the time unit interval. If set to
        /// `0.5`, the mark size is half of the bandwidth or the time unit interval.
        ///
        /// For other marks, relative position on a band of a stacked, binned, time unit or band
        /// scale. If set to `0`, the marks will be positioned at the beginning of the band. If set
        /// to `0.5`, the marks will be positioned in the middle of the band.
        /// </summary>
        [JsonProperty("band", NullValueHandling = NullValueHandling.Ignore)]
        public double? Band { get; set; }

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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining the properties of the Impute Operation to be applied.
        /// The field value of the other positional channel is taken as `key` of the `Impute`
        /// Operation.
        /// The field of the `color` channel if specified is used as `groupby` of the `Impute`
        /// Operation.
        ///
        /// __See also:__ [`impute`](https://vega.github.io/vega-lite/docs/impute.html) documentation.
        /// </summary>
        [JsonProperty("impute", NullValueHandling = NullValueHandling.Ignore)]
        public ImputeParams Impute { get; set; }

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
        /// Type of stacking offset if the field should be stacked.
        /// `stack` is only applicable for `x` and `y` channels with continuous domains.
        /// For example, `stack` of `y` can be used to customize stacking for a vertical bar chart.
        ///
        /// `stack` can be one of the following values:
        /// - `"zero"` or `true`: stacking with baseline offset at zero value of the scale (for
        /// creating typical stacked [bar](https://vega.github.io/vega-lite/docs/stack.html#bar) and
        /// [area](https://vega.github.io/vega-lite/docs/stack.html#area) chart).
        /// - `"normalize"` - stacking with normalized domain (for creating [normalized stacked bar
        /// and area charts](https://vega.github.io/vega-lite/docs/stack.html#normalized). <br/>
        /// -`"center"` - stacking with center baseline (for
        /// [streamgraph](https://vega.github.io/vega-lite/docs/stack.html#streamgraph)).
        /// - `null` or `false` - No-stacking. This will produce layered
        /// [bar](https://vega.github.io/vega-lite/docs/stack.html#layered-bar-chart) and area
        /// chart.
        ///
        /// __Default value:__ `zero` for plots with all of the following conditions are true:
        /// (1) the mark is `bar` or `area`;
        /// (2) the stacked measure channel (x or y) has a linear scale;
        /// (3) At least one of non-position channels mapped to an unaggregated field that is
        /// different from x and y. Otherwise, `null` by default.
        ///
        /// __See also:__ [`stack`](https://vega.github.io/vega-lite/docs/stack.html) documentation.
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public Stack? Stack { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? Value { get; set; }
    }

    public partial class Axis
    {
        /// <summary>
        /// An interpolation fraction indicating where, for `band` scales, axis ticks should be
        /// positioned. A value of `0` places ticks at the left edge of their bands. A value of `0.5`
        /// places ticks in the middle of their bands.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("bandPosition", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPosition { get; set; }

        /// <summary>
        /// A boolean flag indicating if the domain (the axis baseline) should be included as part of
        /// the axis.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domain { get; set; }

        /// <summary>
        /// Color of axis domain line.
        ///
        /// __Default value:__ `"gray"`.
        /// </summary>
        [JsonProperty("domainColor", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainColor { get; set; }

        /// <summary>
        /// An array of alternating [stroke, space] lengths for dashed domain lines.
        /// </summary>
        [JsonProperty("domainDash", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DomainDash { get; set; }

        /// <summary>
        /// The pixel offset at which to start drawing with the domain dash array.
        /// </summary>
        [JsonProperty("domainDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainDashOffset { get; set; }

        /// <summary>
        /// Opacity of the axis domain line.
        /// </summary>
        [JsonProperty("domainOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainOpacity { get; set; }

        /// <summary>
        /// Stroke width of axis domain line
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("domainWidth", NullValueHandling = NullValueHandling.Ignore)]
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
        /// A boolean flag indicating if grid lines should be included as part of the axis
        ///
        /// __Default value:__ `true` for [continuous
        /// scales](https://vega.github.io/vega-lite/docs/scale.html#continuous) that are not binned;
        /// otherwise, `false`.
        /// </summary>
        [JsonProperty("grid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Grid { get; set; }

        [JsonProperty("gridColor", NullValueHandling = NullValueHandling.Ignore)]
        public Color? GridColor { get; set; }

        [JsonProperty("gridDash", NullValueHandling = NullValueHandling.Ignore)]
        public Dash? GridDash { get; set; }

        [JsonProperty("gridDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? GridDashOffset { get; set; }

        [JsonProperty("gridOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public GridOpacity? GridOpacity { get; set; }

        [JsonProperty("gridWidth", NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? GridWidth { get; set; }

        [JsonProperty("labelAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlign? LabelAlign { get; set; }

        /// <summary>
        /// The rotation angle of the axis labels.
        ///
        /// __Default value:__ `-90` for nominal and ordinal fields; `0` otherwise.
        /// </summary>
        [JsonProperty("labelAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelAngle { get; set; }

        [JsonProperty("labelBaseline", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("labelBound", NullValueHandling = NullValueHandling.Ignore)]
        public Label? LabelBound { get; set; }

        [JsonProperty("labelColor", NullValueHandling = NullValueHandling.Ignore)]
        public Color? LabelColor { get; set; }

        /// <summary>
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/) for customizing labels.
        ///
        /// __Note:__ The label text and value can be assessed via the `label` and `value` properties
        /// of the axis's backing `datum` object.
        /// </summary>
        [JsonProperty("labelExpr", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("labelFlush", NullValueHandling = NullValueHandling.Ignore)]
        public Label? LabelFlush { get; set; }

        /// <summary>
        /// Indicates the number of pixels by which to offset flush-adjusted labels. For example, a
        /// value of `2` will push flush-adjusted labels 2 pixels outward from the center of the
        /// axis. Offsets can help the labels better visually group with corresponding axis ticks.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("labelFlushOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelFlushOffset { get; set; }

        [JsonProperty("labelFont", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? LabelFont { get; set; }

        [JsonProperty("labelFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? LabelFontSize { get; set; }

        [JsonProperty("labelFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFontStyle? LabelFontStyle { get; set; }

        [JsonProperty("labelFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFontWeightUnion? LabelFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of axis tick labels.
        ///
        /// __Default value:__ `180`
        /// </summary>
        [JsonProperty("labelLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelLimit { get; set; }

        [JsonProperty("labelOpacity", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("labelOverlap", NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlap? LabelOverlap { get; set; }

        /// <summary>
        /// The padding, in pixels, between axis and text labels.
        ///
        /// __Default value:__ `2`
        /// </summary>
        [JsonProperty("labelPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelPadding { get; set; }

        /// <summary>
        /// A boolean flag indicating if labels should be included as part of the axis.
        ///
        /// __Default value:__ `true`.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Labels { get; set; }

        /// <summary>
        /// The minimum separation that must be between label bounding boxes for them to be
        /// considered non-overlapping (default `0`). This property is ignored if *labelOverlap*
        /// resolution is not enabled.
        /// </summary>
        [JsonProperty("labelSeparation", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelSeparation { get; set; }

        /// <summary>
        /// The maximum extent in pixels that axis ticks and labels should use. This determines a
        /// maximum offset value for axis titles.
        ///
        /// __Default value:__ `undefined`.
        /// </summary>
        [JsonProperty("maxExtent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxExtent { get; set; }

        /// <summary>
        /// The minimum extent in pixels that axis ticks and labels should use. This determines a
        /// minimum offset value for axis titles.
        ///
        /// __Default value:__ `30` for y-axis; `undefined` for x-axis.
        /// </summary>
        [JsonProperty("minExtent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinExtent { get; set; }

        /// <summary>
        /// The offset, in pixels, by which to displace the axis from the edge of the enclosing group
        /// or data rectangle.
        ///
        /// __Default value:__ derived from the [axis
        /// config](https://vega.github.io/vega-lite/docs/config.html#facet-scale-config)'s `offset`
        /// (`0` by default)
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        /// <summary>
        /// The orientation of the axis. One of `"top"`, `"bottom"`, `"left"` or `"right"`. The
        /// orientation can be used to further specialize the axis type (e.g., a y-axis oriented
        /// towards the right edge of the chart).
        ///
        /// __Default value:__ `"bottom"` for x-axes and `"left"` for y-axes.
        /// </summary>
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orient? Orient { get; set; }

        /// <summary>
        /// The anchor position of the axis in pixels. For x-axes with top or bottom orientation,
        /// this sets the axis group x coordinate. For y-axes with left or right orientation, this
        /// sets the axis group y coordinate.
        ///
        /// __Default value__: `0`
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public double? Position { get; set; }

        /// <summary>
        /// For band scales, indicates if ticks and grid lines should be placed at the center of a
        /// band (default) or at the band extents to indicate intervals.
        /// </summary>
        [JsonProperty("tickBand", NullValueHandling = NullValueHandling.Ignore)]
        public TickBand? TickBand { get; set; }

        [JsonProperty("tickColor", NullValueHandling = NullValueHandling.Ignore)]
        public Color? TickColor { get; set; }

        /// <summary>
        /// A desired number of ticks, for axes visualizing quantitative scales. The resulting number
        /// may be different so that values are "nice" (multiples of 2, 5, 10) and lie within the
        /// underlying scale's range.
        ///
        /// __Default value__: Determine using a formula `ceil(width/40)` for x and `ceil(height/40)`
        /// for y.
        /// </summary>
        [JsonProperty("tickCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickCount { get; set; }

        [JsonProperty("tickDash", NullValueHandling = NullValueHandling.Ignore)]
        public Dash? TickDash { get; set; }

        [JsonProperty("tickDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? TickDashOffset { get; set; }

        /// <summary>
        /// Boolean flag indicating if an extra axis tick should be added for the initial position of
        /// the axis. This flag is useful for styling axes for `band` scales such that ticks are
        /// placed on band boundaries rather in the middle of a band. Use in conjunction with
        /// `"bandPosition": 1` and an axis `"padding"` value of `0`.
        /// </summary>
        [JsonProperty("tickExtra", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TickExtra { get; set; }

        /// <summary>
        /// The minimum desired step between axis ticks, in terms of scale domain values. For
        /// example, a value of `1` indicates that ticks should not be less than 1 unit apart. If
        /// `tickMinStep` is specified, the `tickCount` value will be adjusted, if necessary, to
        /// enforce the minimum step value.
        ///
        /// __Default value__: `undefined`
        /// </summary>
        [JsonProperty("tickMinStep", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickMinStep { get; set; }

        /// <summary>
        /// Position offset in pixels to apply to ticks, labels, and gridlines.
        /// </summary>
        [JsonProperty("tickOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickOffset { get; set; }

        [JsonProperty("tickOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? TickOpacity { get; set; }

        /// <summary>
        /// Boolean flag indicating if pixel position values should be rounded to the nearest
        /// integer.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("tickRound", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TickRound { get; set; }

        /// <summary>
        /// Boolean value that determines whether the axis should include ticks.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticks { get; set; }

        /// <summary>
        /// The size in pixels of axis ticks.
        ///
        /// __Default value:__ `5`
        /// </summary>
        [JsonProperty("tickSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickSize { get; set; }

        [JsonProperty("tickWidth", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleText? Title { get; set; }

        /// <summary>
        /// Horizontal text alignment of axis titles.
        /// </summary>
        [JsonProperty("titleAlign", NullValueHandling = NullValueHandling.Ignore)]
        public Align? TitleAlign { get; set; }

        /// <summary>
        /// Text anchor position for placing axis titles.
        /// </summary>
        [JsonProperty("titleAnchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? TitleAnchor { get; set; }

        /// <summary>
        /// Angle in degrees of axis titles.
        /// </summary>
        [JsonProperty("titleAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleAngle { get; set; }

        /// <summary>
        /// Vertical text baseline for axis titles.
        /// </summary>
        [JsonProperty("titleBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? TitleBaseline { get; set; }

        /// <summary>
        /// Color of the title, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("titleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleColor { get; set; }

        /// <summary>
        /// Font of the title. (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("titleFont", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFont { get; set; }

        /// <summary>
        /// Font size of the title.
        /// </summary>
        [JsonProperty("titleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// Font style of the title.
        /// </summary>
        [JsonProperty("titleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Font weight of the title.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("titleFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? TitleFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of axis titles.
        /// </summary>
        [JsonProperty("titleLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLimit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("titleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLineHeight { get; set; }

        /// <summary>
        /// Opacity of the axis title.
        /// </summary>
        [JsonProperty("titleOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleOpacity { get; set; }

        /// <summary>
        /// The padding, in pixels, between title and axis.
        /// </summary>
        [JsonProperty("titlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitlePadding { get; set; }

        /// <summary>
        /// X-coordinate of the axis title relative to the axis group.
        /// </summary>
        [JsonProperty("titleX", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleX { get; set; }

        /// <summary>
        /// Y-coordinate of the axis title relative to the axis group.
        /// </summary>
        [JsonProperty("titleY", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleY { get; set; }

        /// <summary>
        /// Translation offset in pixels applied to the axis group mark x and y. If specified,
        /// overrides the default behavior of a 0.5 offset to pixel-align stroked lines.
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public double? Translate { get; set; }

        /// <summary>
        /// Explicitly set the visible axis tick values.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<Equal> Values { get; set; }

        /// <summary>
        /// A non-negative integer indicating the z-index of the axis.
        /// If zindex is 0, axes should be drawn behind all chart elements.
        /// To put them in front, set `zindex` to `1` or more.
        ///
        /// __Default value:__ `0` (behind the marks).
        /// </summary>
        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }

    public partial class ConditionalAxisPropertyColorNull
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyColorNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionalPredicateValueDefColorNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionalAxisPropertyNumberNull
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyNumberNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Value { get; set; }
    }

    public partial class ConditionalPredicateValueDefNumberNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Value { get; set; }
    }

    public partial class ConditionalAxisPropertyNumberNullClass
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyNumberNullConditionUnion Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    public partial class ConditionalPredicateValueDefNumberNullElement
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    public partial class ConditionalAxisPropertyTextBaselineNull
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyTextBaselineNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Value { get; set; }
    }

    public partial class ConditionalPredicateValueDefTextBaselineNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Value { get; set; }
    }

    public partial class ConditionalAxisPropertyStringNull
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyStringNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionalPredicateStringValueDef
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionalAxisPropertyFontStyleNull
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyFontStyleNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionalPredicateValueDefFontStyleNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ConditionalAxisPropertyFontWeightNull
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalAxisPropertyFontWeightNullCondition Condition { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalPredicateValueDefFontWeightNullValue Value { get; set; }
    }

    public partial class ConditionalPredicateValueDefFontWeightNull
    {
        /// <summary>
        /// Predicate for triggering the condition
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate Test { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionalPredicateValueDefFontWeightNullValue Value { get; set; }
    }

    public partial class ImputeParams
    {
        /// <summary>
        /// A frame specification as a two-element array used to control the window over which the
        /// specified method is applied. The array entries should either be a number indicating the
        /// offset from the current data object, or null to indicate unbounded rows preceding or
        /// following the current data object. For example, the value `[-5, 5]` indicates that the
        /// window should include five objects preceding and five objects following the current
        /// object.
        ///
        /// __Default value:__:  `[null, null]` indicating that the window includes all objects.
        /// </summary>
        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public List<double?> Frame { get; set; }

        /// <summary>
        /// Defines the key values that should be considered for imputation.
        /// An array of key values or an object defining a [number
        /// sequence](https://vega.github.io/vega-lite/docs/impute.html#sequence-def).
        ///
        /// If provided, this will be used in addition to the key values observed within the input
        /// data. If not provided, the values will be derived from all unique values of the `key`
        /// field. For `impute` in `encoding`, the key field is the x-field if the y-field is
        /// imputed, or vice versa.
        ///
        /// If there is no impute grouping, this property _must_ be specified.
        /// </summary>
        [JsonProperty("keyvals", NullValueHandling = NullValueHandling.Ignore)]
        public Keyvals? Keyvals { get; set; }

        /// <summary>
        /// The imputation method to use for the field value of imputed data objects.
        /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
        ///
        /// __Default value:__  `"value"`
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public ImputeParamsMethod? Method { get; set; }

        /// <summary>
        /// The field value to use when the imputation `method` is `"value"`.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; set; }
    }

    public partial class ImputeSequence
    {
        /// <summary>
        /// The starting value of the sequence.
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public double? Start { get; set; }

        /// <summary>
        /// The step value between sequence entries.
        /// __Default value:__ `1` or `-1` if `stop < start`
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// The ending value(exclusive) of the sequence.
        /// </summary>
        [JsonProperty("stop", NullValueHandling = NullValueHandling.Ignore)]
        public double Stop { get; set; }
    }

    /// <summary>
    /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
    ///
    /// The `value` of this channel can be a number or a string `"width"` for the width of the
    /// plot.
    ///
    /// A field definition of a secondary channel that shares a scale with another primary
    /// channel. For example, `x2`, `xError` and `xError2` share the same scale with `x`.
    ///
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class X2Class
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
        public object Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? Value { get; set; }
    }

    /// <summary>
    /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
    /// `y2` or `height`.
    ///
    /// The `value` of this channel can be a number or a string `"height"` for the height of the
    /// plot.
    ///
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class YClass
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
        /// An object defining properties of axis's gridlines, ticks and labels.
        /// If `null`, the axis for the encoding channel will be removed.
        ///
        /// __Default value:__ If undefined, default [axis
        /// properties](https://vega.github.io/vega-lite/docs/axis.html) are applied.
        ///
        /// __See also:__ [`axis`](https://vega.github.io/vega-lite/docs/axis.html) documentation.
        /// </summary>
        [JsonProperty("axis", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Axis { get; set; }

        /// <summary>
        /// For rect-based marks (`rect`, `bar`, and `image`), mark size relative to bandwidth of
        /// [band scales](https://vega.github.io/vega-lite/docs/scale.html#band) or time units. If
        /// set to `1`, the mark size is set to the bandwidth or the time unit interval. If set to
        /// `0.5`, the mark size is half of the bandwidth or the time unit interval.
        ///
        /// For other marks, relative position on a band of a stacked, binned, time unit or band
        /// scale. If set to `0`, the marks will be positioned at the beginning of the band. If set
        /// to `0.5`, the marks will be positioned in the middle of the band.
        /// </summary>
        [JsonProperty("band", NullValueHandling = NullValueHandling.Ignore)]
        public double? Band { get; set; }

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
        public FluffyBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining the properties of the Impute Operation to be applied.
        /// The field value of the other positional channel is taken as `key` of the `Impute`
        /// Operation.
        /// The field of the `color` channel if specified is used as `groupby` of the `Impute`
        /// Operation.
        ///
        /// __See also:__ [`impute`](https://vega.github.io/vega-lite/docs/impute.html) documentation.
        /// </summary>
        [JsonProperty("impute", NullValueHandling = NullValueHandling.Ignore)]
        public ImputeParams Impute { get; set; }

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
        /// Type of stacking offset if the field should be stacked.
        /// `stack` is only applicable for `x` and `y` channels with continuous domains.
        /// For example, `stack` of `y` can be used to customize stacking for a vertical bar chart.
        ///
        /// `stack` can be one of the following values:
        /// - `"zero"` or `true`: stacking with baseline offset at zero value of the scale (for
        /// creating typical stacked [bar](https://vega.github.io/vega-lite/docs/stack.html#bar) and
        /// [area](https://vega.github.io/vega-lite/docs/stack.html#area) chart).
        /// - `"normalize"` - stacking with normalized domain (for creating [normalized stacked bar
        /// and area charts](https://vega.github.io/vega-lite/docs/stack.html#normalized). <br/>
        /// -`"center"` - stacking with center baseline (for
        /// [streamgraph](https://vega.github.io/vega-lite/docs/stack.html#streamgraph)).
        /// - `null` or `false` - No-stacking. This will produce layered
        /// [bar](https://vega.github.io/vega-lite/docs/stack.html#layered-bar-chart) and area
        /// chart.
        ///
        /// __Default value:__ `zero` for plots with all of the following conditions are true:
        /// (1) the mark is `bar` or `area`;
        /// (2) the stacked measure channel (x or y) has a linear scale;
        /// (3) At least one of non-position channels mapped to an unaggregated field that is
        /// different from x and y. Otherwise, `null` by default.
        ///
        /// __See also:__ [`stack`](https://vega.github.io/vega-lite/docs/stack.html) documentation.
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public Stack? Stack { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Value { get; set; }
    }

    /// <summary>
    /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
    ///
    /// The `value` of this channel can be a number or a string `"height"` for the height of the
    /// plot.
    ///
    /// A field definition of a secondary channel that shares a scale with another primary
    /// channel. For example, `x2`, `xError` and `xError2` share the same scale with `x`.
    ///
    /// Definition object for a constant value (primitive value or gradient definition) of an
    /// encoding channel.
    /// </summary>
    public partial class Y2Class
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
        public object Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

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
        /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
        /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
        /// between `0` to `1` for opacity).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Value { get; set; }
    }

    /// <summary>
    /// Definition for how to facet the data. One of:
    /// 1) [a field definition for faceting the plot by one
    /// field](https://vega.github.io/vega-lite/docs/facet.html#field-def)
    /// 2) [An object that maps `row` and `column` channels to their field
    /// definitions](https://vega.github.io/vega-lite/docs/facet.html#mapping)
    ///
    /// A field definition for the horizontal facet of trellis plots.
    ///
    /// A field definition for the vertical facet of trellis plots.
    /// </summary>
    public partial class Facet
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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining properties of a facet's header.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Header Header { get; set; }

        /// <summary>
        /// Sort order for the encoded field.
        ///
        /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
        /// `"descending"`.
        ///
        /// For discrete fields, `sort` can be one of the following:
        /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
        /// JavaScript.
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
        /// __Note:__ `null` is not supported for `row` and `column`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortArray? Sort { get; set; }

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
        public StandardType? Type { get; set; }

        /// <summary>
        /// A field definition for the horizontal facet of trellis plots.
        /// </summary>
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public FacetFieldDef Column { get; set; }

        /// <summary>
        /// A field definition for the vertical facet of trellis plots.
        /// </summary>
        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public FacetFieldDef Row { get; set; }
    }

    /// <summary>
    /// A field definition for the horizontal facet of trellis plots.
    ///
    /// A field definition for the vertical facet of trellis plots.
    /// </summary>
    public partial class FacetFieldDef
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
        public PurpleBin? Bin { get; set; }

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
        [JsonProperty("field")]
        public Field? Field { get; set; }

        /// <summary>
        /// An object defining properties of a facet's header.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Header Header { get; set; }

        /// <summary>
        /// Sort order for the encoded field.
        ///
        /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
        /// `"descending"`.
        ///
        /// For discrete fields, `sort` can be one of the following:
        /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
        /// JavaScript.
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
        /// __Note:__ `null` is not supported for `row` and `column`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortArray? Sort { get; set; }

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
        public StandardType Type { get; set; }
    }

    public partial class Step
    {
        /// <summary>
        /// The size (width/height) per discrete step.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double StepStep { get; set; }
    }

    /// <summary>
    /// A full layered plot specification, which may contains `encoding` and `projection`
    /// properties that will be applied to underlying unit (single-view) specifications.
    ///
    /// A unit specification, which can contain either [primitive marks or composite
    /// marks](https://vega.github.io/vega-lite/docs/mark.html#types).
    ///
    /// Base interface for a unit (single-view) specification.
    /// </summary>
    public partial class LayerSpec
    {
        /// <summary>
        /// An object describing the data source. Set to `null` to ignore the parent's data source.
        /// If no data is set, it is derived from the parent.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Description of this mark for commenting purpose.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// A shared key-value mapping between encoding channels and definition of fields in the
        /// underlying layers.
        ///
        /// A key-value mapping between encoding channels and definition of fields.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public LayerEncoding Encoding { get; set; }

        /// <summary>
        /// The height of a visualization.
        ///
        /// - For a plot with a continuous y-field, height should be a number.
        /// - For a plot with either a discrete y-field or no y-field, height can be either a number
        /// indicating a fixed height or an object in the form of `{step: number}` defining the
        /// height per discrete step. (No y-field is equivalent to having one discrete step.)
        /// - To enable responsive sizing on height, it should be set to `"container"`.
        ///
        /// __Default value:__ Based on `config.view.continuousHeight` for a plot with a continuous
        /// y-field and `config.view.discreteHeight` otherwise.
        ///
        /// __Note:__ For plots with [`row` and `column`
        /// channels](https://vega.github.io/vega-lite/docs/encoding.html#facet), this represents the
        /// height of a single view and the `"container"` option cannot be used.
        ///
        /// __See also:__ [`height`](https://vega.github.io/vega-lite/docs/size.html) documentation.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public HeightUnion? Height { get; set; }

        /// <summary>
        /// Layer or single view specifications to be layered.
        ///
        /// __Note__: Specifications inside `layer` cannot use `row` and `column` channels as
        /// layering facet specifications is not allowed. Instead, use the [facet
        /// operator](https://vega.github.io/vega-lite/docs/facet.html) and place a layer inside a
        /// facet.
        /// </summary>
        [JsonProperty("layer", NullValueHandling = NullValueHandling.Ignore)]
        public List<LayerSpec> Layer { get; set; }

        /// <summary>
        /// Name of the visualization for later reference.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// An object defining properties of the geographic projection shared by underlying layers.
        ///
        /// An object defining properties of geographic projection, which will be applied to `shape`
        /// path for `"geoshape"` marks
        /// and to `latitude` and `"longitude"` channels for other marks.
        /// </summary>
        [JsonProperty("projection", NullValueHandling = NullValueHandling.Ignore)]
        public Projection Projection { get; set; }

        /// <summary>
        /// Scale, axis, and legend resolutions for view composition specifications.
        /// </summary>
        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public Resolve Resolve { get; set; }

        /// <summary>
        /// Title for the plot.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public LayerTitle? Title { get; set; }

        /// <summary>
        /// An array of data transformations such as filter and new field calculation.
        /// </summary>
        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public List<Transform> Transform { get; set; }

        /// <summary>
        /// An object defining the view background's fill and stroke.
        ///
        /// __Default value:__ none (transparent)
        /// </summary>
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewBackground View { get; set; }

        /// <summary>
        /// The width of a visualization.
        ///
        /// - For a plot with a continuous x-field, width should be a number.
        /// - For a plot with either a discrete x-field or no x-field, width can be either a number
        /// indicating a fixed width or an object in the form of `{step: number}` defining the width
        /// per discrete step. (No x-field is equivalent to having one discrete step.)
        /// - To enable responsive sizing on width, it should be set to `"container"`.
        ///
        /// __Default value:__
        /// Based on `config.view.continuousWidth` for a plot with a continuous x-field and
        /// `config.view.discreteWidth` otherwise.
        ///
        /// __Note:__ For plots with [`row` and `column`
        /// channels](https://vega.github.io/vega-lite/docs/encoding.html#facet), this represents the
        /// width of a single view and the `"container"` option cannot be used.
        ///
        /// __See also:__ [`width`](https://vega.github.io/vega-lite/docs/size.html) documentation.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public HeightUnion? Width { get; set; }

        /// <summary>
        /// A string describing the mark type (one of `"bar"`, `"circle"`, `"square"`, `"tick"`,
        /// `"line"`,
        /// `"area"`, `"point"`, `"rule"`, `"geoshape"`, and `"text"`) or a [mark definition
        /// object](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
        /// </summary>
        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        public AnyMark? Mark { get; set; }

        /// <summary>
        /// A key-value mapping between selection names and definitions.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, SelectionDef> Selection { get; set; }
    }

    /// <summary>
    /// A shared key-value mapping between encoding channels and definition of fields in the
    /// underlying layers.
    ///
    /// A key-value mapping between encoding channels and definition of fields.
    /// </summary>
    public partial class LayerEncoding
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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Color { get; set; }

        /// <summary>
        /// Additional levels of detail for grouping data in aggregate views and
        /// in line, trail, and area marks without mapping data to a specific visual channel.
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public Detail? Detail { get; set; }

        /// <summary>
        /// Fill color of the marks.
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_ The `fill` encoding has higher precedence than `color`, thus may override the
        /// `color` encoding if conflicting encodings are specified.
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Fill { get; set; }

        /// <summary>
        /// Fill opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `fillOpacity` property.
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber FillOpacity { get; set; }

        /// <summary>
        /// A URL to load upon mouse click.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public HrefClass Href { get; set; }

        /// <summary>
        /// A data field to use as a unique key for data binding. When a visualization’s data is
        /// updated, the key value will be used to match data elements to existing mark instances.
        /// Use a key channel to enable object constancy for transitions over dynamic data.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public TypedFieldDef Key { get; set; }

        /// <summary>
        /// Latitude position of geographically projected marks.
        /// </summary>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public LatitudeClass Latitude { get; set; }

        /// <summary>
        /// Latitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`, and
        /// `"rule"`.
        /// </summary>
        [JsonProperty("latitude2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class Latitude2 { get; set; }

        /// <summary>
        /// Longitude position of geographically projected marks.
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public LatitudeClass Longitude { get; set; }

        /// <summary>
        /// Longitude-2 position for geographically projected ranged `"area"`, `"bar"`, `"rect"`,
        /// and  `"rule"`.
        /// </summary>
        [JsonProperty("longitude2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class Longitude2 { get; set; }

        /// <summary>
        /// Opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `opacity` property.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefTypeForShapeStringNull Shape { get; set; }

        /// <summary>
        /// Size of the mark.
        /// - For `"point"`, `"square"` and `"circle"`, – the symbol size, or pixel area of the mark.
        /// - For `"bar"` and `"tick"` – the bar and tick's size.
        /// - For `"text"` – the text's font size.
        /// - Size is unsupported for `"line"`, `"area"`, and `"rect"`. (Use `"trail"` instead of
        /// line with varying size)
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber Size { get; set; }

        /// <summary>
        /// Stroke color of the marks.
        /// __Default value:__ If undefined, the default color depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `color` property.
        ///
        /// _Note:_ The `stroke` encoding has higher precedence than `color`, thus may override the
        /// `color` encoding if conflicting encodings are specified.
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefGradientStringNull Stroke { get; set; }

        /// <summary>
        /// Stroke opacity of the marks.
        ///
        /// __Default value:__ If undefined, the default opacity depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeOpacity`
        /// property.
        /// </summary>
        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber StrokeOpacity { get; set; }

        /// <summary>
        /// Stroke width of the marks.
        ///
        /// __Default value:__ If undefined, the default stroke width depends on [mark
        /// config](https://vega.github.io/vega-lite/docs/config.html#mark)'s `strokeWidth` property.
        /// </summary>
        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionMarkPropFieldDefNumber StrokeWidth { get; set; }

        /// <summary>
        /// Text of the `text` mark.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public DefWithConditionStringFieldDefText Text { get; set; }

        /// <summary>
        /// The tooltip text to show upon mouse hover. Specifying `tooltip` encoding overrides [the
        /// `tooltip` property in the mark
        /// definition](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
        ///
        /// See the [`tooltip`](https://vega.github.io/vega-lite/docs/tooltip.html) documentation for
        /// a detailed discussion about tooltip in Vega-Lite.
        /// </summary>
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Tooltip? Tooltip { get; set; }

        /// <summary>
        /// The URL of an image mark.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public HrefClass Url { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XClass X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public X2Class X2 { get; set; }

        /// <summary>
        /// Error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("xError", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class XError { get; set; }

        /// <summary>
        /// Secondary error value of x coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("xError2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class XError2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YClass Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public Y2Class Y2 { get; set; }

        /// <summary>
        /// Error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("yError", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class YError { get; set; }

        /// <summary>
        /// Secondary error value of y coordinates for error specified `"errorbar"` and `"errorband"`.
        /// </summary>
        [JsonProperty("yError2", NullValueHandling = NullValueHandling.Ignore)]
        public Latitude2Class YError2 { get; set; }
    }

    public partial class BoxPlotDefClass
    {
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Box { get; set; }

        /// <summary>
        /// Whether a composite mark be clipped to the enclosing group’s width and height.
        ///
        /// Whether a mark be clipped to the enclosing group’s width and height.
        /// </summary>
        [JsonProperty("clip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clip { get; set; }

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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The extent of the whiskers. Available options include:
        /// - `"min-max"`: min and max are the lower and upper whiskers respectively.
        /// - A number representing multiple of the interquartile range. This number will be
        /// multiplied by the IQR to determine whisker boundary, which spans from the smallest data
        /// to the largest data within the range _[Q1 - k * IQR, Q3 + k * IQR]_ where _Q1_ and _Q3_
        /// are the first and third quartiles while _IQR_ is the interquartile range (_Q3-Q1_).
        ///
        /// __Default value:__ `1.5`.
        ///
        /// The extent of the rule. Available options include:
        /// - `"ci"`: Extend the rule to the confidence interval of the mean.
        /// - `"stderr"`: The size of rule are set to the value of standard error, extending from the
        /// mean.
        /// - `"stdev"`: The size of rule are set to the value of standard deviation, extending from
        /// the mean.
        /// - `"iqr"`: Extend the rule to the q1 and q3.
        ///
        /// __Default value:__ `"stderr"`.
        ///
        /// The extent of the band. Available options include:
        /// - `"ci"`: Extend the band to the confidence interval of the mean.
        /// - `"stderr"`: The size of band are set to the value of standard error, extending from the
        /// mean.
        /// - `"stdev"`: The size of band are set to the value of standard deviation, extending from
        /// the mean.
        /// - `"iqr"`: Extend the band to the q1 and q3.
        ///
        /// __Default value:__ `"stderr"`.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public BoxPlotDefExtent? Extent { get; set; }

        [JsonProperty("median", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Median { get; set; }

        /// <summary>
        /// The opacity (value between [0,1]) of the mark.
        ///
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Orientation of the box plot. This is normally automatically determined based on types of
        /// fields on x and y channels. However, an explicit `orient` be specified when the
        /// orientation is ambiguous.
        ///
        /// __Default value:__ `"vertical"`.
        ///
        /// Orientation of the error bar. This is normally automatically determined, but can be
        /// specified when the orientation is ambiguous and cannot be automatically determined.
        ///
        /// Orientation of the error band. This is normally automatically determined, but can be
        /// specified when the orientation is ambiguous and cannot be automatically determined.
        ///
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        [JsonProperty("outliers", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Outliers { get; set; }

        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Rule { get; set; }

        /// <summary>
        /// Size of the box and median tick of a box plot
        ///
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Ticks { get; set; }

        /// <summary>
        /// The mark type. This could a primitive mark type
        /// (one of `"bar"`, `"circle"`, `"square"`, `"tick"`, `"line"`,
        /// `"area"`, `"point"`, `"geoshape"`, `"rule"`, and `"text"`)
        /// or a composite mark type (`"boxplot"`, `"errorband"`, `"errorbar"`).
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public BoxPlot Type { get; set; }

        [JsonProperty("band", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Band { get; set; }

        [JsonProperty("borders", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Borders { get; set; }

        /// <summary>
        /// The line interpolation method for the error band. One of the following:
        /// - `"linear"`: piecewise linear segments, as in a polyline.
        /// - `"linear-closed"`: close the linear segments to form a polygon.
        /// - `"step"`: a piecewise constant function (a step function) consisting of alternating
        /// horizontal and vertical lines. The y-value changes at the midpoint of each pair of
        /// adjacent x-values.
        /// - `"step-before"`: a piecewise constant function (a step function) consisting of
        /// alternating horizontal and vertical lines. The y-value changes before the x-value.
        /// - `"step-after"`: a piecewise constant function (a step function) consisting of
        /// alternating horizontal and vertical lines. The y-value changes after the x-value.
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
        ///
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// The tension parameter for the interpolation type of the error band.
        ///
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Offset between bars for binned field. The ideal value for this is either 0 (preferred by
        /// statisticians) or 1 (Vega-Lite default, D3 example style).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("binSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? BinSpacing { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A flag for overlaying line on top of area marks, or an object defining the properties of
        /// the overlayed lines.
        ///
        /// - If this value is an empty object (`{}`) or `true`, lines with default properties will
        /// be used.
        ///
        /// - If this value is `false`, no lines would be automatically added to area marks.
        ///
        /// __Default value:__ `false`.
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public Line? Line { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order { get; set; }

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
        [JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public PointUnion? Point { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// A string or array of strings indicating the name of custom styles to apply to the mark. A
        /// style is a named collection of mark property defaults defined within the [style
        /// configuration](https://vega.github.io/vega-lite/docs/mark.html#style-config). If style is
        /// an array, later styles will override earlier styles. Any [mark
        /// properties](https://vega.github.io/vega-lite/docs/encoding.html#mark-prop) explicitly
        /// defined within the `encoding` will override a style default.
        ///
        /// __Default value:__ The mark's name. For example, a bar mark will have style `"bar"` by
        /// default.
        /// __Note:__ Any specified style will augment the default style. For example, a bar mark
        /// with `"style": "foo"` will receive from `config.style.bar` and `config.style.foo` (the
        /// specified style `"foo"` has higher precedence).
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Style { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Thickness of the tick mark.
        ///
        /// __Default value:__  `1`
        /// </summary>
        [JsonProperty("thickness", NullValueHandling = NullValueHandling.Ignore)]
        public double? Thickness { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Offset for x2-position.
        /// </summary>
        [JsonProperty("x2Offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? X2Offset { get; set; }

        /// <summary>
        /// Offset for x-position.
        /// </summary>
        [JsonProperty("xOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? XOffset { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }

        /// <summary>
        /// Offset for y2-position.
        /// </summary>
        [JsonProperty("y2Offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y2Offset { get; set; }

        /// <summary>
        /// Offset for y-position.
        /// </summary>
        [JsonProperty("yOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? YOffset { get; set; }
    }

    /// <summary>
    /// Circle-Specific Config
    ///
    /// Geoshape-Specific Config
    ///
    /// Mark Config
    ///
    /// Point-Specific Config
    ///
    /// Rule-Specific Config
    ///
    /// Square-Specific Config
    ///
    /// Text-Specific Config
    /// </summary>
    public partial class MarkConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }

    public partial class ColorLinearGradient
    {
        /// <summary>
        /// The type of gradient. Use `"linear"` for a linear gradient.
        ///
        /// The type of gradient. Use `"radial"` for a radial gradient.
        /// </summary>
        [JsonProperty("gradient", NullValueHandling = NullValueHandling.Ignore)]
        public Gradient Gradient { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// An array of gradient stops defining the gradient color sequence.
        /// </summary>
        [JsonProperty("stops", NullValueHandling = NullValueHandling.Ignore)]
        public List<GradientStop> Stops { get; set; }

        /// <summary>
        /// The starting x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x1", NullValueHandling = NullValueHandling.Ignore)]
        public double? X1 { get; set; }

        /// <summary>
        /// The ending x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `1`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public double? X2 { get; set; }

        /// <summary>
        /// The starting y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y1", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y1 { get; set; }

        /// <summary>
        /// The ending y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y2 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the inner circle for the
        /// gradient.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("r1", NullValueHandling = NullValueHandling.Ignore)]
        public double? R1 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the outer circle for the
        /// gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("r2", NullValueHandling = NullValueHandling.Ignore)]
        public double? R2 { get; set; }
    }

    public partial class FillLinearGradient
    {
        /// <summary>
        /// The type of gradient. Use `"linear"` for a linear gradient.
        ///
        /// The type of gradient. Use `"radial"` for a radial gradient.
        /// </summary>
        [JsonProperty("gradient", NullValueHandling = NullValueHandling.Ignore)]
        public Gradient Gradient { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// An array of gradient stops defining the gradient color sequence.
        /// </summary>
        [JsonProperty("stops", NullValueHandling = NullValueHandling.Ignore)]
        public List<GradientStop> Stops { get; set; }

        /// <summary>
        /// The starting x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x1", NullValueHandling = NullValueHandling.Ignore)]
        public double? X1 { get; set; }

        /// <summary>
        /// The ending x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `1`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public double? X2 { get; set; }

        /// <summary>
        /// The starting y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y1", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y1 { get; set; }

        /// <summary>
        /// The ending y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y2 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the inner circle for the
        /// gradient.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("r1", NullValueHandling = NullValueHandling.Ignore)]
        public double? R1 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the outer circle for the
        /// gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("r2", NullValueHandling = NullValueHandling.Ignore)]
        public double? R2 { get; set; }
    }

    public partial class TooltipContent
    {
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public Content Content { get; set; }
    }

    public partial class OverlayMarkDef
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Whether a mark be clipped to the enclosing group’s width and height.
        /// </summary>
        [JsonProperty("clip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clip { get; set; }

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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// A string or array of strings indicating the name of custom styles to apply to the mark. A
        /// style is a named collection of mark property defaults defined within the [style
        /// configuration](https://vega.github.io/vega-lite/docs/mark.html#style-config). If style is
        /// an array, later styles will override earlier styles. Any [mark
        /// properties](https://vega.github.io/vega-lite/docs/encoding.html#mark-prop) explicitly
        /// defined within the `encoding` will override a style default.
        ///
        /// __Default value:__ The mark's name. For example, a bar mark will have style `"bar"` by
        /// default.
        /// __Note:__ Any specified style will augment the default style. For example, a bar mark
        /// with `"style": "foo"` will receive from `config.style.bar` and `config.style.foo` (the
        /// specified style `"foo"` has higher precedence).
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Style { get; set; }

        /// <summary>
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Offset for x2-position.
        /// </summary>
        [JsonProperty("x2Offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? X2Offset { get; set; }

        /// <summary>
        /// Offset for x-position.
        /// </summary>
        [JsonProperty("xOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? XOffset { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }

        /// <summary>
        /// Offset for y2-position.
        /// </summary>
        [JsonProperty("y2Offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y2Offset { get; set; }

        /// <summary>
        /// Offset for y-position.
        /// </summary>
        [JsonProperty("yOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? YOffset { get; set; }
    }

    /// <summary>
    /// Projection configuration, which determines default properties for all
    /// [projections](https://vega.github.io/vega-lite/docs/projection.html). For a full list of
    /// projection configuration options, please see the [corresponding section of the projection
    /// documentation](https://vega.github.io/vega-lite/docs/projection.html#config).
    ///
    /// Any property of Projection can be in config
    ///
    /// An object defining properties of geographic projection, which will be applied to `shape`
    /// path for `"geoshape"` marks
    /// and to `latitude` and `"longitude"` channels for other marks.
    ///
    /// An object defining properties of the geographic projection shared by underlying layers.
    /// </summary>
    public partial class Projection
    {
        /// <summary>
        /// The projection’s center to the specified center, a two-element array of longitude and
        /// latitude in degrees.
        ///
        /// __Default value:__ `[0, 0]`
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Center { get; set; }

        /// <summary>
        /// The projection’s clipping circle radius to the specified angle in degrees. If `null`,
        /// switches to [antimeridian](http://bl.ocks.org/mbostock/3788999) cutting rather than
        /// small-circle clipping.
        /// </summary>
        [JsonProperty("clipAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? ClipAngle { get; set; }

        /// <summary>
        /// The projection’s viewport clip extent to the specified bounds in pixels. The extent
        /// bounds are specified as an array `[[x0, y0], [x1, y1]]`, where `x0` is the left-side of
        /// the viewport, `y0` is the top, `x1` is the right and `y1` is the bottom. If `null`, no
        /// viewport clipping is performed.
        /// </summary>
        [JsonProperty("clipExtent", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> ClipExtent { get; set; }

        [JsonProperty("coefficient", NullValueHandling = NullValueHandling.Ignore)]
        public double? Coefficient { get; set; }

        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        [JsonProperty("fraction", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fraction { get; set; }

        [JsonProperty("lobes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lobes { get; set; }

        [JsonProperty("parallel", NullValueHandling = NullValueHandling.Ignore)]
        public double? Parallel { get; set; }

        [JsonProperty("parallels", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Parallels { get; set; }

        /// <summary>
        /// The threshold for the projection’s [adaptive
        /// resampling](http://bl.ocks.org/mbostock/3795544) to the specified value in pixels. This
        /// value corresponds to the [Douglas–Peucker
        /// distance](http://en.wikipedia.org/wiki/Ramer%E2%80%93Douglas%E2%80%93Peucker_algorithm).
        /// If precision is not specified, returns the projection’s current resampling precision
        /// which defaults to `√0.5 ≅ 0.70710…`.
        /// </summary>
        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public double? Precision { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public double? Radius { get; set; }

        [JsonProperty("ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? Ratio { get; set; }

        [JsonProperty("reflectX", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReflectX { get; set; }

        [JsonProperty("reflectY", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReflectY { get; set; }

        /// <summary>
        /// The projection’s three-axis rotation to the specified angles, which must be a two- or
        /// three-element array of numbers [`lambda`, `phi`, `gamma`] specifying the rotation angles
        /// in degrees about each spherical axis. (These correspond to yaw, pitch and roll.)
        ///
        /// __Default value:__ `[0, 0, 0]`
        /// </summary>
        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Rotate { get; set; }

        /// <summary>
        /// The projection's scale (zoom) value, overriding automatic fitting.
        /// </summary>
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public double? Scale { get; set; }

        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? Spacing { get; set; }

        [JsonProperty("tilt", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tilt { get; set; }

        /// <summary>
        /// The projection's translation (pan) value, overriding automatic fitting.
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Translate { get; set; }

        /// <summary>
        /// The cartographic projection to use. This value is case-insensitive, for example
        /// `"albers"` and `"Albers"` indicate the same projection type. You can find all valid
        /// projection types [in the
        /// documentation](https://vega.github.io/vega-lite/docs/projection.html#projection-types).
        ///
        /// __Default value:__ `mercator`
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectionType? Type { get; set; }
    }

    /// <summary>
    /// Scale, axis, and legend resolutions for view composition specifications.
    ///
    /// Defines how scales, axes, and legends from different specs should be combined. Resolve is
    /// a mapping from `scale`, `axis`, and `legend` to a mapping from channels to resolutions.
    /// Scales and guides can be resolved to be `"independent"` or `"shared"`.
    /// </summary>
    public partial class Resolve
    {
        [JsonProperty("axis", NullValueHandling = NullValueHandling.Ignore)]
        public AxisResolveMap Axis { get; set; }

        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public LegendResolveMap Legend { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleResolveMap Scale { get; set; }
    }

    public partial class AxisResolveMap
    {
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Y { get; set; }
    }

    public partial class LegendResolveMap
    {
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Color { get; set; }

        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Fill { get; set; }

        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? FillOpacity { get; set; }

        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Opacity { get; set; }

        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Shape { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Size { get; set; }

        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Stroke { get; set; }

        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? StrokeOpacity { get; set; }

        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? StrokeWidth { get; set; }
    }

    public partial class ScaleResolveMap
    {
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Color { get; set; }

        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Fill { get; set; }

        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? FillOpacity { get; set; }

        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Opacity { get; set; }

        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Shape { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Size { get; set; }

        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Stroke { get; set; }

        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? StrokeOpacity { get; set; }

        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? StrokeWidth { get; set; }

        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveMode? Y { get; set; }
    }

    public partial class SelectionDef
    {
        /// <summary>
        /// When set, a selection is populated by input elements (also known as dynamic query
        /// widgets)
        /// or by interacting with the corresponding legend. Direct manipulation interaction is
        /// disabled by default;
        /// to re-enable it, set the selection's
        /// [`on`](https://vega.github.io/vega-lite/docs/selection.html#common-selection-properties)
        /// property.
        ///
        /// Legend bindings are restricted to selections that only specify a single field or
        /// encoding.
        ///
        /// Query widget binding takes the form of Vega's [input element binding
        /// definition](https://vega.github.io/vega/docs/signals/#bind)
        /// or can be a mapping between projected field/encodings and binding definitions.
        ///
        /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
        ///
        /// When set, a selection is populated by interacting with the corresponding legend. Direct
        /// manipulation interaction is disabled by default;
        /// to re-enable it, set the selection's
        /// [`on`](https://vega.github.io/vega-lite/docs/selection.html#common-selection-properties)
        /// property.
        ///
        /// Legend bindings are restricted to selections that only specify a single field or
        /// encoding.
        ///
        /// Establishes a two-way binding between the interval selection and the scales
        /// used within the same view. This allows a user to interactively pan and
        /// zoom the view.
        ///
        /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
        /// </summary>
        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public BindUnion? Bind { get; set; }

        /// <summary>
        /// Clears the selection, emptying it of all values. Can be a
        /// [Event Stream](https://vega.github.io/vega/docs/event-streams/) or `false` to disable.
        ///
        /// __Default value:__ `dblclick`.
        ///
        /// __See also:__ [`clear`](https://vega.github.io/vega-lite/docs/clear.html) documentation.
        /// </summary>
        [JsonProperty("clear", NullValueHandling = NullValueHandling.Ignore)]
        public ClearUnion? Clear { get; set; }

        /// <summary>
        /// By default, `all` data values are considered to lie within an empty selection.
        /// When set to `none`, empty selections contain no data values.
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public Empty? Empty { get; set; }

        /// <summary>
        /// An array of encoding channels. The corresponding data field values
        /// must match for a data tuple to fall within the selection.
        ///
        /// __See also:__ [`encodings`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("encodings", NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleDefUnitChannel> Encodings { get; set; }

        /// <summary>
        /// An array of field names whose values must match for a data tuple to
        /// fall within the selection.
        ///
        /// __See also:__ [`fields`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and initial values.
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        ///
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and an initial
        /// value (or array of values).
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        ///
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and arrays of
        /// initial values.
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        /// </summary>
        [JsonProperty("init", NullValueHandling = NullValueHandling.Ignore)]
        public Init? Init { get; set; }

        /// <summary>
        /// When true, an invisible voronoi diagram is computed to accelerate discrete
        /// selection. The data value _nearest_ the mouse cursor is added to the selection.
        ///
        /// __See also:__ [`nearest`](https://vega.github.io/vega-lite/docs/nearest.html)
        /// documentation.
        /// </summary>
        [JsonProperty("nearest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nearest { get; set; }

        /// <summary>
        /// A [Vega event stream](https://vega.github.io/vega/docs/event-streams/) (object or
        /// selector) that triggers the selection.
        /// For interval selections, the event stream must specify a [start and
        /// end](https://vega.github.io/vega/docs/event-streams/#between-filters).
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public OnUnion? On { get; set; }

        /// <summary>
        /// With layered and multi-view displays, a strategy that determines how
        /// selections' data queries are resolved when applied in a filter transform,
        /// conditional encoding rule, or scale domain.
        ///
        /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
        /// documentation.
        /// </summary>
        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionResolution? Resolve { get; set; }

        /// <summary>
        /// Determines the default event processing and data query for the selection. Vega-Lite
        /// currently supports three selection types:
        ///
        /// - `"single"` -- to select a single discrete data value on `click`.
        /// - `"multi"` -- to select multiple discrete data value; the first value is selected on
        /// `click` and additional values toggled on shift-`click`.
        /// - `"interval"` -- to select a continuous range of data values on `drag`.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionDefType Type { get; set; }

        /// <summary>
        /// Controls whether data values should be toggled or only ever inserted into
        /// multi selections. Can be `true`, `false` (for insertion only), or a
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/).
        ///
        /// __Default value:__ `true`, which corresponds to `event.shiftKey` (i.e.,
        /// data values are toggled when a user interacts with the shift-key pressed).
        ///
        /// __See also:__ [`toggle`](https://vega.github.io/vega-lite/docs/toggle.html) documentation.
        /// </summary>
        [JsonProperty("toggle", NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Toggle { get; set; }

        /// <summary>
        /// An interval selection also adds a rectangle mark to depict the
        /// extents of the interval. The `mark` property can be used to customize the
        /// appearance of the mark.
        ///
        /// __See also:__ [`mark`](https://vega.github.io/vega-lite/docs/selection-mark.html)
        /// documentation.
        /// </summary>
        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        public BrushConfig Mark { get; set; }

        /// <summary>
        /// When truthy, allows a user to interactively move an interval selection
        /// back-and-forth. Can be `true`, `false` (to disable panning), or a
        /// [Vega event stream definition](https://vega.github.io/vega/docs/event-streams/)
        /// which must include a start and end event to trigger continuous panning.
        ///
        /// __Default value:__ `true`, which corresponds to
        /// `[mousedown, window:mouseup] > window:mousemove!` which corresponds to
        /// clicks and dragging within an interval selection to reposition it.
        ///
        /// __See also:__ [`translate`](https://vega.github.io/vega-lite/docs/translate.html)
        /// documentation.
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Translate { get; set; }

        /// <summary>
        /// When truthy, allows a user to interactively resize an interval selection.
        /// Can be `true`, `false` (to disable zooming), or a [Vega event stream
        /// definition](https://vega.github.io/vega/docs/event-streams/). Currently,
        /// only `wheel` events are supported.
        ///
        /// __Default value:__ `true`, which corresponds to `wheel!`.
        ///
        /// __See also:__ [`zoom`](https://vega.github.io/vega-lite/docs/zoom.html) documentation.
        /// </summary>
        [JsonProperty("zoom", NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Zoom { get; set; }
    }

    public partial class PurpleBinding
    {
        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("element", NullValueHandling = NullValueHandling.Ignore)]
        public string Element { get; set; }

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public string Input { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Options { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        [JsonProperty("autocomplete", NullValueHandling = NullValueHandling.Ignore)]
        public string Autocomplete { get; set; }

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public MarkType? Marktype { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source? Source { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }

    public partial class Stream
    {
        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public MarkType? Marktype { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source? Source { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream StreamStream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }

    public partial class ClearDerivedStream
    {
        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public MarkType? Marktype { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source? Source { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }

    /// <summary>
    /// An interval selection also adds a rectangle mark to depict the
    /// extents of the interval. The `mark` property can be used to customize the
    /// appearance of the mark.
    ///
    /// __See also:__ [`mark`](https://vega.github.io/vega-lite/docs/selection-mark.html)
    /// documentation.
    /// </summary>
    public partial class BrushConfig
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

    public partial class OnDerivedStream
    {
        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public MarkType? Marktype { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source? Source { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }

    public partial class TitleParams
    {
        /// <summary>
        /// Horizontal text alignment for title text. One of `"left"`, `"center"`, or `"right"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The anchor position for placing the title. One of `"start"`, `"middle"`, or `"end"`. For
        /// example, with an orientation of top these anchor positions map to a left-, center-, or
        /// right-aligned title.
        ///
        /// __Default value:__ `"middle"` for
        /// [single](https://vega.github.io/vega-lite/docs/spec.html) and
        /// [layered](https://vega.github.io/vega-lite/docs/layer.html) views.
        /// `"start"` for other composite views.
        ///
        /// __Note:__ [For now](https://github.com/vega/vega-lite/issues/2875), `anchor` is only
        /// customizable only for [single](https://vega.github.io/vega-lite/docs/spec.html) and
        /// [layered](https://vega.github.io/vega-lite/docs/layer.html) views. For other composite
        /// views, `anchor` is always `"start"`.
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? Anchor { get; set; }

        /// <summary>
        /// Angle in degrees of title and subtitle text.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Vertical text baseline for title and subtitle text. One of `"top"`, `"middle"`,
        /// `"bottom"`, or `"alphabetic"`.
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Text color for title text.
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// Delta offset for title and subtitle text x-coordinate.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// Delta offset for title and subtitle text y-coordinate.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// Font name for title text.
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// Font size in pixels for title text.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Font style for title text.
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// Font weight for title text.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// The reference frame for the anchor position, one of `"bounds"` (to anchor relative to the
        /// full bounding box) or `"group"` (to anchor relative to the group width or height).
        /// </summary>
        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public string Frame { get; set; }

        /// <summary>
        /// The maximum allowed length in pixels of title and subtitle text.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The orthogonal offset in pixels by which to displace the title group from its position
        /// along the edge of the chart.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        /// <summary>
        /// Default title orientation (`"top"`, `"bottom"`, `"left"`, or `"right"`)
        /// </summary>
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public TitleOrient? Orient { get; set; }

        /// <summary>
        /// A [mark style property](https://vega.github.io/vega-lite/docs/config.html#style) to apply
        /// to the title text mark.
        ///
        /// __Default value:__ `"group-title"`.
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Style { get; set; }

        /// <summary>
        /// The subtitle Text.
        /// </summary>
        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Subtitle { get; set; }

        /// <summary>
        /// Text color for subtitle text.
        /// </summary>
        [JsonProperty("subtitleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleColor { get; set; }

        /// <summary>
        /// Font name for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFont", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFont { get; set; }

        /// <summary>
        /// Font size in pixels for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitleFontSize { get; set; }

        /// <summary>
        /// Font style for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFontStyle { get; set; }

        /// <summary>
        /// Font weight for subtitle text.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("subtitleFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? SubtitleFontWeight { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line subtitle text.
        /// </summary>
        [JsonProperty("subtitleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitleLineHeight { get; set; }

        /// <summary>
        /// The padding in pixels between title and subtitle text.
        /// </summary>
        [JsonProperty("subtitlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitlePadding { get; set; }

        /// <summary>
        /// The title text.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text Text { get; set; }

        /// <summary>
        /// The integer z-index indicating the layering of the title group relative to other axis,
        /// mark and legend groups.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }

    public partial class Transform
    {
        /// <summary>
        /// Array of objects that define fields to aggregate.
        /// </summary>
        [JsonProperty("aggregate", NullValueHandling = NullValueHandling.Ignore)]
        public List<AggregatedFieldDef> Aggregate { get; set; }

        /// <summary>
        /// The data fields to group by. If not specified, a single group containing all data objects
        /// will be used.
        ///
        /// An optional array of fields by which to group the values.
        /// Imputation will then be performed on a per-group basis.
        ///
        /// The data fields for partitioning the data objects into separate groups. If unspecified,
        /// all data points will be in a single group.
        ///
        /// The data fields to group by.
        ///
        /// The data fields for partitioning the data objects into separate windows. If unspecified,
        /// all data points will be in a single window.
        ///
        /// The optional data fields to group by. If not specified, a single group containing all
        /// data objects will be used.
        /// </summary>
        [JsonProperty("groupby", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Groupby { get; set; }

        /// <summary>
        /// The output fields at which to write the start and end bin values.
        ///
        /// The field for storing the computed formula value.
        ///
        /// The output fields for the sample value and corresponding density estimate.
        ///
        /// __Default value:__ `["value", "density"]`
        ///
        /// The output field names for extracted array values.
        ///
        /// __Default value:__ The field name of the corresponding array field
        ///
        /// The output field names for the key and value properties produced by the fold transform.
        /// __Default value:__ `["key", "value"]`
        ///
        /// The output field names for the smoothed points generated by the loess transform.
        ///
        /// __Default value:__ The field names of the input x and y values.
        ///
        /// The output fields on which to store the looked up data values.
        ///
        /// For data lookups, this property may be left blank if `from.fields`
        /// has been specified (those field names will be used); if `from.fields`
        /// has not been specified, `as` must be a string.
        ///
        /// For selection lookups, this property is optional: if unspecified,
        /// looked up values will be stored under a property named for the selection;
        /// and if specified, it must correspond to `from.fields`.
        ///
        /// The output field names for the probability and quantile values.
        ///
        /// __Default value:__ `["prob", "value"]`
        ///
        /// The output field names for the smoothed points generated by the regression transform.
        ///
        /// __Default value:__ The field names of the input x and y values.
        ///
        /// The output field to write the timeUnit value.
        ///
        /// Output field names. This can be either a string or an array of strings with two elements
        /// denoting the name for the fields for stack start and stack end respectively.
        /// If a single string(e.g., `"val"`) is provided, the end field will be `"val_end"`.
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public Text? As { get; set; }

        /// <summary>
        /// An object indicating bin properties, or simply `true` for using default bin parameters.
        /// </summary>
        [JsonProperty("bin", NullValueHandling = NullValueHandling.Ignore)]
        public TransformBin? Bin { get; set; }

        /// <summary>
        /// The data field to bin.
        ///
        /// The data field to apply time unit.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// A [expression](https://vega.github.io/vega-lite/docs/types.html#expression) string. Use
        /// the variable `datum` to refer to the current data object.
        /// </summary>
        [JsonProperty("calculate", NullValueHandling = NullValueHandling.Ignore)]
        public string Calculate { get; set; }

        /// <summary>
        /// The bandwidth (standard deviation) of the Gaussian kernel. If unspecified or set to zero,
        /// the bandwidth value is automatically estimated from the input data using Scott’s rule.
        ///
        /// A bandwidth parameter in the range `[0, 1]` that determines the amount of smoothing.
        ///
        /// __Default value:__ `0.3`
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bandwidth { get; set; }

        /// <summary>
        /// A boolean flag indicating if the output values should be probability estimates (false) or
        /// smoothed counts (true).
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("counts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Counts { get; set; }

        /// <summary>
        /// A boolean flag indicating whether to produce density estimates (false) or cumulative
        /// density estimates (true).
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("cumulative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cumulative { get; set; }

        /// <summary>
        /// The data field for which to perform density estimation.
        /// </summary>
        [JsonProperty("density", NullValueHandling = NullValueHandling.Ignore)]
        public string Density { get; set; }

        /// <summary>
        /// A [min, max] domain from which to sample the distribution. If unspecified, the extent
        /// will be determined by the observed minimum and maximum values of the density value
        /// field.
        ///
        /// A [min, max] domain over the independent (x) field for the starting and ending points of
        /// the generated trend line.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Extent { get; set; }

        /// <summary>
        /// The maximum number of samples to take along the extent domain for plotting the density.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("maxsteps", NullValueHandling = NullValueHandling.Ignore)]
        public double? Maxsteps { get; set; }

        /// <summary>
        /// The minimum number of samples to take along the extent domain for plotting the density.
        ///
        /// __Default value:__ `25`
        /// </summary>
        [JsonProperty("minsteps", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minsteps { get; set; }

        /// <summary>
        /// The exact number of samples to take along the extent domain for plotting the density. If
        /// specified, overrides both minsteps and maxsteps to set an exact number of uniform
        /// samples. Potentially useful in conjunction with a fixed extent to ensure consistent
        /// sample points for stacked densities.
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public double? Steps { get; set; }

        /// <summary>
        /// The `filter` property must be one of the predicate definitions:
        ///
        /// 1) an [expression](https://vega.github.io/vega-lite/docs/types.html#expression) string,
        /// where `datum` can be used to refer to the current data object
        ///
        /// 2) one of the field predicates:
        /// [`equal`](https://vega.github.io/vega-lite/docs/filter.html#equal-predicate),
        /// [`lt`](https://vega.github.io/vega-lite/docs/filter.html#lt-predicate),
        /// [`lte`](https://vega.github.io/vega-lite/docs/filter.html#lte-predicate),
        /// [`gt`](https://vega.github.io/vega-lite/docs/filter.html#gt-predicate),
        /// [`gte`](https://vega.github.io/vega-lite/docs/filter.html#gte-predicate),
        /// [`range`](https://vega.github.io/vega-lite/docs/filter.html#range-predicate),
        /// [`oneOf`](https://vega.github.io/vega-lite/docs/filter.html#one-of-predicate),
        /// or [`valid`](https://vega.github.io/vega-lite/docs/filter.html#valid-predicate),
        ///
        /// 3) a [selection
        /// predicate](https://vega.github.io/vega-lite/docs/filter.html#selection-predicate)
        ///
        /// 4) a logical operand that combines (1), (2), or (3).
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperandPredicate? Filter { get; set; }

        /// <summary>
        /// An array of one or more data fields containing arrays to flatten.
        /// If multiple fields are specified, their array values should have a parallel structure,
        /// ideally with the same length.
        /// If the lengths of parallel arrays do not match,
        /// the longest array will be used with `null` values added for missing entries.
        /// </summary>
        [JsonProperty("flatten", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Flatten { get; set; }

        /// <summary>
        /// An array of data fields indicating the properties to fold.
        /// </summary>
        [JsonProperty("fold", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fold { get; set; }

        /// <summary>
        /// A frame specification as a two-element array used to control the window over which the
        /// specified method is applied. The array entries should either be a number indicating the
        /// offset from the current data object, or null to indicate unbounded rows preceding or
        /// following the current data object. For example, the value `[-5, 5]` indicates that the
        /// window should include five objects preceding and five objects following the current
        /// object.
        ///
        /// __Default value:__:  `[null, null]` indicating that the window includes all objects.
        ///
        /// A frame specification as a two-element array indicating how the sliding window should
        /// proceed. The array entries should either be a number indicating the offset from the
        /// current data object, or null to indicate unbounded rows preceding or following the
        /// current data object. The default value is `[null, 0]`, indicating that the sliding window
        /// includes the current object and all preceding objects. The value `[-5, 5]` indicates that
        /// the window should include five objects preceding and five objects following the current
        /// object. Finally, `[null, null]` indicates that the window frame should always include all
        /// data objects. If you this frame and want to assign the same value to add objects, you can
        /// use the simpler [join aggregate
        /// transform](https://vega.github.io/vega-lite/docs/joinaggregate.html). The only operators
        /// affected are the aggregation operations and the `first_value`, `last_value`, and
        /// `nth_value` window operations. The other window operations are not affected by this.
        ///
        /// __Default value:__:  `[null, 0]` (includes the current object and all preceding objects)
        /// </summary>
        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public List<double?> Frame { get; set; }

        /// <summary>
        /// The data field for which the missing values should be imputed.
        /// </summary>
        [JsonProperty("impute", NullValueHandling = NullValueHandling.Ignore)]
        public string Impute { get; set; }

        /// <summary>
        /// A key field that uniquely identifies data objects within a group.
        /// Missing key values (those occurring in the data but not in the current group) will be
        /// imputed.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Defines the key values that should be considered for imputation.
        /// An array of key values or an object defining a [number
        /// sequence](https://vega.github.io/vega-lite/docs/impute.html#sequence-def).
        ///
        /// If provided, this will be used in addition to the key values observed within the input
        /// data. If not provided, the values will be derived from all unique values of the `key`
        /// field. For `impute` in `encoding`, the key field is the x-field if the y-field is
        /// imputed, or vice versa.
        ///
        /// If there is no impute grouping, this property _must_ be specified.
        /// </summary>
        [JsonProperty("keyvals", NullValueHandling = NullValueHandling.Ignore)]
        public Keyvals? Keyvals { get; set; }

        /// <summary>
        /// The imputation method to use for the field value of imputed data objects.
        /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
        ///
        /// __Default value:__  `"value"`
        ///
        /// The functional form of the regression model. One of `"linear"`, `"log"`, `"exp"`,
        /// `"pow"`, `"quad"`, or `"poly"`.
        ///
        /// __Default value:__ `"linear"`
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public TransformMethod? Method { get; set; }

        /// <summary>
        /// The field value to use when the imputation `method` is `"value"`.
        ///
        /// The data field to populate pivoted fields. The aggregate values of this field become the
        /// values of the new pivoted fields.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; set; }

        /// <summary>
        /// The definition of the fields in the join aggregate, and what calculations to use.
        /// </summary>
        [JsonProperty("joinaggregate", NullValueHandling = NullValueHandling.Ignore)]
        public List<JoinAggregateFieldDef> Joinaggregate { get; set; }

        /// <summary>
        /// The data field of the dependent variable to smooth.
        /// </summary>
        [JsonProperty("loess", NullValueHandling = NullValueHandling.Ignore)]
        public string Loess { get; set; }

        /// <summary>
        /// The data field of the independent variable to use a predictor.
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public string On { get; set; }

        /// <summary>
        /// The default value to use if lookup fails.
        ///
        /// __Default value:__ `null`
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; }

        /// <summary>
        /// DataSource source or selection for secondary data reference.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public Lookup From { get; set; }

        /// <summary>
        /// Key in primary data source.
        /// </summary>
        [JsonProperty("lookup", NullValueHandling = NullValueHandling.Ignore)]
        public string Lookup { get; set; }

        /// <summary>
        /// An array of probabilities in the range (0, 1) for which to compute quantile values. If
        /// not specified, the *step* parameter will be used.
        /// </summary>
        [JsonProperty("probs", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Probs { get; set; }

        /// <summary>
        /// The data field for which to perform quantile estimation.
        /// </summary>
        [JsonProperty("quantile", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantile { get; set; }

        /// <summary>
        /// A probability step size (default 0.01) for sampling quantile values. All values from
        /// one-half the step size up to 1 (exclusive) will be sampled. This parameter is only used
        /// if the *probs* parameter is not provided.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// The polynomial order (number of coefficients) for the 'poly' method.
        ///
        /// __Default value:__ `3`
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public double? Order { get; set; }

        /// <summary>
        /// A boolean flag indicating if the transform should return the regression model parameters
        /// (one object per group), rather than trend line points.
        /// The resulting objects include a `coef` array of fitted coefficient values (starting with
        /// the intercept term and then including terms of increasing order)
        /// and an `rSquared` value (indicating the total variance explained by the model).
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Params { get; set; }

        /// <summary>
        /// The data field of the dependent variable to predict.
        /// </summary>
        [JsonProperty("regression", NullValueHandling = NullValueHandling.Ignore)]
        public string Regression { get; set; }

        /// <summary>
        /// The timeUnit.
        /// </summary>
        [JsonProperty("timeUnit", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnit? TimeUnit { get; set; }

        /// <summary>
        /// The maximum number of data objects to include in the sample.
        ///
        /// __Default value:__ `1000`
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sample { get; set; }

        /// <summary>
        /// Mode for stacking marks. One of `"zero"` (default), `"center"`, or `"normalize"`.
        /// The `"zero"` offset will stack starting at `0`. The `"center"` offset will center the
        /// stacks. The `"normalize"` offset will compute percentage values for each stack point,
        /// with output values in the range `[0,1]`.
        ///
        /// __Default value:__ `"zero"`
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public StackOffset? Offset { get; set; }

        /// <summary>
        /// Field that determines the order of leaves in the stacked charts.
        ///
        /// A sort field definition for sorting data objects within a window. If two data objects are
        /// considered equal by the comparator, they are considered "peer" values of equal rank. If
        /// sort is not specified, the order is undefined: data objects are processed in the order
        /// they are observed and none are considered peers (the ignorePeers parameter is ignored and
        /// treated as if set to `true`).
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortField> Sort { get; set; }

        /// <summary>
        /// The field which is stacked.
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public string Stack { get; set; }

        /// <summary>
        /// Indicates if the sliding window frame should ignore peer values (data that are considered
        /// identical by the sort criteria). The default is false, causing the window frame to expand
        /// to include all peer values. If set to true, the window frame will be defined by offset
        /// values only. This setting only affects those operations that depend on the window frame,
        /// namely aggregation operations and the first_value, last_value, and nth_value window
        /// operations.
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("ignorePeers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnorePeers { get; set; }

        /// <summary>
        /// The definition of the fields in the window, and what calculations to use.
        /// </summary>
        [JsonProperty("window", NullValueHandling = NullValueHandling.Ignore)]
        public List<WindowFieldDef> Window { get; set; }

        /// <summary>
        /// An optional parameter indicating the maximum number of pivoted fields to generate.
        /// The default (`0`) applies no limit. The pivoted `pivot` names are sorted in ascending
        /// order prior to enforcing the limit.
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// The aggregation operation to apply to grouped `value` field values.
        /// __Default value:__ `sum`
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public string Op { get; set; }

        /// <summary>
        /// The data field to pivot on. The unique values of this field become new field names in the
        /// output stream.
        /// </summary>
        [JsonProperty("pivot", NullValueHandling = NullValueHandling.Ignore)]
        public string Pivot { get; set; }
    }

    public partial class AggregatedFieldDef
    {
        /// <summary>
        /// The output field names to use for each aggregated field.
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        /// <summary>
        /// The data field for which to compute aggregate function. This is required for all
        /// aggregation operations except `"count"`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The aggregation operation to apply to the fields (e.g., `"sum"`, `"average"`, or
        /// `"count"`).
        /// See the [full list of supported aggregation
        /// operations](https://vega.github.io/vega-lite/docs/aggregate.html#ops)
        /// for more information.
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public AggregateOp Op { get; set; }
    }

    /// <summary>
    /// DataSource source or selection for secondary data reference.
    /// </summary>
    public partial class Lookup
    {
        /// <summary>
        /// Secondary data source to lookup in.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }

        /// <summary>
        /// Fields in foreign data or selection to lookup.
        /// If not specified, the entire object is queried.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Key in data to lookup.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Selection name to look up.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public string Selection { get; set; }
    }

    /// <summary>
    /// Secondary data source to lookup in.
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// An object that specifies the format for parsing the data.
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public DataFormat Format { get; set; }

        /// <summary>
        /// Provide a placeholder name and bind data at runtime.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// An URL from which to load the data set. Use the `format.type` property
        /// to ensure the loaded data is correctly parsed.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The full data set, included inline. This can be an array of objects or primitive values,
        /// an object, or a string.
        /// Arrays of primitive values are ingested as objects with a `data` property. Strings are
        /// parsed according to the specified format type.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public InlineDataset? Values { get; set; }

        /// <summary>
        /// Generate a sequence of numbers.
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public SequenceParams Sequence { get; set; }

        /// <summary>
        /// Generate sphere GeoJSON data for the full globe.
        /// </summary>
        [JsonProperty("sphere", NullValueHandling = NullValueHandling.Ignore)]
        public SphereUnion? Sphere { get; set; }

        /// <summary>
        /// Generate graticule GeoJSON data for geographic reference lines.
        /// </summary>
        [JsonProperty("graticule", NullValueHandling = NullValueHandling.Ignore)]
        public Graticule? Graticule { get; set; }
    }

    public partial class JoinAggregateFieldDef
    {
        /// <summary>
        /// The output name for the join aggregate operation.
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        /// <summary>
        /// The data field for which to compute the aggregate function. This can be omitted for
        /// functions that do not operate over a field such as `"count"`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The aggregation operation to apply (e.g., `"sum"`, `"average"` or `"count"`). See the
        /// list of all supported operations
        /// [here](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public AggregateOp Op { get; set; }
    }

    /// <summary>
    /// A sort definition for transform
    /// </summary>
    public partial class SortField
    {
        /// <summary>
        /// The name of the field to sort.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// Whether to sort the field in ascending or descending order. One of `"ascending"`
        /// (default), `"descending"`, or `null` (no not sort).
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrder? Order { get; set; }
    }

    public partial class WindowFieldDef
    {
        /// <summary>
        /// The output name for the window operation.
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        /// <summary>
        /// The data field for which to compute the aggregate or window function. This can be omitted
        /// for window functions that do not operate over a field such as `"count"`, `"rank"`,
        /// `"dense_rank"`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The window or aggregation operation to apply within a window (e.g., `"rank"`, `"lead"`,
        /// `"sum"`, `"average"` or `"count"`). See the list of all supported operations
        /// [here](https://vega.github.io/vega-lite/docs/window.html#ops).
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public Op Op { get; set; }

        /// <summary>
        /// Parameter values for the window functions. Parameter values can be omitted for operations
        /// that do not accept a parameter.
        ///
        /// See the list of all supported operations and their parameters
        /// [here](https://vega.github.io/vega-lite/docs/transforms/window.html).
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public double? Param { get; set; }
    }

    /// <summary>
    /// An object defining the view background's fill and stroke.
    ///
    /// __Default value:__ none (transparent)
    /// </summary>
    public partial class ViewBackground
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

    public partial class RepeatMapping
    {
        /// <summary>
        /// An array of fields to be repeated horizontally.
        /// </summary>
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Column { get; set; }

        /// <summary>
        /// An array of fields to be repeated vertically.
        /// </summary>
        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Row { get; set; }
    }

    /// <summary>
    /// Vega-Lite configuration object. This property can only be defined at the top-level of a
    /// specification.
    /// </summary>
    public partial class Config
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

    /// <summary>
    /// Area-Specific Config
    /// </summary>
    public partial class AreaConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A flag for overlaying line on top of area marks, or an object defining the properties of
        /// the overlayed lines.
        ///
        /// - If this value is an empty object (`{}`) or `true`, lines with default properties will
        /// be used.
        ///
        /// - If this value is `false`, no lines would be automatically added to area marks.
        ///
        /// __Default value:__ `false`.
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public Line? Line { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public PointUnion? Point { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }

    /// <summary>
    /// Axis configuration, which determines default properties for all `x` and `y`
    /// [axes](https://vega.github.io/vega-lite/docs/axis.html). For a full list of axis
    /// configuration options, please see the [corresponding section of the axis
    /// documentation](https://vega.github.io/vega-lite/docs/axis.html#config).
    ///
    /// Specific axis config for axes with "band" scales.
    ///
    /// Specific axis config for x-axis along the bottom edge of the chart.
    ///
    /// Specific axis config for y-axis along the left edge of the chart.
    ///
    /// Specific axis config for y-axis along the right edge of the chart.
    ///
    /// Specific axis config for x-axis along the top edge of the chart.
    ///
    /// X-axis specific config.
    ///
    /// Y-axis specific config.
    /// </summary>
    public partial class AxisConfig
    {
        /// <summary>
        /// An interpolation fraction indicating where, for `band` scales, axis ticks should be
        /// positioned. A value of `0` places ticks at the left edge of their bands. A value of `0.5`
        /// places ticks in the middle of their bands.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("bandPosition", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPosition { get; set; }

        /// <summary>
        /// A boolean flag indicating if the domain (the axis baseline) should be included as part of
        /// the axis.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domain { get; set; }

        /// <summary>
        /// Color of axis domain line.
        ///
        /// __Default value:__ `"gray"`.
        /// </summary>
        [JsonProperty("domainColor", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainColor { get; set; }

        /// <summary>
        /// An array of alternating [stroke, space] lengths for dashed domain lines.
        /// </summary>
        [JsonProperty("domainDash", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DomainDash { get; set; }

        /// <summary>
        /// The pixel offset at which to start drawing with the domain dash array.
        /// </summary>
        [JsonProperty("domainDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainDashOffset { get; set; }

        /// <summary>
        /// Opacity of the axis domain line.
        /// </summary>
        [JsonProperty("domainOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainOpacity { get; set; }

        /// <summary>
        /// Stroke width of axis domain line
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("domainWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainWidth { get; set; }

        /// <summary>
        /// A boolean flag indicating if grid lines should be included as part of the axis
        ///
        /// __Default value:__ `true` for [continuous
        /// scales](https://vega.github.io/vega-lite/docs/scale.html#continuous) that are not binned;
        /// otherwise, `false`.
        /// </summary>
        [JsonProperty("grid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Grid { get; set; }

        [JsonProperty("gridColor", NullValueHandling = NullValueHandling.Ignore)]
        public Color? GridColor { get; set; }

        [JsonProperty("gridDash", NullValueHandling = NullValueHandling.Ignore)]
        public Dash? GridDash { get; set; }

        [JsonProperty("gridDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? GridDashOffset { get; set; }

        [JsonProperty("gridOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public GridOpacity? GridOpacity { get; set; }

        [JsonProperty("gridWidth", NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? GridWidth { get; set; }

        [JsonProperty("labelAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlign? LabelAlign { get; set; }

        /// <summary>
        /// The rotation angle of the axis labels.
        ///
        /// __Default value:__ `-90` for nominal and ordinal fields; `0` otherwise.
        /// </summary>
        [JsonProperty("labelAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelAngle { get; set; }

        [JsonProperty("labelBaseline", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("labelBound", NullValueHandling = NullValueHandling.Ignore)]
        public Label? LabelBound { get; set; }

        [JsonProperty("labelColor", NullValueHandling = NullValueHandling.Ignore)]
        public Color? LabelColor { get; set; }

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
        [JsonProperty("labelFlush", NullValueHandling = NullValueHandling.Ignore)]
        public Label? LabelFlush { get; set; }

        /// <summary>
        /// Indicates the number of pixels by which to offset flush-adjusted labels. For example, a
        /// value of `2` will push flush-adjusted labels 2 pixels outward from the center of the
        /// axis. Offsets can help the labels better visually group with corresponding axis ticks.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("labelFlushOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelFlushOffset { get; set; }

        [JsonProperty("labelFont", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? LabelFont { get; set; }

        [JsonProperty("labelFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? LabelFontSize { get; set; }

        [JsonProperty("labelFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFontStyle? LabelFontStyle { get; set; }

        [JsonProperty("labelFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFontWeightUnion? LabelFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of axis tick labels.
        ///
        /// __Default value:__ `180`
        /// </summary>
        [JsonProperty("labelLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelLimit { get; set; }

        [JsonProperty("labelOpacity", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("labelOverlap", NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlap? LabelOverlap { get; set; }

        /// <summary>
        /// The padding, in pixels, between axis and text labels.
        ///
        /// __Default value:__ `2`
        /// </summary>
        [JsonProperty("labelPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelPadding { get; set; }

        /// <summary>
        /// A boolean flag indicating if labels should be included as part of the axis.
        ///
        /// __Default value:__ `true`.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Labels { get; set; }

        /// <summary>
        /// The minimum separation that must be between label bounding boxes for them to be
        /// considered non-overlapping (default `0`). This property is ignored if *labelOverlap*
        /// resolution is not enabled.
        /// </summary>
        [JsonProperty("labelSeparation", NullValueHandling = NullValueHandling.Ignore)]
        public double? LabelSeparation { get; set; }

        /// <summary>
        /// The maximum extent in pixels that axis ticks and labels should use. This determines a
        /// maximum offset value for axis titles.
        ///
        /// __Default value:__ `undefined`.
        /// </summary>
        [JsonProperty("maxExtent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxExtent { get; set; }

        /// <summary>
        /// The minimum extent in pixels that axis ticks and labels should use. This determines a
        /// minimum offset value for axis titles.
        ///
        /// __Default value:__ `30` for y-axis; `undefined` for x-axis.
        /// </summary>
        [JsonProperty("minExtent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinExtent { get; set; }

        /// <summary>
        /// The orientation of the axis. One of `"top"`, `"bottom"`, `"left"` or `"right"`. The
        /// orientation can be used to further specialize the axis type (e.g., a y-axis oriented
        /// towards the right edge of the chart).
        ///
        /// __Default value:__ `"bottom"` for x-axes and `"left"` for y-axes.
        /// </summary>
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orient? Orient { get; set; }

        /// <summary>
        /// For band scales, indicates if ticks and grid lines should be placed at the center of a
        /// band (default) or at the band extents to indicate intervals.
        /// </summary>
        [JsonProperty("tickBand", NullValueHandling = NullValueHandling.Ignore)]
        public TickBand? TickBand { get; set; }

        [JsonProperty("tickColor", NullValueHandling = NullValueHandling.Ignore)]
        public Color? TickColor { get; set; }

        [JsonProperty("tickDash", NullValueHandling = NullValueHandling.Ignore)]
        public Dash? TickDash { get; set; }

        [JsonProperty("tickDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? TickDashOffset { get; set; }

        /// <summary>
        /// Boolean flag indicating if an extra axis tick should be added for the initial position of
        /// the axis. This flag is useful for styling axes for `band` scales such that ticks are
        /// placed on band boundaries rather in the middle of a band. Use in conjunction with
        /// `"bandPosition": 1` and an axis `"padding"` value of `0`.
        /// </summary>
        [JsonProperty("tickExtra", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TickExtra { get; set; }

        /// <summary>
        /// Position offset in pixels to apply to ticks, labels, and gridlines.
        /// </summary>
        [JsonProperty("tickOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickOffset { get; set; }

        [JsonProperty("tickOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public GridDashOffset? TickOpacity { get; set; }

        /// <summary>
        /// Boolean flag indicating if pixel position values should be rounded to the nearest
        /// integer.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("tickRound", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TickRound { get; set; }

        /// <summary>
        /// Boolean value that determines whether the axis should include ticks.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticks { get; set; }

        /// <summary>
        /// The size in pixels of axis ticks.
        ///
        /// __Default value:__ `5`
        /// </summary>
        [JsonProperty("tickSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? TickSize { get; set; }

        [JsonProperty("tickWidth", NullValueHandling = NullValueHandling.Ignore)]
        public GridWidth? TickWidth { get; set; }

        /// <summary>
        /// Set to null to disable title for the axis, legend, or header.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public object Title { get; set; }

        /// <summary>
        /// Horizontal text alignment of axis titles.
        /// </summary>
        [JsonProperty("titleAlign", NullValueHandling = NullValueHandling.Ignore)]
        public Align? TitleAlign { get; set; }

        /// <summary>
        /// Text anchor position for placing axis titles.
        /// </summary>
        [JsonProperty("titleAnchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? TitleAnchor { get; set; }

        /// <summary>
        /// Angle in degrees of axis titles.
        /// </summary>
        [JsonProperty("titleAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleAngle { get; set; }

        /// <summary>
        /// Vertical text baseline for axis titles.
        /// </summary>
        [JsonProperty("titleBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? TitleBaseline { get; set; }

        /// <summary>
        /// Color of the title, can be in hex color code or regular color name.
        /// </summary>
        [JsonProperty("titleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleColor { get; set; }

        /// <summary>
        /// Font of the title. (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("titleFont", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFont { get; set; }

        /// <summary>
        /// Font size of the title.
        /// </summary>
        [JsonProperty("titleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// Font style of the title.
        /// </summary>
        [JsonProperty("titleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Font weight of the title.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("titleFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? TitleFontWeight { get; set; }

        /// <summary>
        /// Maximum allowed pixel width of axis titles.
        /// </summary>
        [JsonProperty("titleLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLimit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("titleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleLineHeight { get; set; }

        /// <summary>
        /// Opacity of the axis title.
        /// </summary>
        [JsonProperty("titleOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleOpacity { get; set; }

        /// <summary>
        /// The padding, in pixels, between title and axis.
        /// </summary>
        [JsonProperty("titlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitlePadding { get; set; }

        /// <summary>
        /// X-coordinate of the axis title relative to the axis group.
        /// </summary>
        [JsonProperty("titleX", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleX { get; set; }

        /// <summary>
        /// Y-coordinate of the axis title relative to the axis group.
        /// </summary>
        [JsonProperty("titleY", NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleY { get; set; }

        /// <summary>
        /// Translation offset in pixels applied to the axis group mark x and y. If specified,
        /// overrides the default behavior of a 0.5 offset to pixel-align stroked lines.
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public double? Translate { get; set; }
    }

    /// <summary>
    /// Bar-Specific Config
    ///
    /// Image-specific Config
    ///
    /// Rect-Specific Config
    /// </summary>
    public partial class RectConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Offset between bars for binned field. The ideal value for this is either 0 (preferred by
        /// statisticians) or 1 (Vega-Lite default, D3 example style).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("binSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? BinSpacing { get; set; }

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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The default size of the bars on continuous scales.
        ///
        /// __Default value:__ `5`
        /// </summary>
        [JsonProperty("continuousBandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousBandSize { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The default size of the bars with discrete dimensions. If unspecified, the default size
        /// is  `step-2`, which provides 2 pixel offset between bars.
        /// </summary>
        [JsonProperty("discreteBandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? DiscreteBandSize { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }

    /// <summary>
    /// Box Config
    /// </summary>
    public partial class BoxPlotConfig
    {
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Box { get; set; }

        /// <summary>
        /// The extent of the whiskers. Available options include:
        /// - `"min-max"`: min and max are the lower and upper whiskers respectively.
        /// - A number representing multiple of the interquartile range. This number will be
        /// multiplied by the IQR to determine whisker boundary, which spans from the smallest data
        /// to the largest data within the range _[Q1 - k * IQR, Q3 + k * IQR]_ where _Q1_ and _Q3_
        /// are the first and third quartiles while _IQR_ is the interquartile range (_Q3-Q1_).
        ///
        /// __Default value:__ `1.5`.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public BoxplotExtent? Extent { get; set; }

        [JsonProperty("median", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Median { get; set; }

        [JsonProperty("outliers", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Outliers { get; set; }

        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Rule { get; set; }

        /// <summary>
        /// Size of the box and median tick of a box plot
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Ticks { get; set; }
    }

    /// <summary>
    /// Default configuration for all concatenation view composition operators (`concat`,
    /// `hconcat`, and `vconcat`)
    ///
    /// Default configuration for the `facet` view composition operator
    ///
    /// Default configuration for the `repeat` view composition operator
    /// </summary>
    public partial class CompositionConfig
    {
        /// <summary>
        /// The number of columns to include in the view composition layout.
        ///
        /// __Default value__: `undefined` -- An infinite number of columns (a single row) will be
        /// assumed. This is equivalent to
        /// `hconcat` (for `concat`) and to using the `column` channel (for `facet` and `repeat`).
        ///
        /// __Note__:
        ///
        /// 1) This property is only for:
        /// - the general (wrappable) `concat` operator (not `hconcat`/`vconcat`)
        /// - the `facet` and `repeat` operator with one field/repetition definition (without
        /// row/column nesting)
        ///
        /// 2) Setting the `columns` to `1` is equivalent to `vconcat` (for `concat`) and to using
        /// the `row` channel (for `facet` and `repeat`).
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public double? Columns { get; set; }

        /// <summary>
        /// The default spacing in pixels between composed sub-views.
        ///
        /// __Default value__: `20`
        /// </summary>
        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? Spacing { get; set; }
    }

    /// <summary>
    /// ErrorBand Config
    /// </summary>
    public partial class ErrorBandConfig
    {
        [JsonProperty("band", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Band { get; set; }

        [JsonProperty("borders", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Borders { get; set; }

        /// <summary>
        /// The extent of the band. Available options include:
        /// - `"ci"`: Extend the band to the confidence interval of the mean.
        /// - `"stderr"`: The size of band are set to the value of standard error, extending from the
        /// mean.
        /// - `"stdev"`: The size of band are set to the value of standard deviation, extending from
        /// the mean.
        /// - `"iqr"`: Extend the band to the q1 and q3.
        ///
        /// __Default value:__ `"stderr"`.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorbandExtent? Extent { get; set; }

        /// <summary>
        /// The line interpolation method for the error band. One of the following:
        /// - `"linear"`: piecewise linear segments, as in a polyline.
        /// - `"linear-closed"`: close the linear segments to form a polygon.
        /// - `"step"`: a piecewise constant function (a step function) consisting of alternating
        /// horizontal and vertical lines. The y-value changes at the midpoint of each pair of
        /// adjacent x-values.
        /// - `"step-before"`: a piecewise constant function (a step function) consisting of
        /// alternating horizontal and vertical lines. The y-value changes before the x-value.
        /// - `"step-after"`: a piecewise constant function (a step function) consisting of
        /// alternating horizontal and vertical lines. The y-value changes after the x-value.
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// The tension parameter for the interpolation type of the error band.
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }
    }

    /// <summary>
    /// ErrorBar Config
    /// </summary>
    public partial class ErrorBarConfig
    {
        /// <summary>
        /// The extent of the rule. Available options include:
        /// - `"ci"`: Extend the rule to the confidence interval of the mean.
        /// - `"stderr"`: The size of rule are set to the value of standard error, extending from the
        /// mean.
        /// - `"stdev"`: The size of rule are set to the value of standard deviation, extending from
        /// the mean.
        /// - `"iqr"`: Extend the rule to the q1 and q3.
        ///
        /// __Default value:__ `"stderr"`.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorbandExtent? Extent { get; set; }

        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Rule { get; set; }

        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public Box? Ticks { get; set; }
    }

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
    public partial class HeaderConfig
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

    /// <summary>
    /// Legend configuration, which determines default properties for all
    /// [legends](https://vega.github.io/vega-lite/docs/legend.html). For a full list of legend
    /// configuration options, please see the [corresponding section of in the legend
    /// documentation](https://vega.github.io/vega-lite/docs/legend.html#config).
    /// </summary>
    public partial class LegendConfig
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

    /// <summary>
    /// Legend orient group layout parameters.
    /// </summary>
    public partial class LegendLayout
    {
        /// <summary>
        /// The anchor point for legend orient group layout.
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public AnchorUnion? Anchor { get; set; }

        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Bottom { get; set; }

        [JsonProperty("bottom-left", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout BottomLeft { get; set; }

        [JsonProperty("bottom-right", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout BottomRight { get; set; }

        /// <summary>
        /// The bounds calculation to use for legend orient group layout.
        /// </summary>
        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutBounds? Bounds { get; set; }

        /// <summary>
        /// A flag to center legends within a shared orient group.
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public BottomCenter? Center { get; set; }

        /// <summary>
        /// The layout direction for legend orient group layout.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Direction? Direction { get; set; }

        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Left { get; set; }

        /// <summary>
        /// The pixel margin between legends within a orient group.
        /// </summary>
        [JsonProperty("margin", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Margin { get; set; }

        /// <summary>
        /// The pixel offset from the chart body for a legend orient group.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Offset { get; set; }

        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Right { get; set; }

        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout Top { get; set; }

        [JsonProperty("top-left", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout TopLeft { get; set; }

        [JsonProperty("top-right", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLegendLayout TopRight { get; set; }
    }

    public partial class PurpleSignalRef
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }

    public partial class BaseLegendLayout
    {
        /// <summary>
        /// The anchor point for legend orient group layout.
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public AnchorUnion? Anchor { get; set; }

        /// <summary>
        /// The bounds calculation to use for legend orient group layout.
        /// </summary>
        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutBounds? Bounds { get; set; }

        /// <summary>
        /// A flag to center legends within a shared orient group.
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public BottomCenter? Center { get; set; }

        /// <summary>
        /// The layout direction for legend orient group layout.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Direction? Direction { get; set; }

        /// <summary>
        /// The pixel margin between legends within a orient group.
        /// </summary>
        [JsonProperty("margin", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Margin { get; set; }

        /// <summary>
        /// The pixel offset from the chart body for a legend orient group.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Offset { get; set; }
    }

    /// <summary>
    /// Line-Specific Config
    ///
    /// Trail-Specific Config
    /// </summary>
    public partial class LineConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public PointUnion? Point { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }

    public partial class PaddingClass
    {
        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bottom { get; set; }

        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public double? Left { get; set; }

        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public double? Right { get; set; }

        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public double? Top { get; set; }
    }

    /// <summary>
    /// An object hash that defines default range arrays or schemes for using with scales.
    /// For a full list of scale range configuration options, please see the [corresponding
    /// section of the scale
    /// documentation](https://vega.github.io/vega-lite/docs/scale.html#config).
    /// </summary>
    public partial class RangeConfig
    {
        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryUnion? Category { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for diverging
        /// quantitative ramps.
        /// </summary>
        [JsonProperty("diverging", NullValueHandling = NullValueHandling.Ignore)]
        public DivergingUnion? Diverging { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for quantitative
        /// heatmaps.
        /// </summary>
        [JsonProperty("heatmap", NullValueHandling = NullValueHandling.Ignore)]
        public HeatmapUnion? Heatmap { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
        /// </summary>
        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public OrdinalUnion? Ordinal { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for sequential
        /// quantitative ramps.
        /// </summary>
        [JsonProperty("ramp", NullValueHandling = NullValueHandling.Ignore)]
        public RampUnion? Ramp { get; set; }

        /// <summary>
        /// Array of [symbol](https://vega.github.io/vega/docs/marks/symbol/) names or paths for the
        /// default shape palette.
        /// </summary>
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Symbol { get; set; }
    }

    public partial class CategorySignalRef
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Count { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public SignalRefExtent? Extent { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme? Scheme { get; set; }
    }

    public partial class DivergingSignalRef
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Count { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public SignalRefExtent? Extent { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme? Scheme { get; set; }
    }

    public partial class HeatmapSignalRef
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Count { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public SignalRefExtent? Extent { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme? Scheme { get; set; }
    }

    public partial class OrdinalSignalRef
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Count { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public SignalRefExtent? Extent { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme? Scheme { get; set; }
    }

    public partial class RampSignalRef
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public RangeRawArray? Count { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public SignalRefExtent? Extent { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme? Scheme { get; set; }
    }

    /// <summary>
    /// Scale configuration determines default properties for all
    /// [scales](https://vega.github.io/vega-lite/docs/scale.html). For a full list of scale
    /// configuration options, please see the [corresponding section of the scale
    /// documentation](https://vega.github.io/vega-lite/docs/scale.html#config).
    /// </summary>
    public partial class ScaleConfig
    {
        /// <summary>
        /// Default inner padding for `x` and `y` band-ordinal scales.
        ///
        /// __Default value:__
        /// - `barBandPaddingInner` for bar marks (`0.1` by default)
        /// - `rectBandPaddingInner` for rect and other marks (`0` by default)
        /// </summary>
        [JsonProperty("bandPaddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPaddingInner { get; set; }

        /// <summary>
        /// Default outer padding for `x` and `y` band-ordinal scales.
        ///
        /// __Default value:__ `paddingInner/2` (which makes _width/height = number of unique values
        /// * step_)
        /// </summary>
        [JsonProperty("bandPaddingOuter", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPaddingOuter { get; set; }

        /// <summary>
        /// Default inner padding for `x` and `y` band-ordinal scales of `"bar"` marks.
        ///
        /// __Default value:__ `0.1`
        /// </summary>
        [JsonProperty("barBandPaddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? BarBandPaddingInner { get; set; }

        /// <summary>
        /// If true, values that exceed the data domain are clamped to either the minimum or maximum
        /// range value
        /// </summary>
        [JsonProperty("clamp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clamp { get; set; }

        /// <summary>
        /// Default padding for continuous scales.
        ///
        /// __Default:__ `5` for continuous x-scale of a vertical bar and continuous y-scale of a
        /// horizontal bar.; `0` otherwise.
        /// </summary>
        [JsonProperty("continuousPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousPadding { get; set; }

        /// <summary>
        /// The default max value for mapping quantitative fields to bar's size/bandSize.
        ///
        /// If undefined (default), we will use the axis's size (width or height) - 1.
        /// </summary>
        [JsonProperty("maxBandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxBandSize { get; set; }

        /// <summary>
        /// The default max value for mapping quantitative fields to text's size/fontSize.
        ///
        /// __Default value:__ `40`
        /// </summary>
        [JsonProperty("maxFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxFontSize { get; set; }

        /// <summary>
        /// Default max opacity for mapping a field to opacity.
        ///
        /// __Default value:__ `0.8`
        /// </summary>
        [JsonProperty("maxOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxOpacity { get; set; }

        /// <summary>
        /// Default max value for point size scale.
        /// </summary>
        [JsonProperty("maxSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxSize { get; set; }

        /// <summary>
        /// Default max strokeWidth for the scale of strokeWidth for rule and line marks and of size
        /// for trail marks.
        ///
        /// __Default value:__ `4`
        /// </summary>
        [JsonProperty("maxStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxStrokeWidth { get; set; }

        /// <summary>
        /// The default min value for mapping quantitative fields to bar and tick's size/bandSize
        /// scale with zero=false.
        ///
        /// __Default value:__ `2`
        /// </summary>
        [JsonProperty("minBandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinBandSize { get; set; }

        /// <summary>
        /// The default min value for mapping quantitative fields to tick's size/fontSize scale with
        /// zero=false
        ///
        /// __Default value:__ `8`
        /// </summary>
        [JsonProperty("minFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinFontSize { get; set; }

        /// <summary>
        /// Default minimum opacity for mapping a field to opacity.
        ///
        /// __Default value:__ `0.3`
        /// </summary>
        [JsonProperty("minOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinOpacity { get; set; }

        /// <summary>
        /// Default minimum value for point size scale with zero=false.
        ///
        /// __Default value:__ `9`
        /// </summary>
        [JsonProperty("minSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinSize { get; set; }

        /// <summary>
        /// Default minimum strokeWidth for the scale of strokeWidth for rule and line marks and of
        /// size for trail marks with zero=false.
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("minStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinStrokeWidth { get; set; }

        /// <summary>
        /// Default outer padding for `x` and `y` point-ordinal scales.
        ///
        /// __Default value:__ `0.5` (which makes _width/height = number of unique values * step_)
        /// </summary>
        [JsonProperty("pointPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? PointPadding { get; set; }

        /// <summary>
        /// Default range cardinality for
        /// [`quantile`](https://vega.github.io/vega-lite/docs/scale.html#quantile) scale.
        ///
        /// __Default value:__ `4`
        /// </summary>
        [JsonProperty("quantileCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? QuantileCount { get; set; }

        /// <summary>
        /// Default range cardinality for
        /// [`quantize`](https://vega.github.io/vega-lite/docs/scale.html#quantize) scale.
        ///
        /// __Default value:__ `4`
        /// </summary>
        [JsonProperty("quantizeCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? QuantizeCount { get; set; }

        /// <summary>
        /// Default inner padding for `x` and `y` band-ordinal scales of `"rect"` marks.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("rectBandPaddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? RectBandPaddingInner { get; set; }

        /// <summary>
        /// If true, rounds numeric output values to integers.
        /// This can be helpful for snapping to the pixel grid.
        /// (Only available for `x`, `y`, and `size` scales.)
        /// </summary>
        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Round { get; set; }

        /// <summary>
        /// Use the source data range before aggregation as scale domain instead of aggregated data
        /// for aggregate axis.
        ///
        /// This is equivalent to setting `domain` to `"unaggregate"` for aggregated _quantitative_
        /// fields by default.
        ///
        /// This property only works with aggregate functions that produce values within the raw data
        /// domain (`"mean"`, `"average"`, `"median"`, `"q1"`, `"q3"`, `"min"`, `"max"`). For other
        /// aggregations that produce values outside of the raw data domain (e.g. `"count"`,
        /// `"sum"`), this property is ignored.
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("useUnaggregatedDomain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseUnaggregatedDomain { get; set; }
    }

    /// <summary>
    /// An object hash for defining default properties for each type of selections.
    /// </summary>
    public partial class SelectionConfig
    {
        /// <summary>
        /// The default definition for an
        /// [`interval`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
        /// properties and transformations
        /// for an interval selection definition (except `type`) may be specified here.
        ///
        /// For instance, setting `interval` to `{"translate": false}` disables the ability to move
        /// interval selections by default.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalSelectionConfig Interval { get; set; }

        /// <summary>
        /// The default definition for a
        /// [`multi`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
        /// properties and transformations
        /// for a multi selection definition (except `type`) may be specified here.
        ///
        /// For instance, setting `multi` to `{"toggle": "event.altKey"}` adds additional values to
        /// multi selections when clicking with the alt-key pressed by default.
        /// </summary>
        [JsonProperty("multi", NullValueHandling = NullValueHandling.Ignore)]
        public MultiSelectionConfig Multi { get; set; }

        /// <summary>
        /// The default definition for a
        /// [`single`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
        /// properties and transformations
        /// for a single selection definition (except `type`) may be specified here.
        ///
        /// For instance, setting `single` to `{"on": "dblclick"}` populates single selections on
        /// double-click by default.
        /// </summary>
        [JsonProperty("single", NullValueHandling = NullValueHandling.Ignore)]
        public SingleSelectionConfig Single { get; set; }
    }

    /// <summary>
    /// The default definition for an
    /// [`interval`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
    /// properties and transformations
    /// for an interval selection definition (except `type`) may be specified here.
    ///
    /// For instance, setting `interval` to `{"translate": false}` disables the ability to move
    /// interval selections by default.
    /// </summary>
    public partial class IntervalSelectionConfig
    {
        /// <summary>
        /// Establishes a two-way binding between the interval selection and the scales
        /// used within the same view. This allows a user to interactively pan and
        /// zoom the view.
        ///
        /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
        /// </summary>
        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public Bind? Bind { get; set; }

        /// <summary>
        /// Clears the selection, emptying it of all values. Can be a
        /// [Event Stream](https://vega.github.io/vega/docs/event-streams/) or `false` to disable.
        ///
        /// __Default value:__ `dblclick`.
        ///
        /// __See also:__ [`clear`](https://vega.github.io/vega-lite/docs/clear.html) documentation.
        /// </summary>
        [JsonProperty("clear", NullValueHandling = NullValueHandling.Ignore)]
        public ClearUnion? Clear { get; set; }

        /// <summary>
        /// By default, `all` data values are considered to lie within an empty selection.
        /// When set to `none`, empty selections contain no data values.
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public Empty? Empty { get; set; }

        /// <summary>
        /// An array of encoding channels. The corresponding data field values
        /// must match for a data tuple to fall within the selection.
        ///
        /// __See also:__ [`encodings`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("encodings", NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleDefUnitChannel> Encodings { get; set; }

        /// <summary>
        /// An array of field names whose values must match for a data tuple to
        /// fall within the selection.
        ///
        /// __See also:__ [`fields`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and arrays of
        /// initial values.
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        /// </summary>
        [JsonProperty("init", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<Equal>> Init { get; set; }

        /// <summary>
        /// An interval selection also adds a rectangle mark to depict the
        /// extents of the interval. The `mark` property can be used to customize the
        /// appearance of the mark.
        ///
        /// __See also:__ [`mark`](https://vega.github.io/vega-lite/docs/selection-mark.html)
        /// documentation.
        /// </summary>
        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        public BrushConfig Mark { get; set; }

        /// <summary>
        /// A [Vega event stream](https://vega.github.io/vega/docs/event-streams/) (object or
        /// selector) that triggers the selection.
        /// For interval selections, the event stream must specify a [start and
        /// end](https://vega.github.io/vega/docs/event-streams/#between-filters).
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public OnUnion? On { get; set; }

        /// <summary>
        /// With layered and multi-view displays, a strategy that determines how
        /// selections' data queries are resolved when applied in a filter transform,
        /// conditional encoding rule, or scale domain.
        ///
        /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
        /// documentation.
        /// </summary>
        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionResolution? Resolve { get; set; }

        /// <summary>
        /// When truthy, allows a user to interactively move an interval selection
        /// back-and-forth. Can be `true`, `false` (to disable panning), or a
        /// [Vega event stream definition](https://vega.github.io/vega/docs/event-streams/)
        /// which must include a start and end event to trigger continuous panning.
        ///
        /// __Default value:__ `true`, which corresponds to
        /// `[mousedown, window:mouseup] > window:mousemove!` which corresponds to
        /// clicks and dragging within an interval selection to reposition it.
        ///
        /// __See also:__ [`translate`](https://vega.github.io/vega-lite/docs/translate.html)
        /// documentation.
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Translate { get; set; }

        /// <summary>
        /// When truthy, allows a user to interactively resize an interval selection.
        /// Can be `true`, `false` (to disable zooming), or a [Vega event stream
        /// definition](https://vega.github.io/vega/docs/event-streams/). Currently,
        /// only `wheel` events are supported.
        ///
        /// __Default value:__ `true`, which corresponds to `wheel!`.
        ///
        /// __See also:__ [`zoom`](https://vega.github.io/vega-lite/docs/zoom.html) documentation.
        /// </summary>
        [JsonProperty("zoom", NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Zoom { get; set; }
    }

    /// <summary>
    /// The default definition for a
    /// [`multi`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
    /// properties and transformations
    /// for a multi selection definition (except `type`) may be specified here.
    ///
    /// For instance, setting `multi` to `{"toggle": "event.altKey"}` adds additional values to
    /// multi selections when clicking with the alt-key pressed by default.
    /// </summary>
    public partial class MultiSelectionConfig
    {
        /// <summary>
        /// When set, a selection is populated by interacting with the corresponding legend. Direct
        /// manipulation interaction is disabled by default;
        /// to re-enable it, set the selection's
        /// [`on`](https://vega.github.io/vega-lite/docs/selection.html#common-selection-properties)
        /// property.
        ///
        /// Legend bindings are restricted to selections that only specify a single field or encoding.
        /// </summary>
        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public LegendBinding? Bind { get; set; }

        /// <summary>
        /// Clears the selection, emptying it of all values. Can be a
        /// [Event Stream](https://vega.github.io/vega/docs/event-streams/) or `false` to disable.
        ///
        /// __Default value:__ `dblclick`.
        ///
        /// __See also:__ [`clear`](https://vega.github.io/vega-lite/docs/clear.html) documentation.
        /// </summary>
        [JsonProperty("clear", NullValueHandling = NullValueHandling.Ignore)]
        public ClearUnion? Clear { get; set; }

        /// <summary>
        /// By default, `all` data values are considered to lie within an empty selection.
        /// When set to `none`, empty selections contain no data values.
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public Empty? Empty { get; set; }

        /// <summary>
        /// An array of encoding channels. The corresponding data field values
        /// must match for a data tuple to fall within the selection.
        ///
        /// __See also:__ [`encodings`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("encodings", NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleDefUnitChannel> Encodings { get; set; }

        /// <summary>
        /// An array of field names whose values must match for a data tuple to
        /// fall within the selection.
        ///
        /// __See also:__ [`fields`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and an initial
        /// value (or array of values).
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        /// </summary>
        [JsonProperty("init", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, SelectionInit>> Init { get; set; }

        /// <summary>
        /// When true, an invisible voronoi diagram is computed to accelerate discrete
        /// selection. The data value _nearest_ the mouse cursor is added to the selection.
        ///
        /// __See also:__ [`nearest`](https://vega.github.io/vega-lite/docs/nearest.html)
        /// documentation.
        /// </summary>
        [JsonProperty("nearest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nearest { get; set; }

        /// <summary>
        /// A [Vega event stream](https://vega.github.io/vega/docs/event-streams/) (object or
        /// selector) that triggers the selection.
        /// For interval selections, the event stream must specify a [start and
        /// end](https://vega.github.io/vega/docs/event-streams/#between-filters).
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public OnUnion? On { get; set; }

        /// <summary>
        /// With layered and multi-view displays, a strategy that determines how
        /// selections' data queries are resolved when applied in a filter transform,
        /// conditional encoding rule, or scale domain.
        ///
        /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
        /// documentation.
        /// </summary>
        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionResolution? Resolve { get; set; }

        /// <summary>
        /// Controls whether data values should be toggled or only ever inserted into
        /// multi selections. Can be `true`, `false` (for insertion only), or a
        /// [Vega expression](https://vega.github.io/vega/docs/expressions/).
        ///
        /// __Default value:__ `true`, which corresponds to `event.shiftKey` (i.e.,
        /// data values are toggled when a user interacts with the shift-key pressed).
        ///
        /// __See also:__ [`toggle`](https://vega.github.io/vega-lite/docs/toggle.html) documentation.
        /// </summary>
        [JsonProperty("toggle", NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Toggle { get; set; }
    }

    public partial class LegendStreamBinding
    {
        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public OnUnion Legend { get; set; }
    }

    /// <summary>
    /// The default definition for a
    /// [`single`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
    /// properties and transformations
    /// for a single selection definition (except `type`) may be specified here.
    ///
    /// For instance, setting `single` to `{"on": "dblclick"}` populates single selections on
    /// double-click by default.
    /// </summary>
    public partial class SingleSelectionConfig
    {
        /// <summary>
        /// When set, a selection is populated by input elements (also known as dynamic query
        /// widgets)
        /// or by interacting with the corresponding legend. Direct manipulation interaction is
        /// disabled by default;
        /// to re-enable it, set the selection's
        /// [`on`](https://vega.github.io/vega-lite/docs/selection.html#common-selection-properties)
        /// property.
        ///
        /// Legend bindings are restricted to selections that only specify a single field or
        /// encoding.
        ///
        /// Query widget binding takes the form of Vega's [input element binding
        /// definition](https://vega.github.io/vega/docs/signals/#bind)
        /// or can be a mapping between projected field/encodings and binding definitions.
        ///
        /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
        /// </summary>
        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public Binding? Bind { get; set; }

        /// <summary>
        /// Clears the selection, emptying it of all values. Can be a
        /// [Event Stream](https://vega.github.io/vega/docs/event-streams/) or `false` to disable.
        ///
        /// __Default value:__ `dblclick`.
        ///
        /// __See also:__ [`clear`](https://vega.github.io/vega-lite/docs/clear.html) documentation.
        /// </summary>
        [JsonProperty("clear", NullValueHandling = NullValueHandling.Ignore)]
        public ClearUnion? Clear { get; set; }

        /// <summary>
        /// By default, `all` data values are considered to lie within an empty selection.
        /// When set to `none`, empty selections contain no data values.
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public Empty? Empty { get; set; }

        /// <summary>
        /// An array of encoding channels. The corresponding data field values
        /// must match for a data tuple to fall within the selection.
        ///
        /// __See also:__ [`encodings`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("encodings", NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleDefUnitChannel> Encodings { get; set; }

        /// <summary>
        /// An array of field names whose values must match for a data tuple to
        /// fall within the selection.
        ///
        /// __See also:__ [`fields`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and initial values.
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        /// </summary>
        [JsonProperty("init", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, SelectionInit> Init { get; set; }

        /// <summary>
        /// When true, an invisible voronoi diagram is computed to accelerate discrete
        /// selection. The data value _nearest_ the mouse cursor is added to the selection.
        ///
        /// __See also:__ [`nearest`](https://vega.github.io/vega-lite/docs/nearest.html)
        /// documentation.
        /// </summary>
        [JsonProperty("nearest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nearest { get; set; }

        /// <summary>
        /// A [Vega event stream](https://vega.github.io/vega/docs/event-streams/) (object or
        /// selector) that triggers the selection.
        /// For interval selections, the event stream must specify a [start and
        /// end](https://vega.github.io/vega/docs/event-streams/#between-filters).
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public OnUnion? On { get; set; }

        /// <summary>
        /// With layered and multi-view displays, a strategy that determines how
        /// selections' data queries are resolved when applied in a filter transform,
        /// conditional encoding rule, or scale domain.
        ///
        /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
        /// documentation.
        /// </summary>
        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public SelectionResolution? Resolve { get; set; }
    }

    public partial class FluffyBinding
    {
        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("element", NullValueHandling = NullValueHandling.Ignore)]
        public string Element { get; set; }

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public string Input { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Options { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        [JsonProperty("autocomplete", NullValueHandling = NullValueHandling.Ignore)]
        public string Autocomplete { get; set; }

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public MarkType? Marktype { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source? Source { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }

    public partial class BaseMarkConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Fill { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }

        /// <summary>
        /// The pixel area each the point/circle/square.
        /// For example: in the case of circles, the radius is determined in part by the square root
        /// of the size value.
        ///
        /// __Default value:__ `30`
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// The tooltip text to show upon mouse hover.
        /// </summary>
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public object Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }

    /// <summary>
    /// Tick-Specific Config
    /// </summary>
    public partial class TickConfig
    {
        /// <summary>
        /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
        /// of `"left"`, `"right"`, `"center"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aspect { get; set; }

        /// <summary>
        /// The width of the ticks.
        ///
        /// __Default value:__  3/4 of step (width step for horizontal ticks and height step for
        /// vertical ticks).
        /// </summary>
        [JsonProperty("bandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandSize { get; set; }

        /// <summary>
        /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
        /// `"top"`, `"middle"`, `"bottom"`.
        ///
        /// __Default value:__ `"middle"`
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorUnion? Color { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle bottom right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusBottomRight { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top right corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopLeft { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle top left corner.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadiusTopRight { get; set; }

        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor
        /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        /// <summary>
        /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
        /// This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"ltr"`
        /// </summary>
        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Dir? Dir { get; set; }

        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset
        /// is applied after rotation by the _angle_ property.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ `"…"`
        /// </summary>
        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public string Ellipsis { get; set; }

        /// <summary>
        /// Default Fill Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("filled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filled { get; set; }

        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        /// <summary>
        /// The typeface to set the text in (e.g., `"Helvetica Neue"`).
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font size, in pixels.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// The font style (e.g., `"italic"`).
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Height of the marks.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// Defines how Vega-Lite should handle marks for invalid values (`null` and `NaN`).
        /// - If set to `"filter"` (default), all data items with null values will be skipped (for
        /// line, trail, and area marks) or filtered (for other marks).
        /// - If `null`, all data items are included. In this case, invalid values will be
        /// interpreted as zeroes.
        /// </summary>
        [JsonProperty("invalid", NullValueHandling = NullValueHandling.Ignore)]
        public Invalid? Invalid { get; set; }

        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically
        /// truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ `0`, indicating no limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple
        /// lines. This property will be ignored if the text property is array-valued.
        /// </summary>
        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string LineBreak { get; set; }

        /// <summary>
        /// The height, in pixels, of each line of text in a multi-line text mark.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// For line and trail marks, this `order` property can be set to `null` or `false` to make
        /// the lines use the original order in the data sources.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public Orientation? Orient { get; set; }

        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined
        /// by the `x` and `y` properties.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// Default Stroke Color. This has higher precedence than `config.color`.
        ///
        /// __Default value:__ (None)
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

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
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }

        /// <summary>
        /// Placeholder text if the `text` channel is not specified
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the
        /// `x` and `y` properties. Values for `theta` follow the same convention of `arc` mark
        /// `startAngle` and `endAngle` properties: angles are measured in radians, with `0`
        /// indicating "north".
        /// </summary>
        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Theta { get; set; }

        /// <summary>
        /// Thickness of the tick mark.
        ///
        /// __Default value:__  `1`
        /// </summary>
        [JsonProperty("thickness", NullValueHandling = NullValueHandling.Ignore)]
        public double? Thickness { get; set; }

        /// <summary>
        /// Default relative band size for a time unit. If set to `1`, the bandwidth of the marks
        /// will be equal to the time unit band step.
        /// If set to `0.5`, bandwidth of the marks will be half of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBand", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeUnitBand { get; set; }

        /// <summary>
        /// Default relative band position for a time unit. If set to `0`, the marks will be
        /// positioned at the beginning of the time unit band step.
        /// If set to `0.5`, the marks will be positioned in the middle of the time unit band step.
        /// </summary>
        [JsonProperty("timeUnitBandPosition", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Tooltip { get; set; }

        /// <summary>
        /// Width of the marks.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// X coordinates of the marks, or width of horizontal `"bar"` and `"area"` without specified
        /// `x2` or `width`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        /// <summary>
        /// X2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"width"` for the width of the
        /// plot.
        /// </summary>
        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X2 { get; set; }

        /// <summary>
        /// Y coordinates of the marks, or height of vertical `"bar"` and `"area"` without specified
        /// `y2` or `height`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y { get; set; }

        /// <summary>
        /// Y2 coordinates for ranged `"area"`, `"bar"`, `"rect"`, and  `"rule"`.
        ///
        /// The `value` of this channel can be a number or a string `"height"` for the height of the
        /// plot.
        /// </summary>
        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public YUnion? Y2 { get; set; }
    }

    /// <summary>
    /// Title configuration, which determines default properties for all
    /// [titles](https://vega.github.io/vega-lite/docs/title.html). For a full list of title
    /// configuration options, please see the [corresponding section of the title
    /// documentation](https://vega.github.io/vega-lite/docs/title.html#config).
    /// </summary>
    public partial class ExcludeMappedValueRefBaseTitle
    {
        /// <summary>
        /// Horizontal text alignment for title text. One of `"left"`, `"center"`, or `"right"`.
        /// </summary>
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The anchor position for placing the title and subtitle text. One of `"start"`,
        /// `"middle"`, or `"end"`. For example, with an orientation of top these anchor positions
        /// map to a left-, center-, or right-aligned title.
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? Anchor { get; set; }

        /// <summary>
        /// Angle in degrees of title and subtitle text.
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Vertical text baseline for title and subtitle text. One of `"top"`, `"middle"`,
        /// `"bottom"`, or `"alphabetic"`.
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Text color for title text.
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// Delta offset for title and subtitle text x-coordinate.
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// Delta offset for title and subtitle text y-coordinate.
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// Font name for title text.
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// Font size in pixels for title text.
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Font style for title text.
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// Font weight for title text.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// The reference frame for the anchor position, one of `"bounds"` (to anchor relative to the
        /// full bounding box) or `"group"` (to anchor relative to the group width or height).
        /// </summary>
        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public string Frame { get; set; }

        /// <summary>
        /// The maximum allowed length in pixels of title and subtitle text.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The orthogonal offset in pixels by which to displace the title group from its position
        /// along the edge of the chart.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        /// <summary>
        /// Default title orientation (`"top"`, `"bottom"`, `"left"`, or `"right"`)
        /// </summary>
        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public TitleOrient? Orient { get; set; }

        /// <summary>
        /// Text color for subtitle text.
        /// </summary>
        [JsonProperty("subtitleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleColor { get; set; }

        /// <summary>
        /// Font name for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFont", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFont { get; set; }

        /// <summary>
        /// Font size in pixels for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitleFontSize { get; set; }

        /// <summary>
        /// Font style for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFontStyle { get; set; }

        /// <summary>
        /// Font weight for subtitle text.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("subtitleFontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? SubtitleFontWeight { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line subtitle text.
        /// </summary>
        [JsonProperty("subtitleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitleLineHeight { get; set; }

        /// <summary>
        /// The padding in pixels between title and subtitle text.
        /// </summary>
        [JsonProperty("subtitlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitlePadding { get; set; }
    }

    /// <summary>
    /// Default properties for [single view
    /// plots](https://vega.github.io/vega-lite/docs/spec.html#single).
    /// </summary>
    public partial class ViewConfig
    {
        /// <summary>
        /// Whether the view should be clipped.
        /// </summary>
        [JsonProperty("clip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clip { get; set; }

        /// <summary>
        /// The default height when the plot has a continuous y-field.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("continuousHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousHeight { get; set; }

        /// <summary>
        /// The default width when the plot has a continuous x-field.
        ///
        /// __Default value:__ `200`
        /// </summary>
        [JsonProperty("continuousWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousWidth { get; set; }

        /// <summary>
        /// The radius in pixels of rounded rectangle corners.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// The default height when the plot has either a discrete y-field or no y-field.
        ///
        /// __Default value:__ a step size based on `config.view.step`.
        /// </summary>
        [JsonProperty("discreteHeight", NullValueHandling = NullValueHandling.Ignore)]
        public DiscreteHeightUnion? DiscreteHeight { get; set; }

        /// <summary>
        /// The default width when the plot has either a discrete x-field or no x-field.
        ///
        /// __Default value:__ a step size based on `config.view.step`.
        /// </summary>
        [JsonProperty("discreteWidth", NullValueHandling = NullValueHandling.Ignore)]
        public DiscreteWidthUnion? DiscreteWidth { get; set; }

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
        /// Default height
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// The overall opacity (value between [0,1]).
        ///
        /// __Default value:__ `0.7` for non-aggregate plots with `point`, `tick`, `circle`, or
        /// `square` marks or layered `bar` charts and `1` otherwise.
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Default step size for x-/y- discrete fields.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

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
        /// Default width
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }
    }

    public partial class DiscreteHeightClass
    {
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double Step { get; set; }
    }

    public partial class DiscreteWidthClass
    {
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double Step { get; set; }
    }
}
