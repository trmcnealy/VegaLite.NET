using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TitleAnchorEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(TitleAnchorEnum) || t == typeof(TitleAnchorEnum?);
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
                case "end":    return TitleAnchorEnum.End;
                case "middle": return TitleAnchorEnum.Middle;
                case "start":  return TitleAnchorEnum.Start;
            }

            throw new Exception("Cannot unmarshal type TitleAnchorEnum");
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

            TitleAnchorEnum value = (TitleAnchorEnum)untypedValue;

            switch(value)
            {
                case TitleAnchorEnum.End:
                    serializer.Serialize(writer,
                                         "end");

                    return;
                case TitleAnchorEnum.Middle:
                    serializer.Serialize(writer,
                                         "middle");

                    return;
                case TitleAnchorEnum.Start:
                    serializer.Serialize(writer,
                                         "start");

                    return;
            }

            throw new Exception("Cannot marshal type TitleAnchorEnum");
        }

        public static readonly TitleAnchorEnumConverter Singleton = new TitleAnchorEnumConverter();
    }
}
