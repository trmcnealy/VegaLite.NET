namespace VegaLite
{
    public struct YUnion
    {
        public double?      Double;
        public HeightValue? Enum;

        public static implicit operator YUnion(double      Double) => new YUnion { Double = Double };
        public static implicit operator YUnion(HeightValue Enum)   => new YUnion { Enum   = Enum };
    }
}