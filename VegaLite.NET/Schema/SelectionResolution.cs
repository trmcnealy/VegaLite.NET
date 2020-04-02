namespace VegaLite.Schema
{
    /// <summary>
    /// With layered and multi-view displays, a strategy that determines how
    /// selections' data queries are resolved when applied in a filter transform,
    /// conditional encoding rule, or scale domain.
    ///
    /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
    /// documentation.
    /// </summary>
    public enum SelectionResolution
    {
        Global,
        Intersect,
        Union
    };
}
