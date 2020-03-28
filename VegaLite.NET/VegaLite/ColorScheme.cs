using System.Collections.Generic;

namespace VegaLite
{
    public struct ColorScheme
    {
        public SignalRef SignalRef;
        public string          String;
        public List<string>    StringArray;

        public static implicit operator ColorScheme(SignalRef signalRef) => new ColorScheme { SignalRef = signalRef };
        public static implicit operator ColorScheme(string          @string)          => new ColorScheme { String          = @string };
        public static implicit operator ColorScheme(List<string>    stringArray)     => new ColorScheme { StringArray     = stringArray };
    }
}