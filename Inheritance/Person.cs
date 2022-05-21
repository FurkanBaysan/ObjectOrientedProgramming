using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public double Eating(int increment)
        {
            this.Weight = this.Weight + increment;
            return this.Weight;
        }

    }
}
