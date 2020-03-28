namespace VegaLite
{
    public struct Value
    {
        public bool?          Bool;
        public double?        Double;
        public string         String;
        public TooltipContent TooltipContent;

        public static implicit operator Value(bool           @bool)           => new Value { Bool           = @bool };
        public static implicit operator Value(double         @double)         => new Value { Double         = @double };
        public static implicit operator Value(string         @string)         => new Value { String         = @string };
        public static implicit operator Value(TooltipContent tooltipContent) => new Value { TooltipContent = tooltipContent };
        public                          bool IsNull                          => Bool == null && TooltipContent == null && Double == null && String == null;
    }
}