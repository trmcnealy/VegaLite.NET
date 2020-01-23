using System.Collections.Generic;

namespace VegaLite
{
    public struct ColorScheme
    {
        public PurpleSignalRef PurpleSignalRef;
        public string          String;
        public List<string>    StringArray;

        public static implicit operator ColorScheme(PurpleSignalRef PurpleSignalRef) => new ColorScheme { PurpleSignalRef = PurpleSignalRef };
        public static implicit operator ColorScheme(string          String)          => new ColorScheme { String          = String };
        public static implicit operator ColorScheme(List<string>    StringArray)     => new ColorScheme { StringArray     = StringArray };
    }
}