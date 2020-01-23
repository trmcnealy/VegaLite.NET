using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ScaleInterpolateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleInterpolate) || t == typeof(ScaleInterpolate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "cubehelix":
                    return ScaleInterpolate.Cubehelix;
                case "cubehelix-long":
                    return ScaleInterpolate.CubehelixLong;
                case "hcl":
                    return ScaleInterpolate.Hcl;
                case "hcl-long":
                    return ScaleInterpolate.HclLong;
                case "hsl":
                    return ScaleInterpolate.Hsl;
                case "hsl-long":
                    return ScaleInterpolate.HslLong;
                case "lab":
                    return ScaleInterpolate.Lab;
                case "rgb":
                    return ScaleInterpolate.Rgb;
            }
            throw new Exception("Cannot unmarshal type ScaleInterpolate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleInterpolate)untypedValue;
            switch (value)
            {
                case ScaleInterpolate.Cubehelix:
                    serializer.Serialize(writer, "cubehelix");
                    return;
                case ScaleInterpolate.CubehelixLong:
                    serializer.Serialize(writer, "cubehelix-long");
                    return;
                case ScaleInterpolate.Hcl:
                    serializer.Serialize(writer, "hcl");
                    return;
                case ScaleInterpolate.HclLong:
                    serializer.Serialize(writer, "hcl-long");
                    return;
                case ScaleInterpolate.Hsl:
                    serializer.Serialize(writer, "hsl");
                    return;
                case ScaleInterpolate.HslLong:
                    serializer.Serialize(writer, "hsl-long");
                    return;
                case ScaleInterpolate.Lab:
                    serializer.Serialize(writer, "lab");
                    return;
                case ScaleInterpolate.Rgb:
                    serializer.Serialize(writer, "rgb");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleInterpolate");
        }

        public static readonly ScaleInterpolateConverter Singleton = new ScaleInterpolateConverter();
    }
}