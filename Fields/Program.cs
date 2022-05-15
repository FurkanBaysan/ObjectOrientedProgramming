using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine("Number of orders: " + customer.Orders.Count);
        }
    }
}
