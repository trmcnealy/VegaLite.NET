using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SortOrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortOrder) || t == typeof(SortOrder?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ascending":
                    return SortOrder.Ascending;
                case "descending":
                    return SortOrder.Descending;
            }
            throw new Exception("Cannot unmarshal type SortOrder");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SortOrder)untypedValue;
            switch (value)
            {
                case SortOrder.Ascending:
                    serializer.Serialize(writer, "ascending");
                    return;
                case SortOrder.Descending:
                    serializer.Serialize(writer, "descending");
                    return;
            }
            throw new Exception("Cannot marshal type SortOrder");
        }

        public static readonly SortOrderConverter Singleton = new SortOrderConverter();
    }
}