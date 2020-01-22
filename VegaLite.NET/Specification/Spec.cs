using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// A specification of the view that gets repeated.
    ///
    /// Any specification in Vega-Lite.
    ///
    /// Unit spec that can have a composite mark and row or column channels (shorthand for a
    /// facet spec).
    ///
    /// A full layered plot specification, which may contains `encoding` and `projection`
    /// properties that will be applied to underlying unit (single-view) specifications.
    ///
    /// Base interface for a facet specification.
    ///
    /// Base interface for a repeat specification.
    ///
    /// Base interface for a generalized concatenation specification.
    ///
    /// Base interface for a vertical concatenation specification.
    ///
    /// Base interface for a horizontal concatenation specification.
    /// </summary>
    public partial class Spec
    {
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
        public SpecClass SpecSpec { get; set; }

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
}