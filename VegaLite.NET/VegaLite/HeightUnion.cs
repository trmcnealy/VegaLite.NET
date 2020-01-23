namespace VegaLite
{
    public struct HeightUnion
    {
        public double?     Double;
        public HeightEnum? Enum;
        public Step        Step;

        public static implicit operator HeightUnion(double     Double) => new HeightUnion { Double = Double };
        public static implicit operator HeightUnion(HeightEnum Enum)   => new HeightUnion { Enum   = Enum };
        public static implicit operator HeightUnion(Step       Step)   => new HeightUnion { Step   = Step };
    }
}