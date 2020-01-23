using System.Collections.Generic;

namespace VegaLite
{
    public struct InlineDatasetElement
    {
        public Dictionary<string, object> AnythingMap;
        public bool?                      Bool;
        public double?                    Double;
        public string                     String;

        public static implicit operator InlineDatasetElement(Dictionary<string, object> AnythingMap) => new InlineDatasetElement { AnythingMap = AnythingMap };
        public static implicit operator InlineDatasetElement(bool                       Bool)        => new InlineDatasetElement { Bool        = Bool };
        public static implicit operator InlineDatasetElement(double                     Double)      => new InlineDatasetElement { Double      = Double };
        public static implicit operator InlineDatasetElement(string                     String)      => new InlineDatasetElement { String      = String };
    }
}