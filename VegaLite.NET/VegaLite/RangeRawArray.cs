namespace VegaLite
{
    public struct RangeRawArray
    {
        public double?         Double;
        public SignalRef SignalRef;

        public static implicit operator RangeRawArray(double          Double)          => new RangeRawArray { Double          = Double };
        public static implicit operator RangeRawArray(SignalRef SignalRef) => new RangeRawArray { SignalRef = SignalRef };
    }
}