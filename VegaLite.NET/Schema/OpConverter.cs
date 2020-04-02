using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class OpConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Op) || t == typeof(Op?);
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
                case "argmax":       return Op.Argmax;
                case "argmin":       return Op.Argmin;
                case "average":      return Op.Average;
                case "ci0":          return Op.Ci0;
                case "ci1":          return Op.Ci1;
                case "count":        return Op.Count;
                case "cume_dist":    return Op.CumeDist;
                case "dense_rank":   return Op.DenseRank;
                case "distinct":     return Op.Distinct;
                case "first_value":  return Op.FirstValue;
                case "lag":          return Op.Lag;
                case "last_value":   return Op.LastValue;
                case "lead":         return Op.Lead;
                case "max":          return Op.Max;
                case "mean":         return Op.Mean;
                case "median":       return Op.Median;
                case "min":          return Op.Min;
                case "missing":      return Op.Missing;
                case "nth_value":    return Op.NthValue;
                case "ntile":        return Op.Ntile;
                case "percent_rank": return Op.PercentRank;
                case "q1":           return Op.Q1;
                case "q3":           return Op.Q3;
                case "rank":         return Op.Rank;
                case "row_number":   return Op.RowNumber;
                case "stderr":       return Op.Stderr;
                case "stdev":        return Op.Stdev;
                case "stdevp":       return Op.Stdevp;
                case "sum":          return Op.Sum;
                case "valid":        return Op.Valid;
                case "values":       return Op.Values;
                case "variance":     return Op.Variance;
                case "variancep":    return Op.Variancep;
            }

            throw new Exception("Cannot unmarshal type Op");
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

            Op value = (Op)untypedValue;

            switch(value)
            {
                case Op.Argmax:
                    serializer.Serialize(writer,
                                         "argmax");

                    return;
                case Op.Argmin:
                    serializer.Serialize(writer,
                                         "argmin");

                    return;
                case Op.Average:
                    serializer.Serialize(writer,
                                         "average");

                    return;
                case Op.Ci0:
                    serializer.Serialize(writer,
                                         "ci0");

                    return;
                case Op.Ci1:
                    serializer.Serialize(writer,
                                         "ci1");

                    return;
                case Op.Count:
                    serializer.Serialize(writer,
                                         "count");

                    return;
                case Op.CumeDist:
                    serializer.Serialize(writer,
                                         "cume_dist");

                    return;
                case Op.DenseRank:
                    serializer.Serialize(writer,
                                         "dense_rank");

                    return;
                case Op.Distinct:
                    serializer.Serialize(writer,
                                         "distinct");

                    return;
                case Op.FirstValue:
                    serializer.Serialize(writer,
                                         "first_value");

                    return;
                case Op.Lag:
                    serializer.Serialize(writer,
                                         "lag");

                    return;
                case Op.LastValue:
                    serializer.Serialize(writer,
                                         "last_value");

                    return;
                case Op.Lead:
                    serializer.Serialize(writer,
                                         "lead");

                    return;
                case Op.Max:
                    serializer.Serialize(writer,
                                         "max");

                    return;
                case Op.Mean:
                    serializer.Serialize(writer,
                                         "mean");

                    return;
                case Op.Median:
                    serializer.Serialize(writer,
                                         "median");

                    return;
                case Op.Min:
                    serializer.Serialize(writer,
                                         "min");

                    return;
                case Op.Missing:
                    serializer.Serialize(writer,
                                         "missing");

                    return;
                case Op.NthValue:
                    serializer.Serialize(writer,
                                         "nth_value");

                    return;
                case Op.Ntile:
                    serializer.Serialize(writer,
                                         "ntile");

                    return;
                case Op.PercentRank:
                    serializer.Serialize(writer,
                                         "percent_rank");

                    return;
                case Op.Q1:
                    serializer.Serialize(writer,
                                         "q1");

                    return;
                case Op.Q3:
                    serializer.Serialize(writer,
                                         "q3");

                    return;
                case Op.Rank:
                    serializer.Serialize(writer,
                                         "rank");

                    return;
                case Op.RowNumber:
                    serializer.Serialize(writer,
                                         "row_number");

                    return;
                case Op.Stderr:
                    serializer.Serialize(writer,
                                         "stderr");

                    return;
                case Op.Stdev:
                    serializer.Serialize(writer,
                                         "stdev");

                    return;
                case Op.Stdevp:
                    serializer.Serialize(writer,
                                         "stdevp");

                    return;
                case Op.Sum:
                    serializer.Serialize(writer,
                                         "sum");

                    return;
                case Op.Valid:
                    serializer.Serialize(writer,
                                         "valid");

                    return;
                case Op.Values:
                    serializer.Serialize(writer,
                                         "values");

                    return;
                case Op.Variance:
                    serializer.Serialize(writer,
                                         "variance");

                    return;
                case Op.Variancep:
                    serializer.Serialize(writer,
                                         "variancep");

                    return;
            }

            throw new Exception("Cannot marshal type Op");
        }

        public static readonly OpConverter Singleton = new OpConverter();
    }
}
