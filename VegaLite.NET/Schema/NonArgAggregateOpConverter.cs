using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class NonArgAggregateOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(NonArgAggregateOp) || t == typeof(NonArgAggregateOp?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "average":   return NonArgAggregateOp.Average;
                case "ci0":       return NonArgAggregateOp.Ci0;
                case "ci1":       return NonArgAggregateOp.Ci1;
                case "count":     return NonArgAggregateOp.Count;
                case "distinct":  return NonArgAggregateOp.Distinct;
                case "max":       return NonArgAggregateOp.Max;
                case "mean":      return NonArgAggregateOp.Mean;
                case "median":    return NonArgAggregateOp.Median;
                case "min":       return NonArgAggregateOp.Min;
                case "missing":   return NonArgAggregateOp.Missing;
                case "q1":        return NonArgAggregateOp.Q1;
                case "q3":        return NonArgAggregateOp.Q3;
                case "stderr":    return NonArgAggregateOp.Stderr;
                case "stdev":     return NonArgAggregateOp.Stdev;
                case "stdevp":    return NonArgAggregateOp.Stdevp;
                case "sum":       return NonArgAggregateOp.Sum;
                case "valid":     return NonArgAggregateOp.Valid;
                case "values":    return NonArgAggregateOp.Values;
                case "variance":  return NonArgAggregateOp.Variance;
                case "variancep": return NonArgAggregateOp.Variancep;
            }

            throw new Exception("Cannot unmarshal type NonArgAggregateOp");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            NonArgAggregateOp value = (NonArgAggregateOp)untypedValue;

            switch(value)
            {
                case NonArgAggregateOp.Average:
                    serializer.Serialize(writer,
                                         "average");

                    return;
                case NonArgAggregateOp.Ci0:
                    serializer.Serialize(writer,
                                         "ci0");

                    return;
                case NonArgAggregateOp.Ci1:
                    serializer.Serialize(writer,
                                         "ci1");

                    return;
                case NonArgAggregateOp.Count:
                    serializer.Serialize(writer,
                                         "count");

                    return;
                case NonArgAggregateOp.Distinct:
                    serializer.Serialize(writer,
                                         "distinct");

                    return;
                case NonArgAggregateOp.Max:
                    serializer.Serialize(writer,
                                         "max");

                    return;
                case NonArgAggregateOp.Mean:
                    serializer.Serialize(writer,
                                         "mean");

                    return;
                case NonArgAggregateOp.Median:
                    serializer.Serialize(writer,
                                         "median");

                    return;
                case NonArgAggregateOp.Min:
                    serializer.Serialize(writer,
                                         "min");

                    return;
                case NonArgAggregateOp.Missing:
                    serializer.Serialize(writer,
                                         "missing");

                    return;
                case NonArgAggregateOp.Q1:
                    serializer.Serialize(writer,
                                         "q1");

                    return;
                case NonArgAggregateOp.Q3:
                    serializer.Serialize(writer,
                                         "q3");

                    return;
                case NonArgAggregateOp.Stderr:
                    serializer.Serialize(writer,
                                         "stderr");

                    return;
                case NonArgAggregateOp.Stdev:
                    serializer.Serialize(writer,
                                         "stdev");

                    return;
                case NonArgAggregateOp.Stdevp:
                    serializer.Serialize(writer,
                                         "stdevp");

                    return;
                case NonArgAggregateOp.Sum:
                    serializer.Serialize(writer,
                                         "sum");

                    return;
                case NonArgAggregateOp.Valid:
                    serializer.Serialize(writer,
                                         "valid");

                    return;
                case NonArgAggregateOp.Values:
                    serializer.Serialize(writer,
                                         "values");

                    return;
                case NonArgAggregateOp.Variance:
                    serializer.Serialize(writer,
                                         "variance");

                    return;
                case NonArgAggregateOp.Variancep:
                    serializer.Serialize(writer,
                                         "variancep");

                    return;
            }

            throw new Exception("Cannot marshal type NonArgAggregateOp");
        }

        public static readonly NonArgAggregateOpConverter Singleton = new NonArgAggregateOpConverter();
    }
}
