using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleRange) || t == typeof(PurpleRange?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new PurpleRange();
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new PurpleRange { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new PurpleRange { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type PurpleRange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleRange)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type PurpleRange");
        }

        public static readonly PurpleRangeConverter Singleton = new PurpleRangeConverter();
    }
}