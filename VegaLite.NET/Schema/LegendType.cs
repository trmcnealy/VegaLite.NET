namespace VegaLite.Schema
{
    /// <summary>
    /// The type of the legend. Use `"symbol"` to create a discrete legend and `"gradient"` for a
    /// continuous color gradient.
    ///
    /// __Default value:__ `"gradient"` for non-binned quantitative fields and temporal fields;
    /// `"symbol"` otherwise.
    /// </summary>
    public enum LegendType
    {
        Gradient,
        Symbol
    };
}
