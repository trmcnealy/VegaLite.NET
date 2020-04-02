using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SingleDefUnitChannelConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(SingleDefUnitChannel) || t == typeof(SingleDefUnitChannel?);
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
                case "color":         return SingleDefUnitChannel.Color;
                case "fill":          return SingleDefUnitChannel.Fill;
                case "fillOpacity":   return SingleDefUnitChannel.FillOpacity;
                case "href":          return SingleDefUnitChannel.Href;
                case "key":           return SingleDefUnitChannel.Key;
                case "latitude":      return SingleDefUnitChannel.Latitude;
                case "latitude2":     return SingleDefUnitChannel.Latitude2;
                case "longitude":     return SingleDefUnitChannel.Longitude;
                case "longitude2":    return SingleDefUnitChannel.Longitude2;
                case "opacity":       return SingleDefUnitChannel.Opacity;
                case "shape":         return SingleDefUnitChannel.Shape;
                case "size":          return SingleDefUnitChannel.Size;
                case "stroke":        return SingleDefUnitChannel.Stroke;
                case "strokeOpacity": return SingleDefUnitChannel.StrokeOpacity;
                case "strokeWidth":   return SingleDefUnitChannel.StrokeWidth;
                case "text":          return SingleDefUnitChannel.Text;
                case "url":           return SingleDefUnitChannel.Url;
                case "x":             return SingleDefUnitChannel.X;
                case "x2":            return SingleDefUnitChannel.X2;
                case "y":             return SingleDefUnitChannel.Y;
                case "y2":            return SingleDefUnitChannel.Y2;
            }

            throw new Exception("Cannot unmarshal type SingleDefUnitChannel");
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

            SingleDefUnitChannel value = (SingleDefUnitChannel)untypedValue;

            switch(value)
            {
                case SingleDefUnitChannel.Color:
                    serializer.Serialize(writer,
                                         "color");

                    return;
                case SingleDefUnitChannel.Fill:
                    serializer.Serialize(writer,
                                         "fill");

                    return;
                case SingleDefUnitChannel.FillOpacity:
                    serializer.Serialize(writer,
                                         "fillOpacity");

                    return;
                case SingleDefUnitChannel.Href:
                    serializer.Serialize(writer,
                                         "href");

                    return;
                case SingleDefUnitChannel.Key:
                    serializer.Serialize(writer,
                                         "key");

                    return;
                case SingleDefUnitChannel.Latitude:
                    serializer.Serialize(writer,
                                         "latitude");

                    return;
                case SingleDefUnitChannel.Latitude2:
                    serializer.Serialize(writer,
                                         "latitude2");

                    return;
                case SingleDefUnitChannel.Longitude:
                    serializer.Serialize(writer,
                                         "longitude");

                    return;
                case SingleDefUnitChannel.Longitude2:
                    serializer.Serialize(writer,
                                         "longitude2");

                    return;
                case SingleDefUnitChannel.Opacity:
                    serializer.Serialize(writer,
                                         "opacity");

                    return;
                case SingleDefUnitChannel.Shape:
                    serializer.Serialize(writer,
                                         "shape");

                    return;
                case SingleDefUnitChannel.Size:
                    serializer.Serialize(writer,
                                         "size");

                    return;
                case SingleDefUnitChannel.Stroke:
                    serializer.Serialize(writer,
                                         "stroke");

                    return;
                case SingleDefUnitChannel.StrokeOpacity:
                    serializer.Serialize(writer,
                                         "strokeOpacity");

                    return;
                case SingleDefUnitChannel.StrokeWidth:
                    serializer.Serialize(writer,
                                         "strokeWidth");

                    return;
                case SingleDefUnitChannel.Text:
                    serializer.Serialize(writer,
                                         "text");

                    return;
                case SingleDefUnitChannel.Url:
                    serializer.Serialize(writer,
                                         "url");

                    return;
                case SingleDefUnitChannel.X:
                    serializer.Serialize(writer,
                                         "x");

                    return;
                case SingleDefUnitChannel.X2:
                    serializer.Serialize(writer,
                                         "x2");

                    return;
                case SingleDefUnitChannel.Y:
                    serializer.Serialize(writer,
                                         "y");

                    return;
                case SingleDefUnitChannel.Y2:
                    serializer.Serialize(writer,
                                         "y2");

                    return;
            }

            throw new Exception("Cannot marshal type SingleDefUnitChannel");
        }

        public static readonly SingleDefUnitChannelConverter Singleton = new SingleDefUnitChannelConverter();
    }
}
