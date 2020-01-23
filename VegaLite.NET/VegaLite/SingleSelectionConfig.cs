using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// The default definition for a
    /// [`single`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
    /// properties and transformations
    /// for a single selection definition (except `type`) may be specified here.
    ///
    /// For instance, setting `single` to `{"on": "dblclick"}` populates single selections on
    /// double-click by default.
    /// </summary>
    public class SingleSelectionConfig
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
}