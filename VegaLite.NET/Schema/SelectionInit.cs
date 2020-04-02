namespace VegaLite.Schema
{
    public struct SelectionInit
    {
        public bool?    Bool;
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator SelectionInit(bool @bool)
        {
            return new SelectionInit
            {
                Bool = @bool
            };
        }

        public static implicit operator SelectionInit(DateTime dateTime)
        {
            return new SelectionInit
            {
                DateTime = dateTime
            };
        }

        public static implicit operator SelectionInit(double @double)
        {
            return new SelectionInit
            {
                Double = @double
            };
        }

        public static implicit operator SelectionInit(string @string)
        {
            return new SelectionInit
            {
                String = @string
            };
        }

        public bool IsNull { get { return Bool == null && DateTime == null && Double == null && String == null; } }
    }
}
