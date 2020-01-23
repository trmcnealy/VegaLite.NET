using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BindUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BindUnion) || t == typeof(BindUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "legend":
                            return new BindUnion { Enum = PurpleLegendBinding.Legend };
                        case "scales":
                            return new BindUnion { Enum = PurpleLegendBinding.Scales };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, PurpleStream>>(reader);
                    return new BindUnion { AnythingMap = objectValue };
            }
            throw new Exception("Cannot unmarshal type BindUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BindUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleLegendBinding.Legend:
                        serializer.Serialize(writer, "legend");
                        return;
                    case PurpleLegendBinding.Scales:
                        serializer.Serialize(writer, "scales");
                        return;
                }
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type BindUnion");
        }

        public static readonly BindUnionConverter Singleton = new BindUnionConverter();
    }
}