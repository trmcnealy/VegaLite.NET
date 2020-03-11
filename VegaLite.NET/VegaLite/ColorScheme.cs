using System.Collections.Generic;

namespace VegaLite
{
    public struct ColorScheme
    {
        public SignalRef SignalRef;
        public string          String;
        public List<string>    StringArray;

        public static implicit operator ColorScheme(SignalRef SignalRef) => new ColorScheme { SignalRef = SignalRef };
        public static implicit operator ColorScheme(string          String)          => new ColorScheme { String          = String };
        public static implicit operator ColorScheme(List<string>    StringArray)     => new ColorScheme { StringArray     = StringArray };
    }
}