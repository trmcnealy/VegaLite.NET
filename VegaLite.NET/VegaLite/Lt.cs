namespace VegaLite
{
    public struct Lt
    {
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator Lt(DateTime dateTime) => new Lt { DateTime = dateTime };
        public static implicit operator Lt(double   @double)   => new Lt { Double   = @double };
        public static implicit operator Lt(string   @string)   => new Lt { String   = @string };
    }
}