using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ColorSchemeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColorScheme) || t == typeof(ColorScheme?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ColorScheme { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new ColorScheme { PurpleSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new ColorScheme { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ColorScheme");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColorScheme)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type ColorScheme");
        }

        public static readonly ColorSchemeConverter Singleton = new ColorSchemeConverter();
    }
}