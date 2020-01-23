using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleStreamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleStream) || t == typeof(PurpleStream?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new PurpleStream { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new PurpleStream { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleBinding>(reader);
                    return new PurpleStream { PurpleBinding = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new PurpleStream { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleStream");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleStream)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleBinding != null)
            {
                serializer.Serialize(writer, value.PurpleBinding);
                return;
            }
            throw new Exception("Cannot marshal type PurpleStream");
        }

        public static readonly PurpleStreamConverter Singleton = new PurpleStreamConverter();
    }
}