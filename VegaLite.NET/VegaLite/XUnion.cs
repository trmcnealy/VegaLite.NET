namespace VegaLite
{
    public struct XUnion
    {
        public double?      Double;
        public WidthValue? Enum;

        public static implicit operator XUnion(double      @double) => new XUnion { Double = @double };
        public static implicit operator XUnion(WidthValue @enum)   => new XUnion { Enum   = @enum };
    }
}