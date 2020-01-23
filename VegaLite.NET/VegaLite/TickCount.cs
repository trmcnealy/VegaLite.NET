namespace VegaLite
{
    public struct TickCount
    {
        public double?       Double;
        public TimeInterval? Enum;

        public static implicit operator TickCount(double       Double) => new TickCount { Double = Double };
        public static implicit operator TickCount(TimeInterval Enum)   => new TickCount { Enum   = Enum };
    }
}