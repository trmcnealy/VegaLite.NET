using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class WidthValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WidthValue) || t == typeof(WidthValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "width")
            {
                return WidthValue.Width;
            }
            throw new Exception("Cannot unmarshal type WidthValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WidthValue)untypedValue;
            if (value == WidthValue.Width)
            {
                serializer.Serialize(writer, "width");
                return;
            }
            throw new Exception("Cannot marshal type WidthValue");
        }

        public static readonly WidthValueConverter Singleton = new WidthValueConverter();
    }
}