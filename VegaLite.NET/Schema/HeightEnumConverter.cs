using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class HeightEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(HeightEnum) || t == typeof(HeightEnum?);
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

            if(value == "container")
            {
                return HeightEnum.Container;
            }

            throw new Exception("Cannot unmarshal type HeightEnum");
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

            HeightEnum value = (HeightEnum)untypedValue;

            if(value == HeightEnum.Container)
            {
                serializer.Serialize(writer,
                                     "container");

                return;
            }

            throw new Exception("Cannot marshal type HeightEnum");
        }

        public static readonly HeightEnumConverter Singleton = new HeightEnumConverter();
    }
}
