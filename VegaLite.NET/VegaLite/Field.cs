namespace VegaLite
{
    /// <summary>
    /// __Required.__ A string defining the name of the field from which to pull a data value
    /// or an object defining iterated values from the
    /// [`repeat`](https://vega.github.io/vega-lite/docs/repeat.html) operator.
    ///
    /// __See also:__ [`field`](https://vega.github.io/vega-lite/docs/field.html) documentation.
    ///
    /// __Notes:__
    /// 1)  Dots (`.`) and brackets (`[` and `]`) can be used to access nested objects (e.g.,
    /// `"field": "foo.bar"` and `"field": "foo['bar']"`).
    /// If field names contain dots or brackets but are not nested, you can use `\\` to escape
    /// dots and brackets (e.g., `"a\\.b"` and `"a\\[0\\]"`).
    /// See more details about escaping in the [field
    /// documentation](https://vega.github.io/vega-lite/docs/field.html).
    /// 2) `field` is not required if `aggregate` is `count`.
    ///
    /// The data [field](https://vega.github.io/vega-lite/docs/field.html) to sort by.
    ///
    /// __Default value:__ If unspecified, defaults to the field specified in the outer data
    /// reference.
    /// </summary>
    public struct Field
    {
        public RepeatRef RepeatRef;
        public string    String;

        public static implicit operator Field(RepeatRef RepeatRef) => new Field { RepeatRef = RepeatRef };
        public static implicit operator Field(string    String)    => new Field { String    = String };
    }
}