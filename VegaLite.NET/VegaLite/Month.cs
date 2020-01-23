namespace VegaLite
{
    /// <summary>
    /// One of:
    /// (1) integer value representing the month from `1`-`12`. `1` represents January;
    /// (2) case-insensitive month name (e.g., `"January"`);
    /// (3) case-insensitive, 3-character short month name (e.g., `"Jan"`).
    /// </summary>
    public struct Month
    {
        public double? Double;
        public string  String;

        public static implicit operator Month(double Double) => new Month { Double = Double };
        public static implicit operator Month(string String) => new Month { String = String };
    }
}