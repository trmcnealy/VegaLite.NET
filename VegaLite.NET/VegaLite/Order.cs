using System.Collections.Generic;

namespace VegaLite
{
    public struct Order
    {
        public List<OrderFieldDef> OrderFieldDefArray;
        public OrderFieldDefClass  OrderFieldDefClass;

        public static implicit operator Order(List<OrderFieldDef> orderFieldDefArray) => new Order { OrderFieldDefArray = orderFieldDefArray };
        public static implicit operator Order(OrderFieldDefClass  orderFieldDefClass) => new Order { OrderFieldDefClass = orderFieldDefClass };
    }
}