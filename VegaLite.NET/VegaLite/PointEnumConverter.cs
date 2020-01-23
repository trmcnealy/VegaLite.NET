using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PointEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PointEnum) || t == typeof(PointEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "transparent")
            {
                return PointEnum.Transparent;
            }
            throw new Exception("Cannot unmarshal type PointEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PointEnum)untypedValue;
            if (value == PointEnum.Transparent)
            {
                serializer.Serialize(writer, "transparent");
                return;
            }
            throw new Exception("Cannot marshal type PointEnum");
        }

        public static readonly PointEnumConverter Singleton = new PointEnumConverter();
    }
}