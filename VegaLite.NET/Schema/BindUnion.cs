using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct BindUnion
    {
        public Dictionary<string, AnyStream> AnythingMap;
        public SelectionLegendBinding?       Enum;

        public static implicit operator BindUnion(Dictionary<string, AnyStream> anythingMap)
        {
            return new BindUnion
            {
                AnythingMap = anythingMap
            };
        }

        public static implicit operator BindUnion(SelectionLegendBinding @enum)
        {
            return new BindUnion
            {
                Enum = @enum
            };
        }
    }
}
