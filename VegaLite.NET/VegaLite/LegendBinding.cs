namespace VegaLite
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
    public struct LegendBinding
    {
        public LegendBindingEnum?  Enum;
        public LegendStreamBinding LegendStreamBinding;

        public static implicit operator LegendBinding(LegendBindingEnum   Enum)                => new LegendBinding { Enum                = Enum };
        public static implicit operator LegendBinding(LegendStreamBinding LegendStreamBinding) => new LegendBinding { LegendStreamBinding = LegendStreamBinding };
    }
}