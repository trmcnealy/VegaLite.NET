using System.Collections.Generic;

namespace VegaLite
{
    public struct InlineDatasetElement
    {
        public Dictionary<string, object> AnythingMap;
        public bool?                      Bool;
        public double?                    Double;
        public string                     String;

        public static implicit operator InlineDatasetElement(Dictionary<string, object> anythingMap) => new InlineDatasetElement { AnythingMap = anythingMap };
        public static implicit operator InlineDatasetElement(bool                       @bool)        => new InlineDatasetElement { Bool        = @bool };
        public static implicit operator InlineDatasetElement(double                     @double)      => new InlineDatasetElement { Double      = @double };
        public static implicit operator InlineDatasetElement(string                     @string)      => new InlineDatasetElement { String      = @string };
    }
}