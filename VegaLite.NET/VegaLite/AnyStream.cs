using System.Collections.Generic;

namespace VegaLite
{
    public struct AnyStream
    {
        public List<object>  AnythingArray;
        public double?       Double;
        public AnyBinding Binding;
        public string        String;

        public static implicit operator AnyStream(List<object>  AnythingArray) => new AnyStream { AnythingArray = AnythingArray };
        public static implicit operator AnyStream(double        Double)        => new AnyStream { Double        = Double };
        public static implicit operator AnyStream(AnyBinding binding) => new AnyStream { Binding = binding };
        public static implicit operator AnyStream(string        String)        => new AnyStream { String        = String };
    }
}