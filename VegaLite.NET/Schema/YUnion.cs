namespace VegaLite.Schema
{
    public struct YUnion
    {
        public double?      Double;
        public HeightValue? Enum;

        public static implicit operator YUnion(double @double)
        {
            return new YUnion
            {
                Double = @double
            };
        }

        public static implicit operator YUnion(HeightValue @enum)
        {
            return new YUnion
            {
                Enum = @enum
            };
        }
    }
}
