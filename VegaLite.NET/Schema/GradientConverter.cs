using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class GradientConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Gradient) || t == typeof(Gradient?);
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
                case "linear": return Gradient.Linear;
                case "radial": return Gradient.Radial;
            }

            throw new Exception("Cannot unmarshal type Gradient");
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

            Gradient value = (Gradient)untypedValue;

            switch(value)
            {
                case Gradient.Linear:
                    serializer.Serialize(writer,
                                         "linear");

                    return;
                case Gradient.Radial:
                    serializer.Serialize(writer,
                                         "radial");

                    return;
            }

            throw new Exception("Cannot marshal type Gradient");
        }

        public static readonly GradientConverter Singleton = new GradientConverter();
    }
}
