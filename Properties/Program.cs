using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new DateTime(1997, 7, 23, 10, 30, 0));
            person.Name = "Furkan";
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
        }
    }
}
