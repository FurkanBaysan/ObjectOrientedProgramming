using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClassesAndObjects
{
    public class Person
    {
        public string Name;
        public double Weight;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public double Eating(double increment)
        {
            this.Weight = this.Weight + increment; 
            return this.Weight;
        }
        //Factory Method
        public static Person Parse(string newString)
        {
            Person person = new Person();
            person.Name = newString;
            return person;
        }
    }
}
