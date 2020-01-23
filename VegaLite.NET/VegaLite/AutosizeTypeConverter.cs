using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AutosizeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AutosizeType) || t == typeof(AutosizeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fit":
                    return AutosizeType.Fit;
                case "fit-x":
                    return AutosizeType.FitX;
                case "fit-y":
                    return AutosizeType.FitY;
                case "none":
                    return AutosizeType.None;
                case "pad":
                    return AutosizeType.Pad;
            }
            throw new Exception("Cannot unmarshal type AutosizeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AutosizeType)untypedValue;
            switch (value)
            {
                case AutosizeType.Fit:
                    serializer.Serialize(writer, "fit");
                    return;
                case AutosizeType.FitX:
                    serializer.Serialize(writer, "fit-x");
                    return;
                case AutosizeType.FitY:
                    serializer.Serialize(writer, "fit-y");
                    return;
                case AutosizeType.None:
                    serializer.Serialize(writer, "none");
                    return;
                case AutosizeType.Pad:
                    serializer.Serialize(writer, "pad");
                    return;
            }
            throw new Exception("Cannot marshal type AutosizeType");
        }

        public static readonly AutosizeTypeConverter Singleton = new AutosizeTypeConverter();
    }
}