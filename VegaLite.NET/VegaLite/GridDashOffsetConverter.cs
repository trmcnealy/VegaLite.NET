using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class GridDashOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridDashOffset) || t == typeof(GridDashOffset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new GridDashOffset { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new GridDashOffset { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridDashOffset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridDashOffset)untypedValue;
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
            throw new Exception("Cannot marshal type GridDashOffset");
        }

        public static readonly GridDashOffsetConverter Singleton = new GridDashOffsetConverter();
    }
}