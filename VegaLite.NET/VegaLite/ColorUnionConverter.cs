using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ColorUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColorUnion) || t == typeof(ColorUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ColorUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ColorLinearGradient>(reader);
                    return new ColorUnion { ColorLinearGradient = objectValue };
            }
            throw new Exception("Cannot unmarshal type ColorUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColorUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ColorLinearGradient != null)
            {
                serializer.Serialize(writer, value.ColorLinearGradient);
                return;
            }
            throw new Exception("Cannot marshal type ColorUnion");
        }

        public static readonly ColorUnionConverter Singleton = new ColorUnionConverter();
    }
}