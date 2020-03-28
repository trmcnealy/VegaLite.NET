using System.Collections.Generic;

namespace VegaLite
{
    public struct PurpleText
    {
        public string       String;
        public List<string> StringArray;

        public static implicit operator PurpleText(string       @string)      => new PurpleText { String      = @string };
        public static implicit operator PurpleText(List<string> stringArray) => new PurpleText { StringArray = stringArray };
        public                          bool IsNull                          => StringArray == null && String == null;
    }
}