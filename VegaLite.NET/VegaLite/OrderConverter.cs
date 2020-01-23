using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class OrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Order) || t == typeof(Order?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OrderFieldDefClass>(reader);
                    return new Order { OrderFieldDefClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<OrderFieldDef>>(reader);
                    return new Order { OrderFieldDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Order");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Order)untypedValue;
            if (value.OrderFieldDefArray != null)
            {
                serializer.Serialize(writer, value.OrderFieldDefArray);
                return;
            }
            if (value.OrderFieldDefClass != null)
            {
                serializer.Serialize(writer, value.OrderFieldDefClass);
                return;
            }
            throw new Exception("Cannot marshal type Order");
        }

        public static readonly OrderConverter Singleton = new OrderConverter();
    }
}