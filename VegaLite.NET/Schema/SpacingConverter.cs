using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SpacingConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Spacing) || t == typeof(Spacing?);
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

                    return new Spacing
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    RowColNumber objectValue = serializer.Deserialize<RowColNumber>(reader);

                    return new Spacing
                    {
                        RowColNumber = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Spacing");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Spacing value = (Spacing)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.RowColNumber != null)
            {
                serializer.Serialize(writer,
                                     value.RowColNumber);

                return;
            }

            throw new Exception("Cannot marshal type Spacing");
        }

        public static readonly SpacingConverter Singleton = new SpacingConverter();
    }
}
