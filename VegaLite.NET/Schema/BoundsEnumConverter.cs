using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BoundsEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(BoundsEnum) || t == typeof(BoundsEnum?);
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
                case "flush": return BoundsEnum.Flush;
                case "full":  return BoundsEnum.Full;
            }

            throw new Exception("Cannot unmarshal type BoundsEnum");
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

            BoundsEnum value = (BoundsEnum)untypedValue;

            switch(value)
            {
                case BoundsEnum.Flush:
                    serializer.Serialize(writer,
                                         "flush");

                    return;
                case BoundsEnum.Full:
                    serializer.Serialize(writer,
                                         "full");

                    return;
            }

            throw new Exception("Cannot marshal type BoundsEnum");
        }

        public static readonly BoundsEnumConverter Singleton = new BoundsEnumConverter();
    }
}
