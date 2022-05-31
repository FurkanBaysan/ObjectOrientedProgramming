using System;
using System.Reflection.Metadata;

namespace AbstractClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            BaseGameCalculator calculator = new MenGameCalculator();
            Console.WriteLine("Men Player Score: " + calculator.CalculateScore(15));
            BaseGameCalculator baseGameCalculator = new WomanGameCalculator();
            Console.WriteLine("Woman Player Score: " + baseGameCalculator.CalculateScore(5));
        }
    }
}
