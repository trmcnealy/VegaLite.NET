namespace VegaLite
{
    /// <summary>
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
    public enum AggregateOp { Argmax, Argmin, Average, Ci0, Ci1, Count, Distinct, Max, Mean, Median, Min, Missing, Q1, Q3, Stderr, Stdev, Stdevp, Sum, Valid, Values, Variance, Variancep };
}