using System;

namespace InterfacesAndTestability
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());
            Order order = new Order();
            orderProcessor.Process(order);
        }
    }
}
