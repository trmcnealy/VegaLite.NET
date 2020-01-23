using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ExtentExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExtentExtent) || t == typeof(ExtentExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ci":
                    return ExtentExtent.Ci;
                case "iqr":
                    return ExtentExtent.Iqr;
                case "min-max":
                    return ExtentExtent.MinMax;
                case "stderr":
                    return ExtentExtent.Stderr;
                case "stdev":
                    return ExtentExtent.Stdev;
            }
            throw new Exception("Cannot unmarshal type ExtentExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExtentExtent)untypedValue;
            switch (value)
            {
                case ExtentExtent.Ci:
                    serializer.Serialize(writer, "ci");
                    return;
                case ExtentExtent.Iqr:
                    serializer.Serialize(writer, "iqr");
                    return;
                case ExtentExtent.MinMax:
                    serializer.Serialize(writer, "min-max");
                    return;
                case ExtentExtent.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case ExtentExtent.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
            }
            throw new Exception("Cannot marshal type ExtentExtent");
        }

        public static readonly ExtentExtentConverter Singleton = new ExtentExtentConverter();
    }
}