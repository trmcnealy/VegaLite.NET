namespace VegaLite
{
    public struct XUnion
    {
        public double?      Double;
        public WidthValue? Enum;

        public static implicit operator XUnion(double      Double) => new XUnion { Double = Double };
        public static implicit operator XUnion(WidthValue Enum)   => new XUnion { Enum   = Enum };
    }
}