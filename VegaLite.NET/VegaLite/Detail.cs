using System.Collections.Generic;

namespace VegaLite
{
    public struct Detail
    {
        public TypedFieldDef       TypedFieldDef;
        public List<TypedFieldDef> TypedFieldDefArray;

        public static implicit operator Detail(TypedFieldDef       TypedFieldDef)      => new Detail { TypedFieldDef      = TypedFieldDef };
        public static implicit operator Detail(List<TypedFieldDef> TypedFieldDefArray) => new Detail { TypedFieldDefArray = TypedFieldDefArray };
    }
}