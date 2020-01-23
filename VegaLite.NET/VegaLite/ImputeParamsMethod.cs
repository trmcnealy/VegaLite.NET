namespace VegaLite
{
    /// <summary>
    /// The imputation method to use for the field value of imputed data objects.
    /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
    ///
    /// __Default value:__  `"value"`
    /// </summary>
    public enum ImputeParamsMethod { Max, Mean, Median, Min, Value };
}