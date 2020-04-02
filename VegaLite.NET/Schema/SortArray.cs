using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct SortArray
    {
        public List<Equal>           AnythingArray;
        public SortOrder?            Enum;
        public SortEncodingSortField SortEncodingSortField;

        public static implicit operator SortArray(List<Equal> anythingArray)
        {
            return new SortArray
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator SortArray(SortOrder @enum)
        {
            return new SortArray
            {
                Enum = @enum
            };
        }

        public static implicit operator SortArray(SortEncodingSortField sortEncodingSortField)
        {
            return new SortArray
            {
                SortEncodingSortField = sortEncodingSortField
            };
        }

        public bool IsNull { get { return AnythingArray == null && SortEncodingSortField == null && Enum == null; } }
    }
}
