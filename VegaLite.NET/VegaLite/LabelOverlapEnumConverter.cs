using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LabelOverlapEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelOverlapEnum) || t == typeof(LabelOverlapEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "greedy":
                    return LabelOverlapEnum.Greedy;
                case "parity":
                    return LabelOverlapEnum.Parity;
            }
            throw new Exception("Cannot unmarshal type LabelOverlapEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelOverlapEnum)untypedValue;
            switch (value)
            {
                case LabelOverlapEnum.Greedy:
                    serializer.Serialize(writer, "greedy");
                    return;
                case LabelOverlapEnum.Parity:
                    serializer.Serialize(writer, "parity");
                    return;
            }
            throw new Exception("Cannot marshal type LabelOverlapEnum");
        }

        public static readonly LabelOverlapEnumConverter Singleton = new LabelOverlapEnumConverter();
    }
}