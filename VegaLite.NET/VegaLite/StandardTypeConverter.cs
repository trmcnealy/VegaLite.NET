using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class StandardTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StandardType) || t == typeof(StandardType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "nominal":
                    return StandardType.Nominal;
                case "ordinal":
                    return StandardType.Ordinal;
                case "quantitative":
                    return StandardType.Quantitative;
                case "temporal":
                    return StandardType.Temporal;
            }
            throw new Exception("Cannot unmarshal type StandardType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StandardType)untypedValue;
            switch (value)
            {
                case StandardType.Nominal:
                    serializer.Serialize(writer, "nominal");
                    return;
                case StandardType.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case StandardType.Quantitative:
                    serializer.Serialize(writer, "quantitative");
                    return;
                case StandardType.Temporal:
                    serializer.Serialize(writer, "temporal");
                    return;
            }
            throw new Exception("Cannot marshal type StandardType");
        }

        public static readonly StandardTypeConverter Singleton = new StandardTypeConverter();
    }
}