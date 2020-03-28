namespace VegaLite
{
    public struct RangeRange
    {
        public double? Double;
        public string  String;

        public static implicit operator RangeRange(double @double) => new RangeRange { Double = @double };
        public static implicit operator RangeRange(string @string) => new RangeRange { String = @string };
    }
}