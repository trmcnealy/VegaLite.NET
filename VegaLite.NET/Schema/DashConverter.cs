using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DashConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Dash) || t == typeof(Dash?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalAxisPropertyNumberNull objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNull>(reader);

                    return new Dash
                    {
                        ConditionalAxisPropertyNumberNull = objectValue
                    };
                case JsonToken.StartArray:
                    List<double> arrayValue = serializer.Deserialize<List<double>>(reader);

                    return new Dash
                    {
                        DoubleArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type Dash");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Dash value = (Dash)untypedValue;

            if(value.DoubleArray != null)
            {
                serializer.Serialize(writer,
                                     value.DoubleArray);

                return;
            }

            if(value.ConditionalAxisPropertyNumberNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalAxisPropertyNumberNull);

                return;
            }

            throw new Exception("Cannot marshal type Dash");
        }

        public static readonly DashConverter Singleton = new DashConverter();
    }
}
