using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DomainConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Domain) || t == typeof(Domain?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            if(value == "unaggregated")
            {
                return Domain.Unaggregated;
            }

            throw new Exception("Cannot unmarshal type Domain");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            Domain value = (Domain)untypedValue;

            if(value == Domain.Unaggregated)
            {
                serializer.Serialize(writer,
                                     "unaggregated");

                return;
            }

            throw new Exception("Cannot marshal type Domain");
        }

        public static readonly DomainConverter Singleton = new DomainConverter();
    }
}
