using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleBinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoolBinParams) || t == typeof(BoolBinParams?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new BoolBinParams();
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new BoolBinParams { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinParams>(reader);
                    return new BoolBinParams { BinParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type BoolBinParams");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BoolBinParams)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.BinParams != null)
            {
                serializer.Serialize(writer, value.BinParams);
                return;
            }
            throw new Exception("Cannot marshal type BoolBinParams");
        }

        public static readonly PurpleBinConverter Singleton = new PurpleBinConverter();
    }
}