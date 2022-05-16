using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            DateTime dateTime =
                new DateTime(1997, 7, 23);
            person.SetBirthDate(dateTime);
            Console.WriteLine("My Birth Date: " +
                              person.GetBirthDate());
        }
    }
}
