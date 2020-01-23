namespace VegaLite
{
    public struct RangeRawArray
    {
        public double?         Double;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator RangeRawArray(double          Double)          => new RangeRawArray { Double          = Double };
        public static implicit operator RangeRawArray(PurpleSignalRef PurpleSignalRef) => new RangeRawArray { PurpleSignalRef = PurpleSignalRef };
    }
}