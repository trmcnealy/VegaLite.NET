using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DomainUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(DomainUnion) || t == typeof(DomainUnion?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    if(stringValue == "unaggregated")
                    {
                        return new DomainUnion
                        {
                            Enum = Domain.Unaggregated
                        };
                    }

                    break;
                case JsonToken.StartObject:
                    DomainClass objectValue = serializer.Deserialize<DomainClass>(reader);

                    return new DomainUnion
                    {
                        DomainClass = objectValue
                    };
                case JsonToken.StartArray:
                    List<Equal> arrayValue = serializer.Deserialize<List<Equal>>(reader);

                    return new DomainUnion
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type DomainUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            DomainUnion value = (DomainUnion)untypedValue;

            if(value.Enum != null)
            {
                if(value.Enum == Domain.Unaggregated)
                {
                    serializer.Serialize(writer,
                                         "unaggregated");

                    return;
                }
            }

            if(value.AnythingArray != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingArray);

                return;
            }

            if(value.DomainClass != null)
            {
                serializer.Serialize(writer,
                                     value.DomainClass);

                return;
            }

            throw new Exception("Cannot marshal type DomainUnion");
        }

        public static readonly DomainUnionConverter Singleton = new DomainUnionConverter();
    }
}
