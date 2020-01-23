using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ScaleInterpolateParamsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleInterpolateParamsType) || t == typeof(ScaleInterpolateParamsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "cubehelix":
                    return ScaleInterpolateParamsType.Cubehelix;
                case "cubehelix-long":
                    return ScaleInterpolateParamsType.CubehelixLong;
                case "rgb":
                    return ScaleInterpolateParamsType.Rgb;
            }
            throw new Exception("Cannot unmarshal type ScaleInterpolateParamsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleInterpolateParamsType)untypedValue;
            switch (value)
            {
                case ScaleInterpolateParamsType.Cubehelix:
                    serializer.Serialize(writer, "cubehelix");
                    return;
                case ScaleInterpolateParamsType.CubehelixLong:
                    serializer.Serialize(writer, "cubehelix-long");
                    return;
                case ScaleInterpolateParamsType.Rgb:
                    serializer.Serialize(writer, "rgb");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleInterpolateParamsType");
        }

        public static readonly ScaleInterpolateParamsTypeConverter Singleton = new ScaleInterpolateParamsTypeConverter();
    }
}