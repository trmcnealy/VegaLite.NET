using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SortOrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(SortOrder) || t == typeof(SortOrder?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "ascending":  return SortOrder.Ascending;
                case "descending": return SortOrder.Descending;
            }

            throw new Exception("Cannot unmarshal type SortOrder");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            SortOrder value = (SortOrder)untypedValue;

            switch(value)
            {
                case SortOrder.Ascending:
                    serializer.Serialize(writer,
                                         "ascending");

                    return;
                case SortOrder.Descending:
                    serializer.Serialize(writer,
                                         "descending");

                    return;
            }

            throw new Exception("Cannot marshal type SortOrder");
        }

        public static readonly SortOrderConverter Singleton = new SortOrderConverter();
    }
}
