namespace VegaLite
{
    public struct PurpleRange
    {
        public DateTime DateTime;
        public double?  Double;

        public static implicit operator PurpleRange(DateTime dateTime) => new PurpleRange { DateTime = dateTime };
        public static implicit operator PurpleRange(double   @double)   => new PurpleRange { Double   = @double };
        public                          bool IsNull                    => DateTime == null && Double == null;
    }
}