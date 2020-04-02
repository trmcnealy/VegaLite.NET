using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SortUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(SortUnion) || t == typeof(SortUnion?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new SortUnion();
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    switch(stringValue)
                    {
                        case "-color":
                            return new SortUnion
                            {
                                Enum = Sort.SortColor
                            };
                        case "-fill":
                            return new SortUnion
                            {
                                Enum = Sort.SortFill
                            };
                        case "-fillOpacity":
                            return new SortUnion
                            {
                                Enum = Sort.SortFillOpacity
                            };
                        case "-opacity":
                            return new SortUnion
                            {
                                Enum = Sort.SortOpacity
                            };
                        case "-shape":
                            return new SortUnion
                            {
                                Enum = Sort.SortShape
                            };
                        case "-size":
                            return new SortUnion
                            {
                                Enum = Sort.SortSize
                            };
                        case "-stroke":
                            return new SortUnion
                            {
                                Enum = Sort.SortStroke
                            };
                        case "-strokeOpacity":
                            return new SortUnion
                            {
                                Enum = Sort.SortStrokeOpacity
                            };
                        case "-strokeWidth":
                            return new SortUnion
                            {
                                Enum = Sort.SortStrokeWidth
                            };
                        case "-text":
                            return new SortUnion
                            {
                                Enum = Sort.SortText
                            };
                        case "-x":
                            return new SortUnion
                            {
                                Enum = Sort.SortX
                            };
                        case "-y":
                            return new SortUnion
                            {
                                Enum = Sort.SortY
                            };
                        case "ascending":
                            return new SortUnion
                            {
                                Enum = Sort.Ascending
                            };
                        case "color":
                            return new SortUnion
                            {
                                Enum = Sort.Color
                            };
                        case "descending":
                            return new SortUnion
                            {
                                Enum = Sort.Descending
                            };
                        case "fill":
                            return new SortUnion
                            {
                                Enum = Sort.Fill
                            };
                        case "fillOpacity":
                            return new SortUnion
                            {
                                Enum = Sort.FillOpacity
                            };
                        case "opacity":
                            return new SortUnion
                            {
                                Enum = Sort.Opacity
                            };
                        case "shape":
                            return new SortUnion
                            {
                                Enum = Sort.Shape
                            };
                        case "size":
                            return new SortUnion
                            {
                                Enum = Sort.Size
                            };
                        case "stroke":
                            return new SortUnion
                            {
                                Enum = Sort.Stroke
                            };
                        case "strokeOpacity":
                            return new SortUnion
                            {
                                Enum = Sort.StrokeOpacity
                            };
                        case "strokeWidth":
                            return new SortUnion
                            {
                                Enum = Sort.StrokeWidth
                            };
                        case "text":
                            return new SortUnion
                            {
                                Enum = Sort.Text
                            };
                        case "x":
                            return new SortUnion
                            {
                                Enum = Sort.X
                            };
                        case "y":
                            return new SortUnion
                            {
                                Enum = Sort.Y
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    EncodingSortField objectValue = serializer.Deserialize<EncodingSortField>(reader);

                    return new SortUnion
                    {
                        EncodingSortField = objectValue
                    };
                case JsonToken.StartArray:
                    List<Equal> arrayValue = serializer.Deserialize<List<Equal>>(reader);

                    return new SortUnion
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type SortUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            SortUnion value = (SortUnion)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.Enum != null)
            {
                switch(value.Enum)
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
            }

            if(value.AnythingArray != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingArray);

                return;
            }

            if(value.EncodingSortField != null)
            {
                serializer.Serialize(writer,
                                     value.EncodingSortField);

                return;
            }

            throw new Exception("Cannot marshal type SortUnion");
        }

        public static readonly SortUnionConverter Singleton = new SortUnionConverter();
    }
}
