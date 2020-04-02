using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BaselineConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Baseline) || t == typeof(Baseline?);
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
                case "alphabetic": return Baseline.Alphabetic;
                case "bottom":     return Baseline.Bottom;
                case "middle":     return Baseline.Middle;
                case "top":        return Baseline.Top;
            }

            throw new Exception("Cannot unmarshal type Baseline");
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

            Baseline value = (Baseline)untypedValue;

            switch(value)
            {
                case Baseline.Alphabetic:
                    serializer.Serialize(writer,
                                         "alphabetic");

                    return;
                case Baseline.Bottom:
                    serializer.Serialize(writer,
                                         "bottom");

                    return;
                case Baseline.Middle:
                    serializer.Serialize(writer,
                                         "middle");

                    return;
                case Baseline.Top:
                    serializer.Serialize(writer,
                                         "top");

                    return;
            }

            throw new Exception("Cannot marshal type Baseline");
        }

        public static readonly BaselineConverter Singleton = new BaselineConverter();
    }
}
