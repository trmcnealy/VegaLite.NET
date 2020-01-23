using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LayoutAlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutAlign) || t == typeof(LayoutAlign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return LayoutAlign.All;
                case "each":
                    return LayoutAlign.Each;
                case "none":
                    return LayoutAlign.None;
            }
            throw new Exception("Cannot unmarshal type LayoutAlign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LayoutAlign)untypedValue;
            switch (value)
            {
                case LayoutAlign.All:
                    serializer.Serialize(writer, "all");
                    return;
                case LayoutAlign.Each:
                    serializer.Serialize(writer, "each");
                    return;
                case LayoutAlign.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type LayoutAlign");
        }

        public static readonly LayoutAlignConverter Singleton = new LayoutAlignConverter();
    }
}