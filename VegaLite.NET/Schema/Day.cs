namespace VegaLite.Schema
{
    /// <summary>
    /// Value representing the day of a week. This can be one of:
    /// (1) integer value -- `1` represents Monday;
    /// (2) case-insensitive day name (e.g., `"Monday"`);
    /// (3) case-insensitive, 3-character short day name (e.g., `"Mon"`).
    ///
    /// **Warning:** A DateTime definition object with `day`** should not be combined with
    /// `year`, `quarter`, `month`, or `date`.
    /// </summary>
    public struct Day
    {
        public double? Double;
        public string  String;

        public static implicit operator Day(double @double)
        {
            return new Day
            {
                Double = @double
            };
        }

        public static implicit operator Day(string @string)
        {
            return new Day
            {
                String = @string
            };
        }
    }
}
