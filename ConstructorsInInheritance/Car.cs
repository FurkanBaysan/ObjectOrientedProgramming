using System;

namespace ConstructorsInInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being instantiated " +
                              "and initialized. {0}", registrationNumber);
        }
    }
}