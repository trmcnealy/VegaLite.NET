using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleLegendBindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleLegendBinding) || t == typeof(PurpleLegendBinding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "legend":
                    return PurpleLegendBinding.Legend;
                case "scales":
                    return PurpleLegendBinding.Scales;
            }
            throw new Exception("Cannot unmarshal type PurpleLegendBinding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleLegendBinding)untypedValue;
            switch (value)
            {
                case PurpleLegendBinding.Legend:
                    serializer.Serialize(writer, "legend");
                    return;
                case PurpleLegendBinding.Scales:
                    serializer.Serialize(writer, "scales");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleLegendBinding");
        }

        public static readonly PurpleLegendBindingConverter Singleton = new PurpleLegendBindingConverter();
    }
}