using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class OrdinalUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(OrdinalUnion) || t == typeof(OrdinalUnion?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    switch(stringValue)
                    {
                        case "category":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Category
                            };
                        case "diverging":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Diverging
                            };
                        case "heatmap":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Heatmap
                            };
                        case "height":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Height
                            };
                        case "ordinal":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Ordinal
                            };
                        case "ramp":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Ramp
                            };
                        case "symbol":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Symbol
                            };
                        case "width":
                            return new OrdinalUnion
                            {
                                Enum = RangeEnum.Width
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    OrdinalSignalRef objectValue = serializer.Deserialize<OrdinalSignalRef>(reader);

                    return new OrdinalUnion
                    {
                        OrdinalSignalRef = objectValue
                    };
                case JsonToken.StartArray:
                    List<RangeRaw> arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);

                    return new OrdinalUnion
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type OrdinalUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            OrdinalUnion value = (OrdinalUnion)untypedValue;

            if(value.Enum != null)
            {
                switch(value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer,
                                             "category");

                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer,
                                             "diverging");

                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer,
                                             "heatmap");

                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer,
                                             "height");

                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer,
                                             "ordinal");

                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer,
                                             "ramp");

                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer,
                                             "symbol");

                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer,
                                             "width");

                        return;
                }
            }

            if(value.AnythingArray != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingArray);

                return;
            }

            if(value.OrdinalSignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.OrdinalSignalRef);

                return;
            }

            throw new Exception("Cannot marshal type OrdinalUnion");
        }

        public static readonly OrdinalUnionConverter Singleton = new OrdinalUnionConverter();
    }
}
