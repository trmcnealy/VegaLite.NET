using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LegendBindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendBinding) || t == typeof(LegendBinding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "legend")
                    {
                        return new LegendBinding { Enum = LegendBindingEnum.Legend };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LegendStreamBinding>(reader);
                    return new LegendBinding { LegendStreamBinding = objectValue };
            }
            throw new Exception("Cannot unmarshal type LegendBinding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LegendBinding)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == LegendBindingEnum.Legend)
                {
                    serializer.Serialize(writer, "legend");
                    return;
                }
            }
            if (value.LegendStreamBinding != null)
            {
                serializer.Serialize(writer, value.LegendStreamBinding);
                return;
            }
            throw new Exception("Cannot marshal type LegendBinding");
        }

        public static readonly LegendBindingConverter Singleton = new LegendBindingConverter();
    }
}