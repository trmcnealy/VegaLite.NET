using System.Collections.Generic;

namespace VegaLite
{
    public struct SortArray
    {
        public List<Equal>           AnythingArray;
        public SortOrder?            Enum;
        public SortEncodingSortField SortEncodingSortField;

        public static implicit operator SortArray(List<Equal>           anythingArray)         => new SortArray { AnythingArray         = anythingArray };
        public static implicit operator SortArray(SortOrder             @enum)                  => new SortArray { Enum                  = @enum };
        public static implicit operator SortArray(SortEncodingSortField sortEncodingSortField) => new SortArray { SortEncodingSortField = sortEncodingSortField };
        public                          bool IsNull                                            => AnythingArray == null && SortEncodingSortField == null && Enum == null;
    }
}