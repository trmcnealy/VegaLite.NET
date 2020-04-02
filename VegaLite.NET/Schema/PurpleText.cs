using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct PurpleText
    {
        public string       String;
        public List<string> StringArray;

        public static implicit operator PurpleText(string @string)
        {
            return new PurpleText
            {
                String = @string
            };
        }

        public static implicit operator PurpleText(List<string> stringArray)
        {
            return new PurpleText
            {
                StringArray = stringArray
            };
        }

        public bool IsNull { get { return StringArray == null && String == null; } }
    }
}
