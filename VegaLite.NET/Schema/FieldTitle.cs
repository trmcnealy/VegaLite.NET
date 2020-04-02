namespace VegaLite.Schema
{
    /// <summary>
    /// Defines how Vega-Lite generates title for fields. There are three possible styles:
    /// - `"verbal"` (Default) - displays function in a verbal style (e.g., "Sum of field",
    /// "Year-month of date", "field (binned)").
    /// - `"function"` - displays function using parentheses and capitalized texts (e.g.,
    /// "SUM(field)", "YEARMONTH(date)", "BIN(field)").
    /// - `"plain"` - displays only the field name without functions (e.g., "field", "date",
    /// "field").
    /// </summary>
    public enum FieldTitle
    {
        Functional,
        Plain,
        Verbal
    };
}
