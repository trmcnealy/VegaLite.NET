namespace VegaLite.Schema
{
    public struct Value
    {
        public bool?          Bool;
        public double?        Double;
        public string         String;
        public TooltipContent TooltipContent;

        public static implicit operator Value(bool @bool)
        {
            return new Value
            {
                Bool = @bool
            };
        }

        public static implicit operator Value(double @double)
        {
            return new Value
            {
                Double = @double
            };
        }

        public static implicit operator Value(string @string)
        {
            return new Value
            {
                String = @string
            };
        }

        public static implicit operator Value(TooltipContent tooltipContent)
        {
            return new Value
            {
                TooltipContent = tooltipContent
            };
        }

        public bool IsNull { get { return Bool == null && TooltipContent == null && Double == null && String == null; } }
    }
}
