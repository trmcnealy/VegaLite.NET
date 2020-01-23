using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BottomCenterConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BottomCenter) || t == typeof(BottomCenter?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new BottomCenter { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new BottomCenter { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type BottomCenter");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BottomCenter)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type BottomCenter");
        }

        public static readonly BottomCenterConverter Singleton = new BottomCenterConverter();
    }
}