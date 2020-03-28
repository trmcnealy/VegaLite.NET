namespace VegaLite
{
    public struct RangeRawArray
    {
        public double?         Double;
        public SignalRef SignalRef;

        public static implicit operator RangeRawArray(double          @double)          => new RangeRawArray { Double          = @double };
        public static implicit operator RangeRawArray(SignalRef signalRef) => new RangeRawArray { SignalRef = signalRef };
    }
}