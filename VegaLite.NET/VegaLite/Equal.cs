namespace VegaLite
{
    public struct Equal
    {
        public bool?    Bool;
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator Equal(bool     Bool)     => new Equal { Bool     = Bool };
        public static implicit operator Equal(DateTime DateTime) => new Equal { DateTime = DateTime };
        public static implicit operator Equal(double   Double)   => new Equal { Double   = Double };
        public static implicit operator Equal(string   String)   => new Equal { String   = String };
    }
}