using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AnyStreamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AnyStream) || t == typeof(AnyStream?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new AnyStream { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new AnyStream { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AnyBinding>(reader);
                    return new AnyStream { Binding = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new AnyStream { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleStream");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AnyStream)untypedValue;
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
            if (value.Binding != null)
            {
                serializer.Serialize(writer, value.Binding);
                return;
            }
            throw new Exception("Cannot marshal type PurpleStream");
        }

        public static readonly AnyStreamConverter Singleton = new AnyStreamConverter();
    }
}