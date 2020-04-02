using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LegendTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(LegendType) || t == typeof(LegendType?);
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
                case "gradient": return LegendType.Gradient;
                case "symbol":   return LegendType.Symbol;
            }

            throw new Exception("Cannot unmarshal type LegendType");
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

            LegendType value = (LegendType)untypedValue;

            switch(value)
            {
                case LegendType.Gradient:
                    serializer.Serialize(writer,
                                         "gradient");

                    return;
                case LegendType.Symbol:
                    serializer.Serialize(writer,
                                         "symbol");

                    return;
            }

            throw new Exception("Cannot marshal type LegendType");
        }

        public static readonly LegendTypeConverter Singleton = new LegendTypeConverter();
    }
}
