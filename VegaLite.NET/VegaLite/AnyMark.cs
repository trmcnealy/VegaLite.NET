﻿namespace VegaLite
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

        public static implicit operator AnyMark(BoxPlotDefClass boxPlotDefClass) => new AnyMark { BoxPlotDefClass = boxPlotDefClass };
        public static implicit operator AnyMark(BoxPlot         @enum)            => new AnyMark { Enum            = @enum };
    }
}