using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ExtentEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExtentEnum) || t == typeof(ExtentEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "min-max")
            {
                return ExtentEnum.MinMax;
            }
            throw new Exception("Cannot unmarshal type ExtentEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExtentEnum)untypedValue;
            if (value == ExtentEnum.MinMax)
            {
                serializer.Serialize(writer, "min-max");
                return;
            }
            throw new Exception("Cannot marshal type ExtentEnum");
        }

        public static readonly ExtentEnumConverter Singleton = new ExtentEnumConverter();
    }
}