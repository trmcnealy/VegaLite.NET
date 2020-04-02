using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class MinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(string);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            string value = serializer.Deserialize<string>(reader);

            if(value.Length >= 1 && value.Length <= 1)
            {
                return value;
            }

            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            string value = (string)untypedValue;

            if(value.Length >= 1 && value.Length <= 1)
            {
                serializer.Serialize(writer,
                                     value);

                return;
            }

            throw new Exception("Cannot marshal type string");
        }

        public static readonly MinMaxLengthCheckConverter Singleton = new MinMaxLengthCheckConverter();
    }
}
