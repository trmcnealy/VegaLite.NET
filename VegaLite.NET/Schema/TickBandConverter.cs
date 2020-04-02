using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TickBandConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(TickBand) || t == typeof(TickBand?);
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
                case "center": return TickBand.Center;
                case "extent": return TickBand.Extent;
            }

            throw new Exception("Cannot unmarshal type TickBand");
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

            TickBand value = (TickBand)untypedValue;

            switch(value)
            {
                case TickBand.Center:
                    serializer.Serialize(writer,
                                         "center");

                    return;
                case TickBand.Extent:
                    serializer.Serialize(writer,
                                         "extent");

                    return;
            }

            throw new Exception("Cannot marshal type TickBand");
        }

        public static readonly TickBandConverter Singleton = new TickBandConverter();
    }
}
