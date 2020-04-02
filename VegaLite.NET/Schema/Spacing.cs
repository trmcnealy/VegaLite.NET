namespace VegaLite.Schema
{
    public struct Spacing
    {
        public double?      Double;
        public RowColNumber RowColNumber;

        public static implicit operator Spacing(double @double)
        {
            return new Spacing
            {
                Double = @double
            };
        }

        public static implicit operator Spacing(RowColNumber rowColNumber)
        {
            return new Spacing
            {
                RowColNumber = rowColNumber
            };
        }
    }
}
