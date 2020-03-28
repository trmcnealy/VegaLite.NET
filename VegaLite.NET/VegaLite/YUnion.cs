namespace VegaLite
{
    public struct YUnion
    {
        public double?      Double;
        public HeightValue? Enum;

        public static implicit operator YUnion(double      @double) => new YUnion { Double = @double };
        public static implicit operator YUnion(HeightValue @enum)   => new YUnion { Enum   = @enum };
    }
}