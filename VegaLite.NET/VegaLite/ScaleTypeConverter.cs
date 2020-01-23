using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ScaleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleType) || t == typeof(ScaleType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "band":
                    return ScaleType.Band;
                case "bin-ordinal":
                    return ScaleType.BinOrdinal;
                case "linear":
                    return ScaleType.Linear;
                case "log":
                    return ScaleType.Log;
                case "ordinal":
                    return ScaleType.Ordinal;
                case "point":
                    return ScaleType.Point;
                case "pow":
                    return ScaleType.Pow;
                case "quantile":
                    return ScaleType.Quantile;
                case "quantize":
                    return ScaleType.Quantize;
                case "sqrt":
                    return ScaleType.Sqrt;
                case "symlog":
                    return ScaleType.Symlog;
                case "threshold":
                    return ScaleType.Threshold;
                case "time":
                    return ScaleType.Time;
                case "utc":
                    return ScaleType.Utc;
            }
            throw new Exception("Cannot unmarshal type ScaleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleType)untypedValue;
            switch (value)
            {
                case ScaleType.Band:
                    serializer.Serialize(writer, "band");
                    return;
                case ScaleType.BinOrdinal:
                    serializer.Serialize(writer, "bin-ordinal");
                    return;
                case ScaleType.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case ScaleType.Log:
                    serializer.Serialize(writer, "log");
                    return;
                case ScaleType.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case ScaleType.Point:
                    serializer.Serialize(writer, "point");
                    return;
                case ScaleType.Pow:
                    serializer.Serialize(writer, "pow");
                    return;
                case ScaleType.Quantile:
                    serializer.Serialize(writer, "quantile");
                    return;
                case ScaleType.Quantize:
                    serializer.Serialize(writer, "quantize");
                    return;
                case ScaleType.Sqrt:
                    serializer.Serialize(writer, "sqrt");
                    return;
                case ScaleType.Symlog:
                    serializer.Serialize(writer, "symlog");
                    return;
                case ScaleType.Threshold:
                    serializer.Serialize(writer, "threshold");
                    return;
                case ScaleType.Time:
                    serializer.Serialize(writer, "time");
                    return;
                case ScaleType.Utc:
                    serializer.Serialize(writer, "utc");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleType");
        }

        public static readonly ScaleTypeConverter Singleton = new ScaleTypeConverter();
    }
}