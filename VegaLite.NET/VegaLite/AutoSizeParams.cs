using Newtonsoft.Json;

namespace VegaLite
{
    public class AutoSizeParams
    {
        /// <summary>
        /// Determines how size calculation should be performed, one of `"content"` or `"padding"`.
        /// The default setting (`"content"`) interprets the width and height settings as the data
        /// rectangle (plotting) dimensions, to which padding is then added. In contrast, the
        /// `"padding"` setting includes the padding within the view size calculations, such that the
        /// width and height settings indicate the **total** intended size of the view.
        ///
        /// __Default value__: `"content"`
        /// </summary>
        [JsonProperty("contains", NullValueHandling = NullValueHandling.Ignore)]
        public Contains? Contains { get; set; }

        /// <summary>
        /// A boolean flag indicating if autosize layout should be re-calculated on every view
        /// update.
        ///
        /// __Default value__: `false`
        /// </summary>
        [JsonProperty("resize", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resize { get; set; }

        /// <summary>
        /// The sizing format type. One of `"pad"`, `"fit"`, `"fit-x"`, `"fit-y"`,  or `"none"`. See
        /// the [autosize type](https://vega.github.io/vega-lite/docs/size.html#autosize)
        /// documentation for descriptions of each.
        ///
        /// __Default value__: `"pad"`
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AutosizeType? Type { get; set; }
    }
}