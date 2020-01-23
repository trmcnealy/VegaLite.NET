using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class TransformMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformMethod) || t == typeof(TransformMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "exp":
                    return TransformMethod.Exp;
                case "linear":
                    return TransformMethod.Linear;
                case "log":
                    return TransformMethod.Log;
                case "max":
                    return TransformMethod.Max;
                case "mean":
                    return TransformMethod.Mean;
                case "median":
                    return TransformMethod.Median;
                case "min":
                    return TransformMethod.Min;
                case "poly":
                    return TransformMethod.Poly;
                case "pow":
                    return TransformMethod.Pow;
                case "quad":
                    return TransformMethod.Quad;
                case "value":
                    return TransformMethod.Value;
            }
            throw new Exception("Cannot unmarshal type TransformMethod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransformMethod)untypedValue;
            switch (value)
            {
                case TransformMethod.Exp:
                    serializer.Serialize(writer, "exp");
                    return;
                case TransformMethod.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case TransformMethod.Log:
                    serializer.Serialize(writer, "log");
                    return;
                case TransformMethod.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case TransformMethod.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case TransformMethod.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case TransformMethod.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case TransformMethod.Poly:
                    serializer.Serialize(writer, "poly");
                    return;
                case TransformMethod.Pow:
                    serializer.Serialize(writer, "pow");
                    return;
                case TransformMethod.Quad:
                    serializer.Serialize(writer, "quad");
                    return;
                case TransformMethod.Value:
                    serializer.Serialize(writer, "value");
                    return;
            }
            throw new Exception("Cannot marshal type TransformMethod");
        }

        public static readonly TransformMethodConverter Singleton = new TransformMethodConverter();
    }
}