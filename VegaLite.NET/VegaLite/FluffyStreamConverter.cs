using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FluffyStreamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyStream) || t == typeof(FluffyStream?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FluffyStream { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new FluffyStream { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyBinding>(reader);
                    return new FluffyStream { FluffyBinding = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new FluffyStream { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FluffyStream");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FluffyStream)untypedValue;
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
            if (value.FluffyBinding != null)
            {
                serializer.Serialize(writer, value.FluffyBinding);
                return;
            }
            throw new Exception("Cannot marshal type FluffyStream");
        }

        public static readonly FluffyStreamConverter Singleton = new FluffyStreamConverter();
    }
}