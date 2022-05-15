using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "Method Overloading");
            UsePoints();
            Console.WriteLine("\t" + "params Modifier");
            UseParamsModifier();
            Console.WriteLine("\t" + "out Modifier");
            UseOutModifier();
        }

        static void UsePoints()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point Moved." + " " + "Point is at ({0},{1})", point.X, point.Y);
                point.Move(100, 200);//Our point is moved twice.
                Console.WriteLine("Point Moved." + " " + "Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception exception)
            {
                Console.WriteLine("An Unexpected error Occurred.");
            }
        }

        static void UseParamsModifier()
        {
            Calculator calculator = new Calculator();
            //int result = calculator.Add(new int[] { 10, 20, 30, 40, 50 });
            int result = calculator.Add(1, 2);
            Console.WriteLine("Result: " + result);
            int currentResult = calculator.Add(1, 2, 3);
            Console.WriteLine("Result: " + currentResult);
            int newResult = calculator.Add(1, 2, 3, 4);
            Console.WriteLine("Result: " + newResult);
        }

        static void UseOutModifier()
        {
            string text = "Hello";

            try
            {
                int num = Int32.Parse(text);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Can not Convert to an Integer Type." + " " + "Conversion Failed");
            }
            //Alternative Way Above Code
            int number;
            bool result = Int32.TryParse(text, out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }
        }
    }
}
