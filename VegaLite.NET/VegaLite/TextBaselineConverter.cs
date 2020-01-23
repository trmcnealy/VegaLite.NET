using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class TextBaselineConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextBaseline) || t == typeof(TextBaseline?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "alphabetic":
                            return new TextBaseline { Enum = Baseline.Alphabetic };
                        case "bottom":
                            return new TextBaseline { Enum = Baseline.Bottom };
                        case "middle":
                            return new TextBaseline { Enum = Baseline.Middle };
                        case "top":
                            return new TextBaseline { Enum = Baseline.Top };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyTextBaselineNull>(reader);
                    return new TextBaseline { ConditionalAxisPropertyTextBaselineNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type TextBaseline");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TextBaseline)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Baseline.Alphabetic:
                        serializer.Serialize(writer, "alphabetic");
                        return;
                    case Baseline.Bottom:
                        serializer.Serialize(writer, "bottom");
                        return;
                    case Baseline.Middle:
                        serializer.Serialize(writer, "middle");
                        return;
                    case Baseline.Top:
                        serializer.Serialize(writer, "top");
                        return;
                }
            }
            if (value.ConditionalAxisPropertyTextBaselineNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyTextBaselineNull);
                return;
            }
            throw new Exception("Cannot marshal type TextBaseline");
        }

        public static readonly TextBaselineConverter Singleton = new TextBaselineConverter();
    }
}