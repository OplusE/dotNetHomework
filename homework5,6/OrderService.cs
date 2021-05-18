using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homework5
{
    class OrderService
    {
        List<Order> orderlist = new List<Order>();

        public void AddOrder(Order order)
        {
            bool canAdd = true;
            foreach(Order element in orderlist)
            {
                if(order.Equals(element))
                {
                    canAdd = false;
                }
            }
            if(canAdd==true)
            {
                orderlist.Add(order);
            }
        }

        public void DeleteOrder(int number)
        {
            var order = from w in orderlist where w.ordernum == number select w;
            for(int i=0;i<order.Count();i++)
            {
                orderlist.Remove(order.ElementAt(i));
            }
        }

        public void Modify(int num,Order order)
        {
            DeleteOrder(num);
            AddOrder(order);
        }

        public void OrderSort()
        {
            var odlist = from w in orderlist orderby w.ordernum select w;
            Console.WriteLine("已排序");
            foreach(Order od in odlist)
            {
                string s = od.ToString();
                Console.WriteLine(s);
            }
        }

        public void search(int num)
        {
            var order = from w in orderlist where w.ordernum == num select w;
            foreach(Order od in order)
            {
                string s = od.ToString();
                Console.WriteLine(s);
            }
        }

        public void searchcount(int count)
        {
            Console.WriteLine("已排序");
            var order = from w in orderlist where w.count == count orderby w.price select w;
            foreach (Order od in order)
            {
                string s = od.ToString();
                Console.WriteLine(s);
            }
        }
    }
}
