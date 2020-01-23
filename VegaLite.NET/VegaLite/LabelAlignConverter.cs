using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LabelAlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelAlign) || t == typeof(LabelAlign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new LabelAlign { Enum = Align.Center };
                        case "left":
                            return new LabelAlign { Enum = Align.Left };
                        case "right":
                            return new LabelAlign { Enum = Align.Right };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new LabelAlign { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelAlign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelAlign)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Align.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case Align.Left:
                        serializer.Serialize(writer, "left");
                        return;
                    case Align.Right:
                        serializer.Serialize(writer, "right");
                        return;
                }
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type LabelAlign");
        }

        public static readonly LabelAlignConverter Singleton = new LabelAlignConverter();
    }
}