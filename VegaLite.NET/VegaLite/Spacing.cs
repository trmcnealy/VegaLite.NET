namespace VegaLite
{
    public struct Spacing
    {
        public double?      Double;
        public RowColNumber RowColNumber;

        public static implicit operator Spacing(double       @double)       => new Spacing { Double       = @double };
        public static implicit operator Spacing(RowColNumber rowColNumber) => new Spacing { RowColNumber = rowColNumber };
    }
}