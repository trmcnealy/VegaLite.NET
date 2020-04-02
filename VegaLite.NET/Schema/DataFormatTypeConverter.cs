using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DataFormatTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(DataFormatType) || t == typeof(DataFormatType?);
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
                case "csv":      return DataFormatType.Csv;
                case "dsv":      return DataFormatType.Dsv;
                case "json":     return DataFormatType.Json;
                case "topojson": return DataFormatType.Topojson;
                case "tsv":      return DataFormatType.Tsv;
            }

            throw new Exception("Cannot unmarshal type DataFormatType");
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

            DataFormatType value = (DataFormatType)untypedValue;

            switch(value)
            {
                case DataFormatType.Csv:
                    serializer.Serialize(writer,
                                         "csv");

                    return;
                case DataFormatType.Dsv:
                    serializer.Serialize(writer,
                                         "dsv");

                    return;
                case DataFormatType.Json:
                    serializer.Serialize(writer,
                                         "json");

                    return;
                case DataFormatType.Topojson:
                    serializer.Serialize(writer,
                                         "topojson");

                    return;
                case DataFormatType.Tsv:
                    serializer.Serialize(writer,
                                         "tsv");

                    return;
            }

            throw new Exception("Cannot marshal type DataFormatType");
        }

        public static readonly DataFormatTypeConverter Singleton = new DataFormatTypeConverter();
    }
}
