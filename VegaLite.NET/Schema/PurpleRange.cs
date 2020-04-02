namespace VegaLite.Schema
{
    public struct PurpleRange
    {
        public DateTime DateTime;
        public double?  Double;

        public static implicit operator PurpleRange(DateTime dateTime)
        {
            return new PurpleRange
            {
                DateTime = dateTime
            };
        }

        public static implicit operator PurpleRange(double @double)
        {
            return new PurpleRange
            {
                Double = @double
            };
        }

        public bool IsNull { get { return DateTime == null && Double == null; } }
    }
}
