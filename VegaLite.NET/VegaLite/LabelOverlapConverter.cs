using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LabelOverlapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelOverlap) || t == typeof(LabelOverlap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new LabelOverlap { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "greedy":
                            return new LabelOverlap { Enum = LabelOverlapEnum.Greedy };
                        case "parity":
                            return new LabelOverlap { Enum = LabelOverlapEnum.Parity };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type LabelOverlap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelOverlap)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LabelOverlapEnum.Greedy:
                        serializer.Serialize(writer, "greedy");
                        return;
                    case LabelOverlapEnum.Parity:
                        serializer.Serialize(writer, "parity");
                        return;
                }
            }
            throw new Exception("Cannot marshal type LabelOverlap");
        }

        public static readonly LabelOverlapConverter Singleton = new LabelOverlapConverter();
    }
}