using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Furkan");
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("Name: " + customer.Name);
            Order order = new Order();
            customer.Orders.Add(order);
        }
    }
}
