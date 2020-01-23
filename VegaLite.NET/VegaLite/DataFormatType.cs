namespace VegaLite
{
    /// <summary>
    /// Type of input data: `"json"`, `"csv"`, `"tsv"`, `"dsv"`.
    ///
    /// __Default value:__  The default format type is determined by the extension of the file
    /// URL.
    /// If no extension is detected, `"json"` will be used by default.
    /// </summary>
    public enum DataFormatType { Csv, Dsv, Json, Topojson, Tsv };
}