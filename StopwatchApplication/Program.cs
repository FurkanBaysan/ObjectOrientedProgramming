using System;

namespace StopwatchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            string input;
            Console.WriteLine("Enter S to Start the Stopwatch" +
                              " and Q to Stop");
            input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                if (input.ToLower().Equals("S"))
                {
                    stopwatch.Start();
                    Console.WriteLine("Enter Q the Stop the StopWatch");
                }
                else if (input.ToLower().Equals("Q"))
                {
                    Console.WriteLine(stopwatch.Stop());
                    Console.WriteLine("Enter S to Start the StopWatch");
                }
                input = Console.ReadLine();
            }
        }
    }
}
