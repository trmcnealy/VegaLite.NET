namespace VegaLite.Schema
{
    /// <summary>
    /// The format type for labels (`"number"` or `"time"`).
    ///
    /// __Default value:__
    /// - `"time"` for temporal fields and ordinal and nomimal fields with `timeUnit`.
    /// - `"number"` for quantitative fields as well as ordinal and nomimal fields without
    /// `timeUnit`.
    /// </summary>
    public enum FormatType
    {
        Number,
        Time
    };
}
