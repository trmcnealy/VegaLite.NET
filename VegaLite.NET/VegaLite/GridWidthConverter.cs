using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class GridWidthConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridWidth) || t == typeof(GridWidth?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new GridWidth { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new GridWidth { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridWidth");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridWidth)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type GridWidth");
        }

        public static readonly GridWidthConverter Singleton = new GridWidthConverter();
    }
}