namespace VegaLite
{
    public struct SelectionInit
    {
        public bool?    Bool;
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator SelectionInit(bool     @bool)     => new SelectionInit { Bool     = @bool };
        public static implicit operator SelectionInit(DateTime dateTime) => new SelectionInit { DateTime = dateTime };
        public static implicit operator SelectionInit(double   @double)   => new SelectionInit { Double   = @double };
        public static implicit operator SelectionInit(string   @string)   => new SelectionInit { String   = @string };
        public                          bool IsNull                      => Bool == null && DateTime == null && Double == null && String == null;
    }
}