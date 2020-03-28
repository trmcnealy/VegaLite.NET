namespace VegaLite
{
    public struct Equal
    {
        public bool?    Bool;
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator Equal(bool     @bool)     => new Equal { Bool     = @bool };
        public static implicit operator Equal(DateTime dateTime) => new Equal { DateTime = dateTime };
        public static implicit operator Equal(double   @double)   => new Equal { Double   = @double };
        public static implicit operator Equal(string   @string)   => new Equal { String   = @string };
    }
}