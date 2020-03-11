using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SignalRefExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SignalRefExtent) || t == typeof(SignalRefExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SignalRef>(reader);
                    return new SignalRefExtent { SignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRawArray>>(reader);
                    return new SignalRefExtent { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SignalRefExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SignalRefExtent)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.SignalRef != null)
            {
                serializer.Serialize(writer, value.SignalRef);
                return;
            }
            throw new Exception("Cannot marshal type SignalRefExtent");
        }

        public static readonly SignalRefExtentConverter Singleton = new SignalRefExtentConverter();
    }
}