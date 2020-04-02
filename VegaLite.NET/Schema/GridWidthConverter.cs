using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class GridWidthConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(GridWidth) || t == typeof(GridWidth?);
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

                    return new GridWidth
                    {
                        Double = doubleValue
                    };
                case JsonToken.StartObject:
                    ConditionalAxisPropertyNumberNullClass objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);

                    return new GridWidth
                    {
                        ConditionalAxisPropertyNumberNullClass = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type GridWidth");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            GridWidth value = (GridWidth)untypedValue;

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

            throw new Exception("Cannot marshal type GridWidth");
        }

        public static readonly GridWidthConverter Singleton = new GridWidthConverter();
    }
}
