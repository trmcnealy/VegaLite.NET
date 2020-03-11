using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class HeightValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HeightValue) || t == typeof(HeightValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "height")
            {
                return HeightValue.Height;
            }
            throw new Exception("Cannot unmarshal type FluffyValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HeightValue)untypedValue;
            if (value == HeightValue.Height)
            {
                serializer.Serialize(writer, "height");
                return;
            }
            throw new Exception("Cannot marshal type FluffyValue");
        }

        public static readonly HeightValueConverter Singleton = new HeightValueConverter();
    }
}