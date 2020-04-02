namespace VegaLite.Schema
{
    public struct TickCount
    {
        public double?       Double;
        public TimeInterval? Enum;

        public static implicit operator TickCount(double @double)
        {
            return new TickCount
            {
                Double = @double
            };
        }

        public static implicit operator TickCount(TimeInterval @enum)
        {
            return new TickCount
            {
                Enum = @enum
            };
        }
    }
}
