using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct AnyStream
    {
        public List<object> AnythingArray;
        public double?      Double;
        public AnyBinding   Binding;
        public string       String;

        public static implicit operator AnyStream(List<object> anythingArray)
        {
            return new AnyStream
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator AnyStream(double @double)
        {
            return new AnyStream
            {
                Double = @double
            };
        }

        public static implicit operator AnyStream(AnyBinding binding)
        {
            return new AnyStream
            {
                Binding = binding
            };
        }

        public static implicit operator AnyStream(string @string)
        {
            return new AnyStream
            {
                String = @string
            };
        }
    }
}
