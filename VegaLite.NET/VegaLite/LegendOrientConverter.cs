using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LegendOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendOrient) || t == typeof(LegendOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return LegendOrient.Bottom;
                case "bottom-left":
                    return LegendOrient.BottomLeft;
                case "bottom-right":
                    return LegendOrient.BottomRight;
                case "left":
                    return LegendOrient.Left;
                case "none":
                    return LegendOrient.None;
                case "right":
                    return LegendOrient.Right;
                case "top":
                    return LegendOrient.Top;
                case "top-left":
                    return LegendOrient.TopLeft;
                case "top-right":
                    return LegendOrient.TopRight;
            }
            throw new Exception("Cannot unmarshal type LegendOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegendOrient)untypedValue;
            switch (value)
            {
                case LegendOrient.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case LegendOrient.BottomLeft:
                    serializer.Serialize(writer, "bottom-left");
                    return;
                case LegendOrient.BottomRight:
                    serializer.Serialize(writer, "bottom-right");
                    return;
                case LegendOrient.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case LegendOrient.None:
                    serializer.Serialize(writer, "none");
                    return;
                case LegendOrient.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case LegendOrient.Top:
                    serializer.Serialize(writer, "top");
                    return;
                case LegendOrient.TopLeft:
                    serializer.Serialize(writer, "top-left");
                    return;
                case LegendOrient.TopRight:
                    serializer.Serialize(writer, "top-right");
                    return;
            }
            throw new Exception("Cannot marshal type LegendOrient");
        }

        public static readonly LegendOrientConverter Singleton = new LegendOrientConverter();
    }
}