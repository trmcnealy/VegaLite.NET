namespace VegaLite.Schema
{
    /// <summary>
    /// The extent of the band. Available options include:
    /// - `"ci"`: Extend the band to the confidence interval of the mean.
    /// - `"stderr"`: The size of band are set to the value of standard error, extending from the
    /// mean.
    /// - `"stdev"`: The size of band are set to the value of standard deviation, extending from
    /// the mean.
    /// - `"iqr"`: Extend the band to the q1 and q3.
    ///
    /// __Default value:__ `"stderr"`.
    ///
    /// The extent of the rule. Available options include:
    /// - `"ci"`: Extend the rule to the confidence interval of the mean.
    /// - `"stderr"`: The size of rule are set to the value of standard error, extending from the
    /// mean.
    /// - `"stdev"`: The size of rule are set to the value of standard deviation, extending from
    /// the mean.
    /// - `"iqr"`: Extend the rule to the q1 and q3.
    ///
    /// __Default value:__ `"stderr"`.
    /// </summary>
    public enum ExtentExtent
    {
        Ci,
        Iqr,
        MinMax,
        Stderr,
        Stdev
    };
}
