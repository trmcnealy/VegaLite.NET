using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class PaddingConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Padding) || t == typeof(Padding?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new Padding
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    PaddingClass objectValue = serializer.Deserialize<PaddingClass>(reader);

                    return new Padding
                    {
                        PaddingClass = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Padding");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Padding value = (Padding)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.PaddingClass != null)
            {
                serializer.Serialize(writer,
                                     value.PaddingClass);

                return;
            }

            throw new Exception("Cannot marshal type Padding");
        }

        public static readonly PaddingConverter Singleton = new PaddingConverter();
    }
}
