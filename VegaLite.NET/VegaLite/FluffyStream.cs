using System.Collections.Generic;

namespace VegaLite
{
    public struct FluffyStream
    {
        public List<object>  AnythingArray;
        public double?       Double;
        public FluffyBinding FluffyBinding;
        public string        String;

        public static implicit operator FluffyStream(List<object>  AnythingArray) => new FluffyStream { AnythingArray = AnythingArray };
        public static implicit operator FluffyStream(double        Double)        => new FluffyStream { Double        = Double };
        public static implicit operator FluffyStream(FluffyBinding FluffyBinding) => new FluffyStream { FluffyBinding = FluffyBinding };
        public static implicit operator FluffyStream(string        String)        => new FluffyStream { String        = String };
    }
}