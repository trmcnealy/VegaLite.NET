using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BoxPlotConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(BoxPlot) || t == typeof(BoxPlot?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "area":      return BoxPlot.Area;
                case "bar":       return BoxPlot.Bar;
                case "boxplot":   return BoxPlot.Boxplot;
                case "circle":    return BoxPlot.Circle;
                case "errorband": return BoxPlot.Errorband;
                case "errorbar":  return BoxPlot.Errorbar;
                case "geoshape":  return BoxPlot.Geoshape;
                case "image":     return BoxPlot.Image;
                case "line":      return BoxPlot.Line;
                case "point":     return BoxPlot.Point;
                case "rect":      return BoxPlot.Rect;
                case "rule":      return BoxPlot.Rule;
                case "square":    return BoxPlot.Square;
                case "text":      return BoxPlot.Text;
                case "tick":      return BoxPlot.Tick;
                case "trail":     return BoxPlot.Trail;
            }

            throw new Exception("Cannot unmarshal type BoxPlot");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            BoxPlot value = (BoxPlot)untypedValue;

            switch(value)
            {
                case BoxPlot.Area:
                    serializer.Serialize(writer,
                                         "area");

                    return;
                case BoxPlot.Bar:
                    serializer.Serialize(writer,
                                         "bar");

                    return;
                case BoxPlot.Boxplot:
                    serializer.Serialize(writer,
                                         "boxplot");

                    return;
                case BoxPlot.Circle:
                    serializer.Serialize(writer,
                                         "circle");

                    return;
                case BoxPlot.Errorband:
                    serializer.Serialize(writer,
                                         "errorband");

                    return;
                case BoxPlot.Errorbar:
                    serializer.Serialize(writer,
                                         "errorbar");

                    return;
                case BoxPlot.Geoshape:
                    serializer.Serialize(writer,
                                         "geoshape");

                    return;
                case BoxPlot.Image:
                    serializer.Serialize(writer,
                                         "image");

                    return;
                case BoxPlot.Line:
                    serializer.Serialize(writer,
                                         "line");

                    return;
                case BoxPlot.Point:
                    serializer.Serialize(writer,
                                         "point");

                    return;
                case BoxPlot.Rect:
                    serializer.Serialize(writer,
                                         "rect");

                    return;
                case BoxPlot.Rule:
                    serializer.Serialize(writer,
                                         "rule");

                    return;
                case BoxPlot.Square:
                    serializer.Serialize(writer,
                                         "square");

                    return;
                case BoxPlot.Text:
                    serializer.Serialize(writer,
                                         "text");

                    return;
                case BoxPlot.Tick:
                    serializer.Serialize(writer,
                                         "tick");

                    return;
                case BoxPlot.Trail:
                    serializer.Serialize(writer,
                                         "trail");

                    return;
            }

            throw new Exception("Cannot marshal type BoxPlot");
        }

        public static readonly BoxPlotConverter Singleton = new BoxPlotConverter();
    }
}
