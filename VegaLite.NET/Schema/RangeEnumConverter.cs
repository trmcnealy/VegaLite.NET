using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RangeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RangeEnum) || t == typeof(RangeEnum?);
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
                case "category":  return RangeEnum.Category;
                case "diverging": return RangeEnum.Diverging;
                case "heatmap":   return RangeEnum.Heatmap;
                case "height":    return RangeEnum.Height;
                case "ordinal":   return RangeEnum.Ordinal;
                case "ramp":      return RangeEnum.Ramp;
                case "symbol":    return RangeEnum.Symbol;
                case "width":     return RangeEnum.Width;
            }

            throw new Exception("Cannot unmarshal type RangeEnum");
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

            RangeEnum value = (RangeEnum)untypedValue;

            switch(value)
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

            throw new Exception("Cannot marshal type RangeEnum");
        }

        public static readonly RangeEnumConverter Singleton = new RangeEnumConverter();
    }
}
