using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SelectionLegendBindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionLegendBinding) || t == typeof(SelectionLegendBinding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "legend":
                    return SelectionLegendBinding.Legend;
                case "scales":
                    return SelectionLegendBinding.Scales;
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
            var value = (SelectionLegendBinding)untypedValue;
            switch (value)
            {
                case SelectionLegendBinding.Legend:
                    serializer.Serialize(writer, "legend");
                    return;
                case SelectionLegendBinding.Scales:
                    serializer.Serialize(writer, "scales");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleLegendBinding");
        }

        public static readonly SelectionLegendBindingConverter Singleton = new SelectionLegendBindingConverter();
    }
}