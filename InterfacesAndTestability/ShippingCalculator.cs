using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndTestability
{
    public class ShippingCalculator : IShippingCalculator
    {
        public double CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30)
            {
                return order.TotalPrice * 0.1;
            }

            return 0;
        }
    }
}
