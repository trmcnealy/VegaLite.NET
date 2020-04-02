using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class HeatmapUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(HeatmapUnion) || t == typeof(HeatmapUnion?);
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
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Category
                            };
                        case "diverging":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Diverging
                            };
                        case "heatmap":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Heatmap
                            };
                        case "height":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Height
                            };
                        case "ordinal":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Ordinal
                            };
                        case "ramp":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Ramp
                            };
                        case "symbol":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Symbol
                            };
                        case "width":
                            return new HeatmapUnion
                            {
                                Enum = RangeEnum.Width
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    HeatmapSignalRef objectValue = serializer.Deserialize<HeatmapSignalRef>(reader);

                    return new HeatmapUnion
                    {
                        HeatmapSignalRef = objectValue
                    };
                case JsonToken.StartArray:
                    List<RangeRaw> arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);

                    return new HeatmapUnion
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type HeatmapUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            HeatmapUnion value = (HeatmapUnion)untypedValue;

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

            if(value.HeatmapSignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.HeatmapSignalRef);

                return;
            }

            throw new Exception("Cannot marshal type HeatmapUnion");
        }

        public static readonly HeatmapUnionConverter Singleton = new HeatmapUnionConverter();
    }
}
