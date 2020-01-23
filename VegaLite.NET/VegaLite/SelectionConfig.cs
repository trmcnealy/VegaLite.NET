using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// An object hash for defining default properties for each type of selections.
    /// </summary>
    public class SelectionConfig
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
}