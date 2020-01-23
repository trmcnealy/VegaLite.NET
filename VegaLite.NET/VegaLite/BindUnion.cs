using System.Collections.Generic;

namespace VegaLite
{
    public struct BindUnion
    {
        public Dictionary<string, PurpleStream> AnythingMap;
        public PurpleLegendBinding?             Enum;

        public static implicit operator BindUnion(Dictionary<string, PurpleStream> AnythingMap) => new BindUnion { AnythingMap = AnythingMap };
        public static implicit operator BindUnion(PurpleLegendBinding              Enum)        => new BindUnion { Enum        = Enum };
    }
}