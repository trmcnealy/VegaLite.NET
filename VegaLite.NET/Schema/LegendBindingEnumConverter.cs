using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LegendBindingEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(LegendBindingEnum) || t == typeof(LegendBindingEnum?);
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

            if(value == "legend")
            {
                return LegendBindingEnum.Legend;
            }

            throw new Exception("Cannot unmarshal type LegendBindingEnum");
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

            LegendBindingEnum value = (LegendBindingEnum)untypedValue;

            if(value == LegendBindingEnum.Legend)
            {
                serializer.Serialize(writer,
                                     "legend");

                return;
            }

            throw new Exception("Cannot marshal type LegendBindingEnum");
        }

        public static readonly LegendBindingEnumConverter Singleton = new LegendBindingEnumConverter();
    }
}
