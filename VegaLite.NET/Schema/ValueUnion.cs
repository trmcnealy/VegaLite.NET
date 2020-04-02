namespace VegaLite.Schema
{
    public struct ValueUnion
    {
        public string              String;
        public ValueLinearGradient ValueLinearGradient;

        public static implicit operator ValueUnion(string @string)
        {
            return new ValueUnion
            {
                String = @string
            };
        }

        public static implicit operator ValueUnion(ValueLinearGradient valueLinearGradient)
        {
            return new ValueUnion
            {
                ValueLinearGradient = valueLinearGradient
            };
        }

        public bool IsNull { get { return ValueLinearGradient == null && String == null; } }
    }
}
