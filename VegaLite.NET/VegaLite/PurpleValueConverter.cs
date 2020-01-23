using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleValue) || t == typeof(PurpleValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "width")
            {
                return PurpleValue.Width;
            }
            throw new Exception("Cannot unmarshal type PurpleValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleValue)untypedValue;
            if (value == PurpleValue.Width)
            {
                serializer.Serialize(writer, "width");
                return;
            }
            throw new Exception("Cannot marshal type PurpleValue");
        }

        public static readonly PurpleValueConverter Singleton = new PurpleValueConverter();
    }
}