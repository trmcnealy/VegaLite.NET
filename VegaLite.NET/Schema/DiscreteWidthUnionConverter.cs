using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DiscreteWidthUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(DiscreteWidthUnion) || t == typeof(DiscreteWidthUnion?);
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

                    return new DiscreteWidthUnion
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    DiscreteWidthClass objectValue = serializer.Deserialize<DiscreteWidthClass>(reader);

                    return new DiscreteWidthUnion
                    {
                        DiscreteWidthClass = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type DiscreteWidthUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            DiscreteWidthUnion value = (DiscreteWidthUnion)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.DiscreteWidthClass != null)
            {
                serializer.Serialize(writer,
                                     value.DiscreteWidthClass);

                return;
            }

            throw new Exception("Cannot marshal type DiscreteWidthUnion");
        }

        public static readonly DiscreteWidthUnionConverter Singleton = new DiscreteWidthUnionConverter();
    }
}
