using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Sort order for the encoded field.
    ///
    /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
    /// `"descending"`.
    ///
    /// For discrete fields, `sort` can be one of the following:
    /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
    /// JavaScript.
    /// - [A string indicating an encoding channel name to sort
    /// by](https://vega.github.io/vega-lite/docs/sort.html#sort-by-encoding) (e.g., `"x"` or
    /// `"y"`) with an optional minus prefix for descending sort (e.g., `"-x"` to sort by
    /// x-field, descending). This channel string is short-form of [a sort-by-encoding
    /// definition](https://vega.github.io/vega-lite/docs/sort.html#sort-by-encoding). For
    /// example, `"sort": "-x"` is equivalent to `"sort": {"encoding": "x", "order":
    /// "descending"}`.
    /// - [A sort field definition](https://vega.github.io/vega-lite/docs/sort.html#sort-field)
    /// for sorting by another field.
    /// - [An array specifying the field values in preferred
    /// order](https://vega.github.io/vega-lite/docs/sort.html#sort-array). In this case, the
    /// sort order will obey the values in the array, followed by any unspecified values in their
    /// original order. For discrete time field, values in the sort array can be [date-time
    /// definition objects](types#datetime). In addition, for time units `"month"` and `"day"`,
    /// the values can be the month or day names (case insensitive) or their 3-letter initials
    /// (e.g., `"Mon"`, `"Tue"`).
    /// - `null` indicating no sort.
    ///
    /// __Default value:__ `"ascending"`
    ///
    /// __Note:__ `null` and sorting by another channel is not supported for `row` and `column`.
    ///
    /// __See also:__ [`sort`](https://vega.github.io/vega-lite/docs/sort.html) documentation.
    /// </summary>
    public struct SortUnion
    {
        public List<Equal>       AnythingArray;
        public EncodingSortField EncodingSortField;
        public Sort?             Enum;

        public static implicit operator SortUnion(List<Equal>       AnythingArray)     => new SortUnion { AnythingArray     = AnythingArray };
        public static implicit operator SortUnion(EncodingSortField EncodingSortField) => new SortUnion { EncodingSortField = EncodingSortField };
        public static implicit operator SortUnion(Sort              Enum)              => new SortUnion { Enum              = Enum };
        public                          bool IsNull                                    => AnythingArray == null && EncodingSortField == null && Enum == null;
    }
}