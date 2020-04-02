namespace VegaLite.Schema
{
    public struct RangeRange
    {
        public double? Double;
        public string  String;

        public static implicit operator RangeRange(double @double)
        {
            return new RangeRange
            {
                Double = @double
            };
        }

        public static implicit operator RangeRange(string @string)
        {
            return new RangeRange
            {
                String = @string
            };
        }
    }
}
