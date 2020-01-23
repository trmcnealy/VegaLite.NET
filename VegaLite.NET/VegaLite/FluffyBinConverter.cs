using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FluffyBinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyBin) || t == typeof(FluffyBin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FluffyBin { };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new FluffyBin { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "binned")
                    {
                        return new FluffyBin { Enum = BinEnum.Binned };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinParams>(reader);
                    return new FluffyBin { BinParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type FluffyBin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FluffyBin)untypedValue;
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
            if (value.Enum != null)
            {
                if (value.Enum == BinEnum.Binned)
                {
                    serializer.Serialize(writer, "binned");
                    return;
                }
            }
            if (value.BinParams != null)
            {
                serializer.Serialize(writer, value.BinParams);
                return;
            }
            throw new Exception("Cannot marshal type FluffyBin");
        }

        public static readonly FluffyBinConverter Singleton = new FluffyBinConverter();
    }
}