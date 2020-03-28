using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// The full data set, included inline. This can be an array of objects or primitive values,
    /// an object, or a string.
    /// Arrays of primitive values are ingested as objects with a `data` property. Strings are
    /// parsed according to the specified format type.
    /// </summary>
    public struct InlineDataset
    {
        public List<InlineDatasetElement> AnythingArray;
        public Dictionary<string, object> AnythingMap;
        public string                     String;

        public static implicit operator InlineDataset(List<InlineDatasetElement> anythingArray) => new InlineDataset { AnythingArray = anythingArray };
        public static implicit operator InlineDataset(Dictionary<string, object> anythingMap)   => new InlineDataset { AnythingMap   = anythingMap };
        public static implicit operator InlineDataset(string                     @string)        => new InlineDataset { String        = @string };
    }
}