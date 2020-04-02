using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class OrientationConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Orientation) || t == typeof(Orientation?);
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
                case "horizontal": return Orientation.Horizontal;
                case "vertical":   return Orientation.Vertical;
            }

            throw new Exception("Cannot unmarshal type Orientation");
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

            Orientation value = (Orientation)untypedValue;

            switch(value)
            {
                case Orientation.Horizontal:
                    serializer.Serialize(writer,
                                         "horizontal");

                    return;
                case Orientation.Vertical:
                    serializer.Serialize(writer,
                                         "vertical");

                    return;
            }

            throw new Exception("Cannot marshal type Orientation");
        }

        public static readonly OrientationConverter Singleton = new OrientationConverter();
    }
}
