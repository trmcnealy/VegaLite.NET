namespace VegaLite.Schema
{
    public struct Equal
    {
        public bool?    Bool;
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator Equal(bool @bool)
        {
            return new Equal
            {
                Bool = @bool
            };
        }

        public static implicit operator Equal(DateTime dateTime)
        {
            return new Equal
            {
                DateTime = dateTime
            };
        }

        public static implicit operator Equal(double @double)
        {
            return new Equal
            {
                Double = @double
            };
        }

        public static implicit operator Equal(string @string)
        {
            return new Equal
            {
                String = @string
            };
        }
    }
}
