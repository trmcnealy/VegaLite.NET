using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class InlineDatasetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InlineDataset) || t == typeof(InlineDataset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new InlineDataset { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, object>>(reader);
                    return new InlineDataset { AnythingMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<InlineDatasetElement>>(reader);
                    return new InlineDataset { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type InlineDataset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InlineDataset)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type InlineDataset");
        }

        public static readonly InlineDatasetConverter Singleton = new InlineDatasetConverter();
    }
}