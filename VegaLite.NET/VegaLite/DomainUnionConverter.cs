using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class DomainUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainUnion) || t == typeof(DomainUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "unaggregated")
                    {
                        return new DomainUnion { Enum = Domain.Unaggregated };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DomainClass>(reader);
                    return new DomainUnion { DomainClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Equal>>(reader);
                    return new DomainUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DomainUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainUnion)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == Domain.Unaggregated)
                {
                    serializer.Serialize(writer, "unaggregated");
                    return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.DomainClass != null)
            {
                serializer.Serialize(writer, value.DomainClass);
                return;
            }
            throw new Exception("Cannot marshal type DomainUnion");
        }

        public static readonly DomainUnionConverter Singleton = new DomainUnionConverter();
    }
}