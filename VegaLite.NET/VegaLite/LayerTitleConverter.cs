using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LayerTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayerTitle) || t == typeof(LayerTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LayerTitle { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TitleParams>(reader);
                    return new LayerTitle { TitleParams = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new LayerTitle { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LayerTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayerTitle)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.TitleParams != null)
            {
                serializer.Serialize(writer, value.TitleParams);
                return;
            }
            throw new Exception("Cannot marshal type LayerTitle");
        }

        public static readonly LayerTitleConverter Singleton = new LayerTitleConverter();
    }
}