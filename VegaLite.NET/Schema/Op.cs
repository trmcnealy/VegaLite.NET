namespace VegaLite.Schema
{
    /// <summary>
    /// The window or aggregation operation to apply within a window (e.g., `"rank"`, `"lead"`,
    /// `"sum"`, `"average"` or `"count"`). See the list of all supported operations
    /// [here](https://vega.github.io/vega-lite/docs/window.html#ops).
    ///
    /// The aggregation operation to apply to the fields (e.g., `"sum"`, `"average"`, or
    /// `"count"`).
    /// See the [full list of supported aggregation
    /// operations](https://vega.github.io/vega-lite/docs/aggregate.html#ops)
    /// for more information.
    ///
    /// The aggregation operation to apply (e.g., `"sum"`, `"average"` or `"count"`). See the
    /// list of all supported operations
    /// [here](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
    /// </summary>
    public enum Op
    {
        Argmax,
        Argmin,
        Average,
        Ci0,
        Ci1,
        Count,
        CumeDist,
        DenseRank,
        Distinct,
        FirstValue,
        Lag,
        LastValue,
        Lead,
        Max,
        Mean,
        Median,
        Min,
        Missing,
        NthValue,
        Ntile,
        PercentRank,
        Q1,
        Q3,
        Rank,
        RowNumber,
        Stderr,
        Stdev,
        Stdevp,
        Sum,
        Valid,
        Values,
        Variance,
        Variancep
    };
}
