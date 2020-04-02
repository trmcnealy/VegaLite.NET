namespace VegaLite.Schema
{
    /// <summary>
    /// A string describing the mark type (one of `"bar"`, `"circle"`, `"square"`, `"tick"`,
    /// `"line"`,
    /// `"area"`, `"point"`, `"rule"`, `"geoshape"`, and `"text"`) or a [mark definition
    /// object](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
    /// </summary>
    public struct AnyMark
    {
        public BoxPlotDefClass BoxPlotDefClass;
        public BoxPlot?        Enum;

        public static implicit operator AnyMark(BoxPlotDefClass boxPlotDefClass)
        {
            return new AnyMark
            {
                BoxPlotDefClass = boxPlotDefClass
            };
        }

        public static implicit operator AnyMark(BoxPlot @enum)
        {
            return new AnyMark
            {
                Enum = @enum
            };
        }
    }
}
