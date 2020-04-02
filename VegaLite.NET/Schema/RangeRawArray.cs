namespace VegaLite.Schema
{
    public struct RangeRawArray
    {
        public double?   Double;
        public SignalRef SignalRef;

        public static implicit operator RangeRawArray(double @double)
        {
            return new RangeRawArray
            {
                Double = @double
            };
        }

        public static implicit operator RangeRawArray(SignalRef signalRef)
        {
            return new RangeRawArray
            {
                SignalRef = signalRef
            };
        }
    }
}
