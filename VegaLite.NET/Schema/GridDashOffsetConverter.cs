using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class GridDashOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(GridDashOffset) || t == typeof(GridDashOffset?);
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

                    return new GridDashOffset
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    ConditionalAxisPropertyNumberNullClass objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);

                    return new GridDashOffset
                    {
                        ConditionalAxisPropertyNumberNullClass = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type GridDashOffset");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            GridDashOffset value = (GridDashOffset)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalAxisPropertyNumberNullClass);

                return;
            }

            throw new Exception("Cannot marshal type GridDashOffset");
        }

        public static readonly GridDashOffsetConverter Singleton = new GridDashOffsetConverter();
    }
}
