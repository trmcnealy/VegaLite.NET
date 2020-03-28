namespace VegaLite
{
    public struct ValueUnion
    {
        public string              String;
        public ValueLinearGradient ValueLinearGradient;

        public static implicit operator ValueUnion(string              @string)              => new ValueUnion { String              = @string };
        public static implicit operator ValueUnion(ValueLinearGradient valueLinearGradient) => new ValueUnion { ValueLinearGradient = valueLinearGradient };
        public                          bool IsNull                                         => ValueLinearGradient == null && String == null;
    }
}