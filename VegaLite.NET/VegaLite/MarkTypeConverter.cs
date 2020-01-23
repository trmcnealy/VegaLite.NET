using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class MarkTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarkType) || t == typeof(MarkType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "arc":
                    return MarkType.Arc;
                case "area":
                    return MarkType.Area;
                case "group":
                    return MarkType.Group;
                case "image":
                    return MarkType.Image;
                case "line":
                    return MarkType.Line;
                case "path":
                    return MarkType.Path;
                case "rect":
                    return MarkType.Rect;
                case "rule":
                    return MarkType.Rule;
                case "shape":
                    return MarkType.Shape;
                case "symbol":
                    return MarkType.Symbol;
                case "text":
                    return MarkType.Text;
                case "trail":
                    return MarkType.Trail;
            }
            throw new Exception("Cannot unmarshal type MarkType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MarkType)untypedValue;
            switch (value)
            {
                case MarkType.Arc:
                    serializer.Serialize(writer, "arc");
                    return;
                case MarkType.Area:
                    serializer.Serialize(writer, "area");
                    return;
                case MarkType.Group:
                    serializer.Serialize(writer, "group");
                    return;
                case MarkType.Image:
                    serializer.Serialize(writer, "image");
                    return;
                case MarkType.Line:
                    serializer.Serialize(writer, "line");
                    return;
                case MarkType.Path:
                    serializer.Serialize(writer, "path");
                    return;
                case MarkType.Rect:
                    serializer.Serialize(writer, "rect");
                    return;
                case MarkType.Rule:
                    serializer.Serialize(writer, "rule");
                    return;
                case MarkType.Shape:
                    serializer.Serialize(writer, "shape");
                    return;
                case MarkType.Symbol:
                    serializer.Serialize(writer, "symbol");
                    return;
                case MarkType.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case MarkType.Trail:
                    serializer.Serialize(writer, "trail");
                    return;
            }
            throw new Exception("Cannot marshal type MarkType");
        }

        public static readonly MarkTypeConverter Singleton = new MarkTypeConverter();
    }
}