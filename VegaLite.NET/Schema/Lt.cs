namespace VegaLite.Schema
{
    public struct Lt
    {
        public DateTime DateTime;
        public double?  Double;
        public string   String;

        public static implicit operator Lt(DateTime dateTime)
        {
            return new Lt
            {
                DateTime = dateTime
            };
        }

        public static implicit operator Lt(double @double)
        {
            return new Lt
            {
                Double = @double
            };
        }

        public static implicit operator Lt(string @string)
        {
            return new Lt
            {
                String = @string
            };
        }
    }
}
