using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FontWeightEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontWeightEnum) || t == typeof(FontWeightEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bold":
                    return FontWeightEnum.Bold;
                case "bolder":
                    return FontWeightEnum.Bolder;
                case "lighter":
                    return FontWeightEnum.Lighter;
                case "normal":
                    return FontWeightEnum.Normal;
            }
            throw new Exception("Cannot unmarshal type PurpleFontWeight");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FontWeightEnum)untypedValue;
            switch (value)
            {
                case FontWeightEnum.Bold:
                    serializer.Serialize(writer, "bold");
                    return;
                case FontWeightEnum.Bolder:
                    serializer.Serialize(writer, "bolder");
                    return;
                case FontWeightEnum.Lighter:
                    serializer.Serialize(writer, "lighter");
                    return;
                case FontWeightEnum.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleFontWeight");
        }

        public static readonly FontWeightEnumConverter Singleton = new FontWeightEnumConverter();
    }
}