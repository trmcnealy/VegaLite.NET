using System.Collections.Generic;

namespace VegaLite
{
    public struct BindUnion
    {
        public Dictionary<string, AnyStream> AnythingMap;
        public SelectionLegendBinding?             Enum;

        public static implicit operator BindUnion(Dictionary<string, AnyStream> AnythingMap) => new BindUnion { AnythingMap = AnythingMap };
        public static implicit operator BindUnion(SelectionLegendBinding              Enum)        => new BindUnion { Enum        = Enum };
    }
}