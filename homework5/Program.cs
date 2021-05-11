using System;
using System.Collections.Generic;
using System.Linq;


namespace homework5
{
     public class Order
    {
        public int id { get; set; }
        public int price { get; set; }
        public string name { get; set; }
        public string customer { get; set; }
        public Order(int id,int price,string name,string customer)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.customer = customer;
        }


        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.id == id;
        }
        public override int GetHashCode() { return base.GetHashCode(); }
        public override string ToString()
        {
            return id + "," + price + "," + name + "," + customer;
        }
    }


    public class OrderService
    {

        public List<Order> orderlist = new List<Order>();
       
        public void Create(Order order)
        {
            bool same = false;
            foreach(Order m in this.orderlist) { 
                if (order.Equals(m))
                {
                    same = true;
                }
            }
            if (same)
            {
                Console.WriteLine("订单重复");
            }
            else
            {
                orderlist.Add(order);
            }
            
        }
        public void Search(int a)
        {
            Console.WriteLine(orderlist[a]);
        }
        public void SearchName(string name)
        {
            var targetname = from n in orderlist
                             where n.name == name
                             select n;
            foreach(var n in targetname)
            {
                string s = n.ToString();
                Console.WriteLine(n);
            }
        }
        public void SearchId(int id)
        {
            var targetid = from n in orderlist
                          where n.id == id
                          select n; 
            foreach(var n in targetid)
            {
                string s = n.ToString();
                Console.WriteLine(n);
            }
        }
        public void Delete(int a)
        {
            orderlist.RemoveAt(a);
        }
 
    }
     
    
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(2019, 32, "apple", "peter");
            Order order2 = new Order(2020, 21, "orange", "Tom");
            Order order3 = new Order(2021, 25, "banana", "Kitty");
            OrderService orderservice = new OrderService();
            orderservice.Create(order1);
            orderservice.Create(order2);
            orderservice.Create(order3);
            orderservice.Search(1);
        }
    }
}

