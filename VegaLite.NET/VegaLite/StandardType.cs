namespace VegaLite
{
    /// <summary>
    /// The encoded field's type of measurement (`"quantitative"`, `"temporal"`, `"ordinal"`, or
    /// `"nominal"`).
    /// It can also be a `"geojson"` type for encoding
    /// ['geoshape'](https://vega.github.io/vega-lite/docs/geoshape.html).
    ///
    ///
    /// __Note:__
    ///
    /// - DataSource values for a temporal field can be either a date-time string (e.g., `"2015-03-07
    /// 12:32:17"`, `"17:01"`, `"2015-03-16"`. `"2015"`) or a timestamp number (e.g.,
    /// `1552199579097`).
    /// - DataSource `type` describes the semantics of the data rather than the primitive data types
    /// (number, string, etc.). The same primitive data type can have different types of
    /// measurement. For example, numeric data can represent quantitative, ordinal, or nominal
    /// data.
    /// - When using with [`bin`](https://vega.github.io/vega-lite/docs/bin.html), the `type`
    /// property can be either `"quantitative"` (for using a linear bin scale) or [`"ordinal"`
    /// (for using an ordinal bin
    /// scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html), the
    /// `type` property can be either `"temporal"` (for using a temporal scale) or [`"ordinal"`
    /// (for using an ordinal scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html),
    /// the `type` property refers to the post-aggregation data type. For example, we can
    /// calculate count `distinct` of a categorical field `"cat"` using `{"aggregate":
    /// "distinct", "field": "cat", "type": "quantitative"}`. The `"type"` of the aggregate
    /// output is `"quantitative"`.
    /// - Secondary channels (e.g., `x2`, `y2`, `xError`, `yError`) do not have `type` as they
    /// have exactly the same type as their primary channels (e.g., `x`, `y`).
    ///
    /// __See also:__ [`type`](https://vega.github.io/vega-lite/docs/type.html) documentation.
    /// </summary>
    public enum StandardType { Nominal, Ordinal, Quantitative, Temporal };
}