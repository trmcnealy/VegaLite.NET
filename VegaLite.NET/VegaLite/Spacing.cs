namespace VegaLite
{
    public struct Spacing
    {
        public double?      Double;
        public RowColNumber RowColNumber;

        public static implicit operator Spacing(double       Double)       => new Spacing { Double       = Double };
        public static implicit operator Spacing(RowColNumber RowColNumber) => new Spacing { RowColNumber = RowColNumber };
    }
}