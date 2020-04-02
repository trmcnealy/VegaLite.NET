using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DirConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Dir) || t == typeof(Dir?);
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
                case "ltr": return Dir.Ltr;
                case "rtl": return Dir.Rtl;
            }

            throw new Exception("Cannot unmarshal type Dir");
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

            Dir value = (Dir)untypedValue;

            switch(value)
            {
                case Dir.Ltr:
                    serializer.Serialize(writer,
                                         "ltr");

                    return;
                case Dir.Rtl:
                    serializer.Serialize(writer,
                                         "rtl");

                    return;
            }

            throw new Exception("Cannot marshal type Dir");
        }

        public static readonly DirConverter Singleton = new DirConverter();
    }
}
