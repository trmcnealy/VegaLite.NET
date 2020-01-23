namespace VegaLite
{
    public struct PurpleRange
    {
        public DateTime DateTime;
        public double?  Double;

        public static implicit operator PurpleRange(DateTime DateTime) => new PurpleRange { DateTime = DateTime };
        public static implicit operator PurpleRange(double   Double)   => new PurpleRange { Double   = Double };
        public                          bool IsNull                    => DateTime == null && Double == null;
    }
}