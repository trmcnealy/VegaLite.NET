using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// The default definition for a
    /// [`multi`](https://vega.github.io/vega-lite/docs/selection.html#type) selection. All
    /// properties and transformations
    /// for a multi selection definition (except `type`) may be specified here.
    ///
    /// For instance, setting `multi` to `{"toggle": "event.altKey"}` adds additional values to
    /// multi selections when clicking with the alt-key pressed by default.
    /// </summary>
    public class MultiSelectionConfig
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
        [JsonProperty("bind",
                      NullValueHandling = NullValueHandling.Ignore)]
        public LegendBinding? Bind { get; set; }

        /// <summary>
        /// Clears the selection, emptying it of all values. Can be a
        /// [Event Stream](https://vega.github.io/vega/docs/event-streams/) or `false` to disable.
        ///
        /// __Default value:__ `dblclick`.
        ///
        /// __See also:__ [`clear`](https://vega.github.io/vega-lite/docs/clear.html) documentation.
        /// </summary>
        [JsonProperty("clear",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ClearUnion? Clear { get; set; }

        /// <summary>
        /// By default, `all` data values are considered to lie within an empty selection.
        /// When set to `none`, empty selections contain no data values.
        /// </summary>
        [JsonProperty("empty",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Empty? Empty { get; set; }

        /// <summary>
        /// An array of encoding channels. The corresponding data field values
        /// must match for a data tuple to fall within the selection.
        ///
        /// __See also:__ [`encodings`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("encodings",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleDefUnitChannel> Encodings { get; set; }

        /// <summary>
        /// An array of field names whose values must match for a data tuple to
        /// fall within the selection.
        ///
        /// __See also:__ [`fields`](https://vega.github.io/vega-lite/docs/project.html)
        /// documentation.
        /// </summary>
        [JsonProperty("fields",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Initialize the selection with a mapping between [projected channels or field
        /// names](https://vega.github.io/vega-lite/docs/project.html) and an initial
        /// value (or array of values).
        ///
        /// __See also:__ [`init`](https://vega.github.io/vega-lite/docs/init.html) documentation.
        /// </summary>
        [JsonProperty("init",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, SelectionInit>> Init { get; set; }

        /// <summary>
        /// When true, an invisible voronoi diagram is computed to accelerate discrete
        /// selection. The data value _nearest_ the mouse cursor is added to the selection.
        ///
        /// __See also:__ [`nearest`](https://vega.github.io/vega-lite/docs/nearest.html)
        /// documentation.
        /// </summary>
        [JsonProperty("nearest",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nearest { get; set; }

        /// <summary>
        /// A [Vega event stream](https://vega.github.io/vega/docs/event-streams/) (object or
        /// selector) that triggers the selection.
        /// For interval selections, the event stream must specify a [start and
        /// end](https://vega.github.io/vega/docs/event-streams/#between-filters).
        /// </summary>
        [JsonProperty("on",
                      NullValueHandling = NullValueHandling.Ignore)]
        public OnUnion? On { get; set; }

        /// <summary>
        /// With layered and multi-view displays, a strategy that determines how
        /// selections' data queries are resolved when applied in a filter transform,
        /// conditional encoding rule, or scale domain.
        ///
        /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
        /// documentation.
        /// </summary>
        [JsonProperty("resolve",
                      NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("toggle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Translate? Toggle { get; set; }
    }
}
