using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SortConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Sort) || t == typeof(Sort?);
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
                case "-color":         return Sort.SortColor;
                case "-fill":          return Sort.SortFill;
                case "-fillOpacity":   return Sort.SortFillOpacity;
                case "-opacity":       return Sort.SortOpacity;
                case "-shape":         return Sort.SortShape;
                case "-size":          return Sort.SortSize;
                case "-stroke":        return Sort.SortStroke;
                case "-strokeOpacity": return Sort.SortStrokeOpacity;
                case "-strokeWidth":   return Sort.SortStrokeWidth;
                case "-text":          return Sort.SortText;
                case "-x":             return Sort.SortX;
                case "-y":             return Sort.SortY;
                case "ascending":      return Sort.Ascending;
                case "color":          return Sort.Color;
                case "descending":     return Sort.Descending;
                case "fill":           return Sort.Fill;
                case "fillOpacity":    return Sort.FillOpacity;
                case "opacity":        return Sort.Opacity;
                case "shape":          return Sort.Shape;
                case "size":           return Sort.Size;
                case "stroke":         return Sort.Stroke;
                case "strokeOpacity":  return Sort.StrokeOpacity;
                case "strokeWidth":    return Sort.StrokeWidth;
                case "text":           return Sort.Text;
                case "x":              return Sort.X;
                case "y":              return Sort.Y;
            }

            throw new Exception("Cannot unmarshal type Sort");
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

            Sort value = (Sort)untypedValue;

            switch(value)
            {
                case Sort.SortColor:
                    serializer.Serialize(writer,
                                         "-color");

                    return;
                case Sort.SortFill:
                    serializer.Serialize(writer,
                                         "-fill");

                    return;
                case Sort.SortFillOpacity:
                    serializer.Serialize(writer,
                                         "-fillOpacity");

                    return;
                case Sort.SortOpacity:
                    serializer.Serialize(writer,
                                         "-opacity");

                    return;
                case Sort.SortShape:
                    serializer.Serialize(writer,
                                         "-shape");

                    return;
                case Sort.SortSize:
                    serializer.Serialize(writer,
                                         "-size");

                    return;
                case Sort.SortStroke:
                    serializer.Serialize(writer,
                                         "-stroke");

                    return;
                case Sort.SortStrokeOpacity:
                    serializer.Serialize(writer,
                                         "-strokeOpacity");

                    return;
                case Sort.SortStrokeWidth:
                    serializer.Serialize(writer,
                                         "-strokeWidth");

                    return;
                case Sort.SortText:
                    serializer.Serialize(writer,
                                         "-text");

                    return;
                case Sort.SortX:
                    serializer.Serialize(writer,
                                         "-x");

                    return;
                case Sort.SortY:
                    serializer.Serialize(writer,
                                         "-y");

                    return;
                case Sort.Ascending:
                    serializer.Serialize(writer,
                                         "ascending");

                    return;
                case Sort.Color:
                    serializer.Serialize(writer,
                                         "color");

                    return;
                case Sort.Descending:
                    serializer.Serialize(writer,
                                         "descending");

                    return;
                case Sort.Fill:
                    serializer.Serialize(writer,
                                         "fill");

                    return;
                case Sort.FillOpacity:
                    serializer.Serialize(writer,
                                         "fillOpacity");

                    return;
                case Sort.Opacity:
                    serializer.Serialize(writer,
                                         "opacity");

                    return;
                case Sort.Shape:
                    serializer.Serialize(writer,
                                         "shape");

                    return;
                case Sort.Size:
                    serializer.Serialize(writer,
                                         "size");

                    return;
                case Sort.Stroke:
                    serializer.Serialize(writer,
                                         "stroke");

                    return;
                case Sort.StrokeOpacity:
                    serializer.Serialize(writer,
                                         "strokeOpacity");

                    return;
                case Sort.StrokeWidth:
                    serializer.Serialize(writer,
                                         "strokeWidth");

                    return;
                case Sort.Text:
                    serializer.Serialize(writer,
                                         "text");

                    return;
                case Sort.X:
                    serializer.Serialize(writer,
                                         "x");

                    return;
                case Sort.Y:
                    serializer.Serialize(writer,
                                         "y");

                    return;
            }

            throw new Exception("Cannot marshal type Sort");
        }

        public static readonly SortConverter Singleton = new SortConverter();
    }
}
