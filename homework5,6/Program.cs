using System;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(2020, "apple", 2, 23);
            Order order2 = new Order(2021, "orange", 5, 20);
            Order order3 = new Order(2022, "banana", 2, 6);
            OrderService odserve = new OrderService();
            odserve.AddOrder(order1);
            odserve.AddOrder(order2);
            odserve.AddOrder(order3);
            odserve.DeleteOrder(2021);
            odserve.OrderSort();
            odserve.search(2022);
            odserve.searchcount(5);
        }
    }
}
