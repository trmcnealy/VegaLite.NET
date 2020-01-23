namespace VegaLite
{
    public struct YUnion
    {
        public double?      Double;
        public FluffyValue? Enum;

        public static implicit operator YUnion(double      Double) => new YUnion { Double = Double };
        public static implicit operator YUnion(FluffyValue Enum)   => new YUnion { Enum   = Enum };
    }
}