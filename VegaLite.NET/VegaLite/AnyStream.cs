using System.Collections.Generic;

namespace VegaLite
{
    public struct AnyStream
    {
        public List<object>  AnythingArray;
        public double?       Double;
        public AnyBinding Binding;
        public string        String;

        public static implicit operator AnyStream(List<object>  anythingArray) => new AnyStream { AnythingArray = anythingArray };
        public static implicit operator AnyStream(double        @double)        => new AnyStream { Double        = @double };
        public static implicit operator AnyStream(AnyBinding binding) => new AnyStream { Binding = binding };
        public static implicit operator AnyStream(string        @string)        => new AnyStream { String        = @string };
    }
}