namespace VegaLite.Schema
{
    public struct HeightUnion
    {
        public double?     Double;
        public HeightEnum? Enum;
        public Step        Step;

        public static implicit operator HeightUnion(double @double)
        {
            return new HeightUnion
            {
                Double = @double
            };
        }

        public static implicit operator HeightUnion(HeightEnum @enum)
        {
            return new HeightUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator HeightUnion(Step step)
        {
            return new HeightUnion
            {
                Step = step
            };
        }
    }
}
