using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class InterpolateUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InterpolateUnion) || t == typeof(InterpolateUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "cubehelix":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Cubehelix };
                        case "cubehelix-long":
                            return new InterpolateUnion { Enum = ScaleInterpolate.CubehelixLong };
                        case "hcl":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Hcl };
                        case "hcl-long":
                            return new InterpolateUnion { Enum = ScaleInterpolate.HclLong };
                        case "hsl":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Hsl };
                        case "hsl-long":
                            return new InterpolateUnion { Enum = ScaleInterpolate.HslLong };
                        case "lab":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Lab };
                        case "rgb":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Rgb };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ScaleInterpolateParams>(reader);
                    return new InterpolateUnion { ScaleInterpolateParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type InterpolateUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InterpolateUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
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
            }
            if (value.ScaleInterpolateParams != null)
            {
                serializer.Serialize(writer, value.ScaleInterpolateParams);
                return;
            }
            throw new Exception("Cannot marshal type InterpolateUnion");
        }

        public static readonly InterpolateUnionConverter Singleton = new InterpolateUnionConverter();
    }
}