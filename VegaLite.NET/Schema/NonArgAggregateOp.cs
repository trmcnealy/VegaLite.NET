namespace VegaLite.Schema
{
    /// <summary>
    /// An [aggregate operation](https://vega.github.io/vega-lite/docs/aggregate.html#ops) to
    /// perform on the field prior to sorting (e.g., `"count"`, `"mean"` and `"median"`).
    /// An aggregation is required when there are multiple values of the sort field for each
    /// encoded data field.
    /// The input data objects will be aggregated, grouped by the encoded data field.
    ///
    /// For a full list of operations, please see the documentation for
    /// [aggregate](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
    ///
    /// __Default value:__ `"sum"` for stacked plots. Otherwise, `"mean"`.
    /// </summary>
    public enum NonArgAggregateOp
    {
        Average,
        Ci0,
        Ci1,
        Count,
        Distinct,
        Max,
        Mean,
        Median,
        Min,
        Missing,
        Q1,
        Q3,
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
