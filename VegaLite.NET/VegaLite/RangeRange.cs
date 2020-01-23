namespace VegaLite
{
    public struct RangeRange
    {
        public double? Double;
        public string  String;

        public static implicit operator RangeRange(double Double) => new RangeRange { Double = Double };
        public static implicit operator RangeRange(string String) => new RangeRange { String = String };
    }
}