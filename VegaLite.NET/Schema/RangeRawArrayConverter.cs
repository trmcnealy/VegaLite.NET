using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RangeRawArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RangeRawArray) || t == typeof(RangeRawArray?);
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

                    return new RangeRawArray
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    SignalRef objectValue = serializer.Deserialize<SignalRef>(reader);

                    return new RangeRawArray
                    {
                        SignalRef = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type RangeRawArray");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            RangeRawArray value = (RangeRawArray)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.SignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.SignalRef);

                return;
            }

            throw new Exception("Cannot marshal type RangeRawArray");
        }

        public static readonly RangeRawArrayConverter Singleton = new RangeRawArrayConverter();
    }
}
