namespace VegaLite
{
    /// <summary>
    /// Determines the default event processing and data query for the selection. Vega-Lite
    /// currently supports three selection types:
    ///
    /// - `"single"` -- to select a single discrete data value on `click`.
    /// - `"multi"` -- to select multiple discrete data value; the first value is selected on
    /// `click` and additional values toggled on shift-`click`.
    /// - `"interval"` -- to select a continuous range of data values on `drag`.
    /// </summary>
    public enum SelectionDefType { Interval, Multi, Single };
}