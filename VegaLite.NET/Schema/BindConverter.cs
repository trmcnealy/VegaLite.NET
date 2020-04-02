using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BindConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Bind) || t == typeof(Bind?);
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

            if(value == "scales")
            {
                return Bind.Scales;
            }

            throw new Exception("Cannot unmarshal type Bind");
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

            Bind value = (Bind)untypedValue;

            if(value == Bind.Scales)
            {
                serializer.Serialize(writer,
                                     "scales");

                return;
            }

            throw new Exception("Cannot marshal type Bind");
        }

        public static readonly BindConverter Singleton = new BindConverter();
    }
}
