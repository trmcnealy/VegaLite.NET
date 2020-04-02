using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct InlineDatasetElement
    {
        public Dictionary<string, object> AnythingMap;
        public bool?                      Bool;
        public double?                    Double;
        public string                     String;

        public static implicit operator InlineDatasetElement(Dictionary<string, object> anythingMap)
        {
            return new InlineDatasetElement
            {
                AnythingMap = anythingMap
            };
        }

        public static implicit operator InlineDatasetElement(bool @bool)
        {
            return new InlineDatasetElement
            {
                Bool = @bool
            };
        }

        public static implicit operator InlineDatasetElement(double @double)
        {
            return new InlineDatasetElement
            {
                Double = @double
            };
        }

        public static implicit operator InlineDatasetElement(string @string)
        {
            return new InlineDatasetElement
            {
                String = @string
            };
        }
    }
}
