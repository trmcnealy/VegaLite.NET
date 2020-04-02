using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// A full layered plot specification, which may contains `encoding` and `projection`
    /// properties that will be applied to underlying unit (single-view) specifications.
    ///
    /// A unit specification, which can contain either [primitive marks or composite
    /// marks](https://vega.github.io/vega-lite/docs/mark.html#types).
    ///
    /// Base interface for a unit (single-view) specification.
    /// </summary>
    public class LayerSpec
    {
        /// <summary>
        /// An object describing the data source. Set to `null` to ignore the parent's data source.
        /// If no data is set, it is derived from the parent.
        /// </summary>
        [JsonProperty("data",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Description of this mark for commenting purpose.
        /// </summary>
        [JsonProperty("description",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// A shared key-value mapping between encoding channels and definition of fields in the
        /// underlying layers.
        ///
        /// A key-value mapping between encoding channels and definition of fields.
        /// </summary>
        [JsonProperty("encoding",
                      NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("height",
                      NullValueHandling = NullValueHandling.Ignore)]
        public HeightUnion? Height { get; set; }

        /// <summary>
        /// Layer or single view specifications to be layered.
        ///
        /// __Note__: Specifications inside `layer` cannot use `row` and `column` channels as
        /// layering facet specifications is not allowed. Instead, use the [facet
        /// operator](https://vega.github.io/vega-lite/docs/facet.html) and place a layer inside a
        /// facet.
        /// </summary>
        [JsonProperty("layer",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<LayerSpec> Layer { get; set; }

        /// <summary>
        /// Name of the visualization for later reference.
        /// </summary>
        [JsonProperty("name",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// An object defining properties of the geographic projection shared by underlying layers.
        ///
        /// An object defining properties of geographic projection, which will be applied to `shape`
        /// path for `"geoshape"` marks
        /// and to `latitude` and `"longitude"` channels for other marks.
        /// </summary>
        [JsonProperty("projection",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Projection Projection { get; set; }

        /// <summary>
        /// Scale, axis, and legend resolutions for view composition specifications.
        /// </summary>
        [JsonProperty("resolve",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Resolve Resolve { get; set; }

        /// <summary>
        /// Title for the plot.
        /// </summary>
        [JsonProperty("title",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LayerTitle? Title { get; set; }

        /// <summary>
        /// An array of data transformations such as filter and new field calculation.
        /// </summary>
        [JsonProperty("transform",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<Transform> Transform { get; set; }

        /// <summary>
        /// An object defining the view background's fill and stroke.
        ///
        /// __Default value:__ none (transparent)
        /// </summary>
        [JsonProperty("view",
                      NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("width",
                      NullValueHandling = NullValueHandling.Ignore)]
        public HeightUnion? Width { get; set; }

        /// <summary>
        /// A string describing the mark type (one of `"bar"`, `"circle"`, `"square"`, `"tick"`,
        /// `"line"`,
        /// `"area"`, `"point"`, `"rule"`, `"geoshape"`, and `"text"`) or a [mark definition
        /// object](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
        /// </summary>
        [JsonProperty("mark",
                      NullValueHandling = NullValueHandling.Ignore)]
        public AnyMark? Mark { get; set; }

        /// <summary>
        /// A key-value mapping between selection names and definitions.
        /// </summary>
        [JsonProperty("selection",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, SelectionDef> Selection { get; set; }
    }
}
