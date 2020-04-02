namespace VegaLite.Schema
{
    public struct SpecificationCenter
    {
        public bool?         Bool;
        public RowColBoolean RowColBoolean;

        public static implicit operator SpecificationCenter(bool @bool)
        {
            return new SpecificationCenter
            {
                Bool = @bool
            };
        }

        public static implicit operator SpecificationCenter(RowColBoolean rowColBoolean)
        {
            return new SpecificationCenter
            {
                RowColBoolean = rowColBoolean
            };
        }
    }
}
