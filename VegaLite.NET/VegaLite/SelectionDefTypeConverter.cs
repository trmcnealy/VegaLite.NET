using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SelectionDefTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionDefType) || t == typeof(SelectionDefType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "interval":
                    return SelectionDefType.Interval;
                case "multi":
                    return SelectionDefType.Multi;
                case "single":
                    return SelectionDefType.Single;
            }
            throw new Exception("Cannot unmarshal type SelectionDefType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SelectionDefType)untypedValue;
            switch (value)
            {
                case SelectionDefType.Interval:
                    serializer.Serialize(writer, "interval");
                    return;
                case SelectionDefType.Multi:
                    serializer.Serialize(writer, "multi");
                    return;
                case SelectionDefType.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type SelectionDefType");
        }

        public static readonly SelectionDefTypeConverter Singleton = new SelectionDefTypeConverter();
    }
}