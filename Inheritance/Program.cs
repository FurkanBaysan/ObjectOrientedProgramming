using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Engineer engineer = new Engineer();
            engineer.Weight = 80;
            Console.WriteLine("Engineer Weight: " + engineer.Weight);
            engineer.Eating(10);
            Console.WriteLine("Engineer Current Weight: " + engineer.Weight);

            engineer.Salary = 15000;
            engineer.Raise(20);
            Console.WriteLine("Engineer Salary: " + engineer.Salary);

            Text text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
