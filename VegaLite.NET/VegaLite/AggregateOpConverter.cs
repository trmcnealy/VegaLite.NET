using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AggregateOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AggregateOp) || t == typeof(AggregateOp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "argmax":
                    return AggregateOp.Argmax;
                case "argmin":
                    return AggregateOp.Argmin;
                case "average":
                    return AggregateOp.Average;
                case "ci0":
                    return AggregateOp.Ci0;
                case "ci1":
                    return AggregateOp.Ci1;
                case "count":
                    return AggregateOp.Count;
                case "distinct":
                    return AggregateOp.Distinct;
                case "max":
                    return AggregateOp.Max;
                case "mean":
                    return AggregateOp.Mean;
                case "median":
                    return AggregateOp.Median;
                case "min":
                    return AggregateOp.Min;
                case "missing":
                    return AggregateOp.Missing;
                case "q1":
                    return AggregateOp.Q1;
                case "q3":
                    return AggregateOp.Q3;
                case "stderr":
                    return AggregateOp.Stderr;
                case "stdev":
                    return AggregateOp.Stdev;
                case "stdevp":
                    return AggregateOp.Stdevp;
                case "sum":
                    return AggregateOp.Sum;
                case "valid":
                    return AggregateOp.Valid;
                case "values":
                    return AggregateOp.Values;
                case "variance":
                    return AggregateOp.Variance;
                case "variancep":
                    return AggregateOp.Variancep;
            }
            throw new Exception("Cannot unmarshal type AggregateOp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AggregateOp)untypedValue;
            switch (value)
            {
                case AggregateOp.Argmax:
                    serializer.Serialize(writer, "argmax");
                    return;
                case AggregateOp.Argmin:
                    serializer.Serialize(writer, "argmin");
                    return;
                case AggregateOp.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case AggregateOp.Ci0:
                    serializer.Serialize(writer, "ci0");
                    return;
                case AggregateOp.Ci1:
                    serializer.Serialize(writer, "ci1");
                    return;
                case AggregateOp.Count:
                    serializer.Serialize(writer, "count");
                    return;
                case AggregateOp.Distinct:
                    serializer.Serialize(writer, "distinct");
                    return;
                case AggregateOp.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case AggregateOp.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case AggregateOp.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case AggregateOp.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case AggregateOp.Missing:
                    serializer.Serialize(writer, "missing");
                    return;
                case AggregateOp.Q1:
                    serializer.Serialize(writer, "q1");
                    return;
                case AggregateOp.Q3:
                    serializer.Serialize(writer, "q3");
                    return;
                case AggregateOp.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case AggregateOp.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
                case AggregateOp.Stdevp:
                    serializer.Serialize(writer, "stdevp");
                    return;
                case AggregateOp.Sum:
                    serializer.Serialize(writer, "sum");
                    return;
                case AggregateOp.Valid:
                    serializer.Serialize(writer, "valid");
                    return;
                case AggregateOp.Values:
                    serializer.Serialize(writer, "values");
                    return;
                case AggregateOp.Variance:
                    serializer.Serialize(writer, "variance");
                    return;
                case AggregateOp.Variancep:
                    serializer.Serialize(writer, "variancep");
                    return;
            }
            throw new Exception("Cannot marshal type AggregateOp");
        }

        public static readonly AggregateOpConverter Singleton = new AggregateOpConverter();
    }
}