namespace VegaLite.Schema
{
    public struct XUnion
    {
        public double?     Double;
        public WidthValue? Enum;

        public static implicit operator XUnion(double @double)
        {
            return new XUnion
            {
                Double = @double
            };
        }

        public static implicit operator XUnion(WidthValue @enum)
        {
            return new XUnion
            {
                Enum = @enum
            };
        }
    }
}
