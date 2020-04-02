using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class OrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Order) || t == typeof(Order?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    OrderFieldDefClass objectValue = serializer.Deserialize<OrderFieldDefClass>(reader);

                    return new Order
                    {
                        OrderFieldDefClass = objectValue
                    };
                case JsonToken.StartArray:
                    List<OrderFieldDef> arrayValue = serializer.Deserialize<List<OrderFieldDef>>(reader);

                    return new Order
                    {
                        OrderFieldDefArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type Order");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Order value = (Order)untypedValue;

            if(value.OrderFieldDefArray != null)
            {
                serializer.Serialize(writer,
                                     value.OrderFieldDefArray);

                return;
            }

            if(value.OrderFieldDefClass != null)
            {
                serializer.Serialize(writer,
                                     value.OrderFieldDefClass);

                return;
            }

            throw new Exception("Cannot marshal type Order");
        }

        public static readonly OrderConverter Singleton = new OrderConverter();
    }
}
