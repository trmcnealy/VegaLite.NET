using System.Collections.Generic;

namespace VegaLite
{
    public struct SortArray
    {
        public List<Equal>           AnythingArray;
        public SortOrder?            Enum;
        public SortEncodingSortField SortEncodingSortField;

        public static implicit operator SortArray(List<Equal>           AnythingArray)         => new SortArray { AnythingArray         = AnythingArray };
        public static implicit operator SortArray(SortOrder             Enum)                  => new SortArray { Enum                  = Enum };
        public static implicit operator SortArray(SortEncodingSortField SortEncodingSortField) => new SortArray { SortEncodingSortField = SortEncodingSortField };
        public                          bool IsNull                                            => AnythingArray == null && SortEncodingSortField == null && Enum == null;
    }
}