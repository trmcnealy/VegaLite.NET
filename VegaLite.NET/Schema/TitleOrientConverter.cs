using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TitleOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(TitleOrient) || t == typeof(TitleOrient?);
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
                case "bottom": return TitleOrient.Bottom;
                case "left":   return TitleOrient.Left;
                case "none":   return TitleOrient.None;
                case "right":  return TitleOrient.Right;
                case "top":    return TitleOrient.Top;
            }

            throw new Exception("Cannot unmarshal type TitleOrient");
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

            TitleOrient value = (TitleOrient)untypedValue;

            switch(value)
            {
                case TitleOrient.Bottom:
                    serializer.Serialize(writer,
                                         "bottom");

                    return;
                case TitleOrient.Left:
                    serializer.Serialize(writer,
                                         "left");

                    return;
                case TitleOrient.None:
                    serializer.Serialize(writer,
                                         "none");

                    return;
                case TitleOrient.Right:
                    serializer.Serialize(writer,
                                         "right");

                    return;
                case TitleOrient.Top:
                    serializer.Serialize(writer,
                                         "top");

                    return;
            }

            throw new Exception("Cannot marshal type TitleOrient");
        }

        public static readonly TitleOrientConverter Singleton = new TitleOrientConverter();
    }
}
