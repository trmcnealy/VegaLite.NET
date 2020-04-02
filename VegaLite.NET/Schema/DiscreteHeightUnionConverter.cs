using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DiscreteHeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(DiscreteHeightUnion) || t == typeof(DiscreteHeightUnion?);
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

                    return new DiscreteHeightUnion
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    DiscreteHeightClass objectValue = serializer.Deserialize<DiscreteHeightClass>(reader);

                    return new DiscreteHeightUnion
                    {
                        DiscreteHeightClass = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type DiscreteHeightUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            DiscreteHeightUnion value = (DiscreteHeightUnion)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.DiscreteHeightClass != null)
            {
                serializer.Serialize(writer,
                                     value.DiscreteHeightClass);

                return;
            }

            throw new Exception("Cannot marshal type DiscreteHeightUnion");
        }

        public static readonly DiscreteHeightUnionConverter Singleton = new DiscreteHeightUnionConverter();
    }
}
