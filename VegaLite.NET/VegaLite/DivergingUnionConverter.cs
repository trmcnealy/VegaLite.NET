using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class DivergingUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DivergingUnion) || t == typeof(DivergingUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new DivergingUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new DivergingUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new DivergingUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new DivergingUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new DivergingUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new DivergingUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new DivergingUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new DivergingUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DivergingSignalRef>(reader);
                    return new DivergingUnion { DivergingSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);
                    return new DivergingUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DivergingUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DivergingUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.DivergingSignalRef != null)
            {
                serializer.Serialize(writer, value.DivergingSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type DivergingUnion");
        }

        public static readonly DivergingUnionConverter Singleton = new DivergingUnionConverter();
    }
}