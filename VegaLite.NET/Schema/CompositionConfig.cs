using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Default configuration for all concatenation view composition operators (`concat`,
    /// `hconcat`, and `vconcat`)
    ///
    /// Default configuration for the `facet` view composition operator
    ///
    /// Default configuration for the `repeat` view composition operator
    /// </summary>
    public class CompositionConfig
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
        [JsonProperty("columns",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Columns { get; set; }

        /// <summary>
        /// The default spacing in pixels between composed sub-views.
        ///
        /// __Default value__: `20`
        /// </summary>
        [JsonProperty("spacing",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Spacing { get; set; }
    }
}
