using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LabelFontConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFont) || t == typeof(LabelFont?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LabelFont { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyStringNull>(reader);
                    return new LabelFont { ConditionalAxisPropertyStringNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelFont");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFont)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ConditionalAxisPropertyStringNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyStringNull);
                return;
            }
            throw new Exception("Cannot marshal type LabelFont");
        }

        public static readonly LabelFontConverter Singleton = new LabelFontConverter();
    }
}