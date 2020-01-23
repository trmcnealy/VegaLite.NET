namespace VegaLite
{
    public struct SelectionInit
    {
        public bool?    Bool;
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator SelectionInit(bool     Bool)     => new SelectionInit { Bool     = Bool };
        public static implicit operator SelectionInit(DateTime DateTime) => new SelectionInit { DateTime = DateTime };
        public static implicit operator SelectionInit(double   Double)   => new SelectionInit { Double   = Double };
        public static implicit operator SelectionInit(string   String)   => new SelectionInit { String   = String };
        public                          bool IsNull                      => Bool == null && DateTime == null && Double == null && String == null;
    }
}