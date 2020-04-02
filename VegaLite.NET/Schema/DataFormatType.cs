namespace VegaLite.Schema
{
    /// <summary>
    /// Type of input data: `"json"`, `"csv"`, `"tsv"`, `"dsv"`.
    ///
    /// __Default value:__  The default format type is determined by the extension of the file
    /// URL.
    /// If no extension is detected, `"json"` will be used by default.
    /// </summary>
    public enum DataFormatType
    {
        Csv,
        Dsv,
        Json,
        Topojson,
        Tsv
    }

    public static class DataFormatTypeExtensions
    {
        public static string GetString(this DataFormatType dataFormatType)
        {
            switch(dataFormatType)
            {
                case DataFormatType.Csv: return "csv";
                case DataFormatType.Dsv: return "dsv";
                case DataFormatType.Json: return "json";
                case DataFormatType.Topojson: return "topojson";
                case DataFormatType.Tsv: return "tsv";
                default:
                    return null;
            }
        }
    }
}
