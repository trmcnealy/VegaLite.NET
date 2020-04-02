using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ImputeParamsMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ImputeParamsMethod) || t == typeof(ImputeParamsMethod?);
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
                case "max":    return ImputeParamsMethod.Max;
                case "mean":   return ImputeParamsMethod.Mean;
                case "median": return ImputeParamsMethod.Median;
                case "min":    return ImputeParamsMethod.Min;
                case "value":  return ImputeParamsMethod.Value;
            }

            throw new Exception("Cannot unmarshal type ImputeParamsMethod");
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

            ImputeParamsMethod value = (ImputeParamsMethod)untypedValue;

            switch(value)
            {
                case ImputeParamsMethod.Max:
                    serializer.Serialize(writer,
                                         "max");

                    return;
                case ImputeParamsMethod.Mean:
                    serializer.Serialize(writer,
                                         "mean");

                    return;
                case ImputeParamsMethod.Median:
                    serializer.Serialize(writer,
                                         "median");

                    return;
                case ImputeParamsMethod.Min:
                    serializer.Serialize(writer,
                                         "min");

                    return;
                case ImputeParamsMethod.Value:
                    serializer.Serialize(writer,
                                         "value");

                    return;
            }

            throw new Exception("Cannot marshal type ImputeParamsMethod");
        }

        public static readonly ImputeParamsMethodConverter Singleton = new ImputeParamsMethodConverter();
    }
}
