using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RampUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RampUnion) || t == typeof(RampUnion?);
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
                            return new RampUnion
                            {
                                Enum = RangeEnum.Category
                            };
                        case "diverging":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Diverging
                            };
                        case "heatmap":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Heatmap
                            };
                        case "height":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Height
                            };
                        case "ordinal":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Ordinal
                            };
                        case "ramp":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Ramp
                            };
                        case "symbol":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Symbol
                            };
                        case "width":
                            return new RampUnion
                            {
                                Enum = RangeEnum.Width
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    RampSignalRef objectValue = serializer.Deserialize<RampSignalRef>(reader);

                    return new RampUnion
                    {
                        RampSignalRef = objectValue
                    };
                case JsonToken.StartArray:
                    List<RangeRaw> arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);

                    return new RampUnion
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type RampUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            RampUnion value = (RampUnion)untypedValue;

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

            if(value.RampSignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.RampSignalRef);

                return;
            }

            throw new Exception("Cannot marshal type RampUnion");
        }

        public static readonly RampUnionConverter Singleton = new RampUnionConverter();
    }
}
