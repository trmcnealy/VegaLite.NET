using System.Collections.Generic;

namespace VegaLite
{
    public struct PurpleText
    {
        public string       String;
        public List<string> StringArray;

        public static implicit operator PurpleText(string       String)      => new PurpleText { String      = String };
        public static implicit operator PurpleText(List<string> StringArray) => new PurpleText { StringArray = StringArray };
        public                          bool IsNull                          => StringArray == null && String == null;
    }
}