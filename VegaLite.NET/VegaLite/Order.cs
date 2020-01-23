using System.Collections.Generic;

namespace VegaLite
{
    public struct Order
    {
        public List<OrderFieldDef> OrderFieldDefArray;
        public OrderFieldDefClass  OrderFieldDefClass;

        public static implicit operator Order(List<OrderFieldDef> OrderFieldDefArray) => new Order { OrderFieldDefArray = OrderFieldDefArray };
        public static implicit operator Order(OrderFieldDefClass  OrderFieldDefClass) => new Order { OrderFieldDefClass = OrderFieldDefClass };
    }
}