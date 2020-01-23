using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ScaleRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleRange) || t == typeof(ScaleRange?);

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
                            return new ScaleRange { Enum = RangeEnum.Category };
                        case "diverging":
                            return new ScaleRange { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new ScaleRange { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new ScaleRange { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new ScaleRange { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new ScaleRange { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new ScaleRange { Enum = RangeEnum.Symbol };
                        case "width":
                            return new ScaleRange { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRange>>(reader);
                    return new ScaleRange { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ScaleRange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ScaleRange)untypedValue;
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
            throw new Exception("Cannot marshal type ScaleRange");
        }

        public static readonly ScaleRangeConverter Singleton = new ScaleRangeConverter();
    }
}