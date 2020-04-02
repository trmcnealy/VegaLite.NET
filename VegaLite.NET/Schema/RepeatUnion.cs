using System.Collections.Generic;

namespace VegaLite.Schema
{
    /// <summary>
    /// Definition for fields to be repeated. One of:
    /// 1) An array of fields to be repeated. If `"repeat"` is an array, the field can be
    /// referred using `{"repeat": "repeat"}`
    /// 2) An object that mapped `"row"` and/or `"column"` to the listed of fields to be repeated
    /// along the particular orientations. The objects `{"repeat": "row"}` and `{"repeat":
    /// "column"}` can be used to refer to the repeated field respectively.
    /// </summary>
    public struct RepeatUnion
    {
        public RepeatMapping RepeatMapping;
        public List<string>  StringArray;

        public static implicit operator RepeatUnion(RepeatMapping repeatMapping)
        {
            return new RepeatUnion
            {
                RepeatMapping = repeatMapping
            };
        }

        public static implicit operator RepeatUnion(List<string> stringArray)
        {
            return new RepeatUnion
            {
                StringArray = stringArray
            };
        }
    }
}
