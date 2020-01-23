using System.Collections.Generic;

namespace VegaLite
{
    public struct PurpleStream
    {
        public List<object>  AnythingArray;
        public double?       Double;
        public PurpleBinding PurpleBinding;
        public string        String;

        public static implicit operator PurpleStream(List<object>  AnythingArray) => new PurpleStream { AnythingArray = AnythingArray };
        public static implicit operator PurpleStream(double        Double)        => new PurpleStream { Double        = Double };
        public static implicit operator PurpleStream(PurpleBinding PurpleBinding) => new PurpleStream { PurpleBinding = PurpleBinding };
        public static implicit operator PurpleStream(string        String)        => new PurpleStream { String        = String };
    }
}