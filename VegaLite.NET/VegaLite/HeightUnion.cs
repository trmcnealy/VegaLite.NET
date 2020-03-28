namespace VegaLite
{
    public struct HeightUnion
    {
        public double?     Double;
        public HeightEnum? Enum;
        public Step        Step;

        public static implicit operator HeightUnion(double     @double) => new HeightUnion { Double = @double };
        public static implicit operator HeightUnion(HeightEnum @enum)   => new HeightUnion { Enum   = @enum };
        public static implicit operator HeightUnion(Step       step)   => new HeightUnion { Step   = step };
    }
}