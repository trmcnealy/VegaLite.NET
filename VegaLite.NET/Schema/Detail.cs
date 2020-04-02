using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct Detail
    {
        public TypedFieldDef       TypedFieldDef;
        public List<TypedFieldDef> TypedFieldDefArray;

        public static implicit operator Detail(TypedFieldDef typedFieldDef)
        {
            return new Detail
            {
                TypedFieldDef = typedFieldDef
            };
        }

        public static implicit operator Detail(List<TypedFieldDef> typedFieldDefArray)
        {
            return new Detail
            {
                TypedFieldDefArray = typedFieldDefArray
            };
        }
    }
}
