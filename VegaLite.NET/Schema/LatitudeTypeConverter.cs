using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LatitudeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(LatitudeType) || t == typeof(LatitudeType?);
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

            if(value == "quantitative")
            {
                return LatitudeType.Quantitative;
            }

            throw new Exception("Cannot unmarshal type LatitudeType");
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

            LatitudeType value = (LatitudeType)untypedValue;

            if(value == LatitudeType.Quantitative)
            {
                serializer.Serialize(writer,
                                     "quantitative");

                return;
            }

            throw new Exception("Cannot marshal type LatitudeType");
        }

        public static readonly LatitudeTypeConverter Singleton = new LatitudeTypeConverter();
    }
}
