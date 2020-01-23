namespace VegaLite
{
    public struct ValueUnion
    {
        public string              String;
        public ValueLinearGradient ValueLinearGradient;

        public static implicit operator ValueUnion(string              String)              => new ValueUnion { String              = String };
        public static implicit operator ValueUnion(ValueLinearGradient ValueLinearGradient) => new ValueUnion { ValueLinearGradient = ValueLinearGradient };
        public                          bool IsNull                                         => ValueLinearGradient == null && String == null;
    }
}