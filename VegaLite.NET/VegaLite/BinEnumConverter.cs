using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BinEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BinEnum) || t == typeof(BinEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "binned")
            {
                return BinEnum.Binned;
            }
            throw new Exception("Cannot unmarshal type BinEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BinEnum)untypedValue;
            if (value == BinEnum.Binned)
            {
                serializer.Serialize(writer, "binned");
                return;
            }
            throw new Exception("Cannot marshal type BinEnum");
        }

        public static readonly BinEnumConverter Singleton = new BinEnumConverter();
    }
}