using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SortByChannelConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(SortByChannel) || t == typeof(SortByChannel?);
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
                case "color":         return SortByChannel.Color;
                case "fill":          return SortByChannel.Fill;
                case "fillOpacity":   return SortByChannel.FillOpacity;
                case "opacity":       return SortByChannel.Opacity;
                case "shape":         return SortByChannel.Shape;
                case "size":          return SortByChannel.Size;
                case "stroke":        return SortByChannel.Stroke;
                case "strokeOpacity": return SortByChannel.StrokeOpacity;
                case "strokeWidth":   return SortByChannel.StrokeWidth;
                case "text":          return SortByChannel.Text;
                case "x":             return SortByChannel.X;
                case "y":             return SortByChannel.Y;
            }

            throw new Exception("Cannot unmarshal type SortByChannel");
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

            SortByChannel value = (SortByChannel)untypedValue;

            switch(value)
            {
                case SortByChannel.Color:
                    serializer.Serialize(writer,
                                         "color");

                    return;
                case SortByChannel.Fill:
                    serializer.Serialize(writer,
                                         "fill");

                    return;
                case SortByChannel.FillOpacity:
                    serializer.Serialize(writer,
                                         "fillOpacity");

                    return;
                case SortByChannel.Opacity:
                    serializer.Serialize(writer,
                                         "opacity");

                    return;
                case SortByChannel.Shape:
                    serializer.Serialize(writer,
                                         "shape");

                    return;
                case SortByChannel.Size:
                    serializer.Serialize(writer,
                                         "size");

                    return;
                case SortByChannel.Stroke:
                    serializer.Serialize(writer,
                                         "stroke");

                    return;
                case SortByChannel.StrokeOpacity:
                    serializer.Serialize(writer,
                                         "strokeOpacity");

                    return;
                case SortByChannel.StrokeWidth:
                    serializer.Serialize(writer,
                                         "strokeWidth");

                    return;
                case SortByChannel.Text:
                    serializer.Serialize(writer,
                                         "text");

                    return;
                case SortByChannel.X:
                    serializer.Serialize(writer,
                                         "x");

                    return;
                case SortByChannel.Y:
                    serializer.Serialize(writer,
                                         "y");

                    return;
            }

            throw new Exception("Cannot marshal type SortByChannel");
        }

        public static readonly SortByChannelConverter Singleton = new SortByChannelConverter();
    }
}
