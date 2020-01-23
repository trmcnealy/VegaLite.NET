namespace VegaLite
{
    public struct Lt
    {
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator Lt(DateTime DateTime) => new Lt { DateTime = DateTime };
        public static implicit operator Lt(double   Double)   => new Lt { Double   = Double };
        public static implicit operator Lt(string   String)   => new Lt { String   = String };
    }
}