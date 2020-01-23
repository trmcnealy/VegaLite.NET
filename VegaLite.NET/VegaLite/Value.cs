namespace VegaLite
{
    public struct Value
    {
        public bool?          Bool;
        public double?        Double;
        public string         String;
        public TooltipContent TooltipContent;

        public static implicit operator Value(bool           Bool)           => new Value { Bool           = Bool };
        public static implicit operator Value(double         Double)         => new Value { Double         = Double };
        public static implicit operator Value(string         String)         => new Value { String         = String };
        public static implicit operator Value(TooltipContent TooltipContent) => new Value { TooltipContent = TooltipContent };
        public                          bool IsNull                          => Bool == null && TooltipContent == null && Double == null && String == null;
    }
}