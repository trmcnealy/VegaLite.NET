using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LabelFontStyleConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(LabelFontStyle) || t == typeof(LabelFontStyle?);
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

                    return new LabelFontStyle
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    ConditionalAxisPropertyFontStyleNull objectValue = serializer.Deserialize<ConditionalAxisPropertyFontStyleNull>(reader);

                    return new LabelFontStyle
                    {
                        ConditionalAxisPropertyFontStyleNull = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type LabelFontStyle");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            LabelFontStyle value = (LabelFontStyle)untypedValue;

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.ConditionalAxisPropertyFontStyleNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalAxisPropertyFontStyleNull);

                return;
            }

            throw new Exception("Cannot marshal type LabelFontStyle");
        }

        public static readonly LabelFontStyleConverter Singleton = new LabelFontStyleConverter();
    }
}
