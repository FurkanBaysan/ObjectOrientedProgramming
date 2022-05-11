using System;

namespace IntroductionToClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = Person.Parse("Anil");

            firstPerson.Name = "Furkan";
            firstPerson.Introduce("Velihan");
            secondPerson.Introduce("Furkan");

            firstPerson.Weight = 75;
            Console.WriteLine("Weight: " + firstPerson.Weight);
            firstPerson.Eating(5);
            Console.WriteLine("Current Weight: " + firstPerson.Weight);

            secondPerson.Weight = 85;
            Console.WriteLine("Weight: " + secondPerson.Weight);
            secondPerson.Eating(10);
            Console.WriteLine("Current Weight: " + secondPerson.Weight);
        }
    }
}
