using System;

namespace ConstructorsInInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being instantiated " +
                              "and initialized. {0}", registrationNumber);
        }
    }
}