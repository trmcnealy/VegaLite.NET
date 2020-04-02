using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class AggregateConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Aggregate) || t == typeof(Aggregate?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    switch(stringValue)
                    {
                        case "average":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Average
                            };
                        case "ci0":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Ci0
                            };
                        case "ci1":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Ci1
                            };
                        case "count":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Count
                            };
                        case "distinct":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Distinct
                            };
                        case "max":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Max
                            };
                        case "mean":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Mean
                            };
                        case "median":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Median
                            };
                        case "min":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Min
                            };
                        case "missing":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Missing
                            };
                        case "q1":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Q1
                            };
                        case "q3":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Q3
                            };
                        case "stderr":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Stderr
                            };
                        case "stdev":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Stdev
                            };
                        case "stdevp":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Stdevp
                            };
                        case "sum":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Sum
                            };
                        case "valid":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Valid
                            };
                        case "values":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Values
                            };
                        case "variance":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Variance
                            };
                        case "variancep":
                            return new Aggregate
                            {
                                Enum = NonArgAggregateOp.Variancep
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    ArgmDef objectValue = serializer.Deserialize<ArgmDef>(reader);

                    return new Aggregate
                    {
                        ArgmDef = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Aggregate");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Aggregate value = (Aggregate)untypedValue;

            if(value.Enum != null)
            {
                switch(value.Enum)
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
            }

            if(value.ArgmDef != null)
            {
                serializer.Serialize(writer,
                                     value.ArgmDef);

                return;
            }

            throw new Exception("Cannot marshal type Aggregate");
        }

        public static readonly AggregateConverter Singleton = new AggregateConverter();
    }
}
