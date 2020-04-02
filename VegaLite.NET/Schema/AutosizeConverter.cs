using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class AutosizeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Autosize) || t == typeof(Autosize?);
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
                        case "fit":
                            return new Autosize
                            {
                                Enum = AutosizeType.Fit
                            };
                        case "fit-x":
                            return new Autosize
                            {
                                Enum = AutosizeType.FitX
                            };
                        case "fit-y":
                            return new Autosize
                            {
                                Enum = AutosizeType.FitY
                            };
                        case "none":
                            return new Autosize
                            {
                                Enum = AutosizeType.None
                            };
                        case "pad":
                            return new Autosize
                            {
                                Enum = AutosizeType.Pad
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    AutoSizeParams objectValue = serializer.Deserialize<AutoSizeParams>(reader);

                    return new Autosize
                    {
                        AutoSizeParams = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Autosize");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Autosize value = (Autosize)untypedValue;

            if(value.Enum != null)
            {
                switch(value.Enum)
                {
                    case AutosizeType.Fit:
                        serializer.Serialize(writer,
                                             "fit");

                        return;
                    case AutosizeType.FitX:
                        serializer.Serialize(writer,
                                             "fit-x");

                        return;
                    case AutosizeType.FitY:
                        serializer.Serialize(writer,
                                             "fit-y");

                        return;
                    case AutosizeType.None:
                        serializer.Serialize(writer,
                                             "none");

                        return;
                    case AutosizeType.Pad:
                        serializer.Serialize(writer,
                                             "pad");

                        return;
                }
            }

            if(value.AutoSizeParams != null)
            {
                serializer.Serialize(writer,
                                     value.AutoSizeParams);

                return;
            }

            throw new Exception("Cannot marshal type Autosize");
        }

        public static readonly AutosizeConverter Singleton = new AutosizeConverter();
    }
}
