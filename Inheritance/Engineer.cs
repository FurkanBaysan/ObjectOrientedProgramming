using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Engineer : Person
    {
        public double Salary { get; set; }

        public double Raise(int ratio)
        {
            this.Salary = this.Salary + (this.Salary * ratio / 100);
            return this.Salary;
        }

    }
}
