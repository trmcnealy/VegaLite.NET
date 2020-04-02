using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ColorScheme
    {
        public SignalRef    SignalRef;
        public string       String;
        public List<string> StringArray;

        public static implicit operator ColorScheme(SignalRef signalRef)
        {
            return new ColorScheme
            {
                SignalRef = signalRef
            };
        }

        public static implicit operator ColorScheme(string @string)
        {
            return new ColorScheme
            {
                String = @string
            };
        }

        public static implicit operator ColorScheme(List<string> stringArray)
        {
            return new ColorScheme
            {
                StringArray = stringArray
            };
        }
    }
}
