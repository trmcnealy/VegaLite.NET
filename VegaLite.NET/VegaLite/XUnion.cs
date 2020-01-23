namespace VegaLite
{
    public struct XUnion
    {
        public double?      Double;
        public PurpleValue? Enum;

        public static implicit operator XUnion(double      Double) => new XUnion { Double = Double };
        public static implicit operator XUnion(PurpleValue Enum)   => new XUnion { Enum   = Enum };
    }
}