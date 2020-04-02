using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class PurpleRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(PurpleRange) || t == typeof(PurpleRange?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new PurpleRange();
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new PurpleRange
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    DateTime objectValue = serializer.Deserialize<DateTime>(reader);

                    return new PurpleRange
                    {
                        DateTime = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type PurpleRange");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            PurpleRange value = (PurpleRange)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.DateTime != null)
            {
                serializer.Serialize(writer,
                                     value.DateTime);

                return;
            }

            throw new Exception("Cannot marshal type PurpleRange");
        }

        public static readonly PurpleRangeConverter Singleton = new PurpleRangeConverter();
    }
}
