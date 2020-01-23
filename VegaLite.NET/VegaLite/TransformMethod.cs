namespace VegaLite
{
    /// <summary>
    /// The imputation method to use for the field value of imputed data objects.
    /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
    ///
    /// __Default value:__  `"value"`
    ///
    /// The functional form of the regression model. One of `"linear"`, `"log"`, `"exp"`,
    /// `"pow"`, `"quad"`, or `"poly"`.
    ///
    /// __Default value:__ `"linear"`
    /// </summary>
    public enum TransformMethod { Exp, Linear, Log, Max, Mean, Median, Min, Poly, Pow, Quad, Value };
}