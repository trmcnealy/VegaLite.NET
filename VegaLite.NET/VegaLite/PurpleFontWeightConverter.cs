using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleFontWeightConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleFontWeight) || t == typeof(PurpleFontWeight?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bold":
                    return PurpleFontWeight.Bold;
                case "bolder":
                    return PurpleFontWeight.Bolder;
                case "lighter":
                    return PurpleFontWeight.Lighter;
                case "normal":
                    return PurpleFontWeight.Normal;
            }
            throw new Exception("Cannot unmarshal type PurpleFontWeight");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleFontWeight)untypedValue;
            switch (value)
            {
                case PurpleFontWeight.Bold:
                    serializer.Serialize(writer, "bold");
                    return;
                case PurpleFontWeight.Bolder:
                    serializer.Serialize(writer, "bolder");
                    return;
                case PurpleFontWeight.Lighter:
                    serializer.Serialize(writer, "lighter");
                    return;
                case PurpleFontWeight.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleFontWeight");
        }

        public static readonly PurpleFontWeightConverter Singleton = new PurpleFontWeightConverter();
    }
}