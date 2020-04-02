using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct Order
    {
        public List<OrderFieldDef> OrderFieldDefArray;
        public OrderFieldDefClass  OrderFieldDefClass;

        public static implicit operator Order(List<OrderFieldDef> orderFieldDefArray)
        {
            return new Order
            {
                OrderFieldDefArray = orderFieldDefArray
            };
        }

        public static implicit operator Order(OrderFieldDefClass orderFieldDefClass)
        {
            return new Order
            {
                OrderFieldDefClass = orderFieldDefClass
            };
        }
    }
}
