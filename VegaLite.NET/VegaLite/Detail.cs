using System.Collections.Generic;

namespace VegaLite
{
    public struct Detail
    {
        public TypedFieldDef       TypedFieldDef;
        public List<TypedFieldDef> TypedFieldDefArray;

        public static implicit operator Detail(TypedFieldDef       typedFieldDef)      => new Detail { TypedFieldDef      = typedFieldDef };
        public static implicit operator Detail(List<TypedFieldDef> typedFieldDefArray) => new Detail { TypedFieldDefArray = typedFieldDefArray };
    }
}