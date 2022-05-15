using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
}
