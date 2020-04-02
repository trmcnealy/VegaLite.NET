using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LayoutBoundsConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(LayoutBounds) || t == typeof(LayoutBounds?);
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

                    switch(stringValue)
                    {
                        case "flush":
                            return new LayoutBounds
                            {
                                Enum = BoundsEnum.Flush
                            };
                        case "full":
                            return new LayoutBounds
                            {
                                Enum = BoundsEnum.Full
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    SignalRef objectValue = serializer.Deserialize<SignalRef>(reader);

                    return new LayoutBounds
                    {
                        SignalRef = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type LayoutBounds");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            LayoutBounds value = (LayoutBounds)untypedValue;

            if(value.Enum != null)
            {
                switch(value.Enum)
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
            }

            if(value.SignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.SignalRef);

                return;
            }

            throw new Exception("Cannot marshal type LayoutBounds");
        }

        public static readonly LayoutBoundsConverter Singleton = new LayoutBoundsConverter();
    }
}
