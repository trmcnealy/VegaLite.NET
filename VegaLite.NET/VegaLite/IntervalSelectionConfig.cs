using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
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
    public class IntervalSelectionConfig
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
}