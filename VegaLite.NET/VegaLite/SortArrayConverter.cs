using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SortArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortArray) || t == typeof(SortArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new SortArray { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "ascending":
                            return new SortArray { Enum = SortOrder.Ascending };
                        case "descending":
                            return new SortArray { Enum = SortOrder.Descending };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SortEncodingSortField>(reader);
                    return new SortArray { SortEncodingSortField = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Equal>>(reader);
                    return new SortArray { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SortArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SortArray)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case SortOrder.Ascending:
                        serializer.Serialize(writer, "ascending");
                        return;
                    case SortOrder.Descending:
                        serializer.Serialize(writer, "descending");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.SortEncodingSortField != null)
            {
                serializer.Serialize(writer, value.SortEncodingSortField);
                return;
            }
            throw new Exception("Cannot marshal type SortArray");
        }

        public static readonly SortArrayConverter Singleton = new SortArrayConverter();
    }
}