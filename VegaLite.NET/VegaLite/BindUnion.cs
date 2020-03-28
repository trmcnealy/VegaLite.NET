using System.Collections.Generic;

namespace VegaLite
{
    public struct BindUnion
    {
        public Dictionary<string, AnyStream> AnythingMap;
        public SelectionLegendBinding?             Enum;

        public static implicit operator BindUnion(Dictionary<string, AnyStream> anythingMap) => new BindUnion { AnythingMap = anythingMap };
        public static implicit operator BindUnion(SelectionLegendBinding              @enum)        => new BindUnion { Enum        = @enum };
    }
}