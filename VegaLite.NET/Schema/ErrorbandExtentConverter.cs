using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ErrorbandExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ErrorbandExtent) || t == typeof(ErrorbandExtent?);
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
                case "ci":     return ErrorbandExtent.Ci;
                case "iqr":    return ErrorbandExtent.Iqr;
                case "stderr": return ErrorbandExtent.Stderr;
                case "stdev":  return ErrorbandExtent.Stdev;
            }

            throw new Exception("Cannot unmarshal type ErrorbandExtent");
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

            ErrorbandExtent value = (ErrorbandExtent)untypedValue;

            switch(value)
            {
                case ErrorbandExtent.Ci:
                    serializer.Serialize(writer,
                                         "ci");

                    return;
                case ErrorbandExtent.Iqr:
                    serializer.Serialize(writer,
                                         "iqr");

                    return;
                case ErrorbandExtent.Stderr:
                    serializer.Serialize(writer,
                                         "stderr");

                    return;
                case ErrorbandExtent.Stdev:
                    serializer.Serialize(writer,
                                         "stdev");

                    return;
            }

            throw new Exception("Cannot marshal type ErrorbandExtent");
        }

        public static readonly ErrorbandExtentConverter Singleton = new ErrorbandExtentConverter();
    }
}
