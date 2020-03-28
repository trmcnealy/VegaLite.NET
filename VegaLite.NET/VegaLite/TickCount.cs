namespace VegaLite
{
    public struct TickCount
    {
        public double?       Double;
        public TimeInterval? Enum;

        public static implicit operator TickCount(double       @double) => new TickCount { Double = @double };
        public static implicit operator TickCount(TimeInterval @enum)   => new TickCount { Enum   = @enum };
    }
}