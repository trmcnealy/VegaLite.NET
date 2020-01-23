using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AnyMarkConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AnyMark) || t == typeof(AnyMark?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "area":
                            return new AnyMark { Enum = BoxPlot.Area };
                        case "bar":
                            return new AnyMark { Enum = BoxPlot.Bar };
                        case "boxplot":
                            return new AnyMark { Enum = BoxPlot.Boxplot };
                        case "circle":
                            return new AnyMark { Enum = BoxPlot.Circle };
                        case "errorband":
                            return new AnyMark { Enum = BoxPlot.Errorband };
                        case "errorbar":
                            return new AnyMark { Enum = BoxPlot.Errorbar };
                        case "geoshape":
                            return new AnyMark { Enum = BoxPlot.Geoshape };
                        case "image":
                            return new AnyMark { Enum = BoxPlot.Image };
                        case "line":
                            return new AnyMark { Enum = BoxPlot.Line };
                        case "point":
                            return new AnyMark { Enum = BoxPlot.Point };
                        case "rect":
                            return new AnyMark { Enum = BoxPlot.Rect };
                        case "rule":
                            return new AnyMark { Enum = BoxPlot.Rule };
                        case "square":
                            return new AnyMark { Enum = BoxPlot.Square };
                        case "text":
                            return new AnyMark { Enum = BoxPlot.Text };
                        case "tick":
                            return new AnyMark { Enum = BoxPlot.Tick };
                        case "trail":
                            return new AnyMark { Enum = BoxPlot.Trail };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoxPlotDefClass>(reader);
                    return new AnyMark { BoxPlotDefClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type AnyMark");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AnyMark)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case BoxPlot.Area:
                        serializer.Serialize(writer, "area");
                        return;
                    case BoxPlot.Bar:
                        serializer.Serialize(writer, "bar");
                        return;
                    case BoxPlot.Boxplot:
                        serializer.Serialize(writer, "boxplot");
                        return;
                    case BoxPlot.Circle:
                        serializer.Serialize(writer, "circle");
                        return;
                    case BoxPlot.Errorband:
                        serializer.Serialize(writer, "errorband");
                        return;
                    case BoxPlot.Errorbar:
                        serializer.Serialize(writer, "errorbar");
                        return;
                    case BoxPlot.Geoshape:
                        serializer.Serialize(writer, "geoshape");
                        return;
                    case BoxPlot.Image:
                        serializer.Serialize(writer, "image");
                        return;
                    case BoxPlot.Line:
                        serializer.Serialize(writer, "line");
                        return;
                    case BoxPlot.Point:
                        serializer.Serialize(writer, "point");
                        return;
                    case BoxPlot.Rect:
                        serializer.Serialize(writer, "rect");
                        return;
                    case BoxPlot.Rule:
                        serializer.Serialize(writer, "rule");
                        return;
                    case BoxPlot.Square:
                        serializer.Serialize(writer, "square");
                        return;
                    case BoxPlot.Text:
                        serializer.Serialize(writer, "text");
                        return;
                    case BoxPlot.Tick:
                        serializer.Serialize(writer, "tick");
                        return;
                    case BoxPlot.Trail:
                        serializer.Serialize(writer, "trail");
                        return;
                }
            }
            if (value.BoxPlotDefClass != null)
            {
                serializer.Serialize(writer, value.BoxPlotDefClass);
                return;
            }
            throw new Exception("Cannot marshal type AnyMark");
        }

        public static readonly AnyMarkConverter Singleton = new AnyMarkConverter();
    }
}