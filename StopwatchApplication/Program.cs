using System;
using System.Threading;

namespace StopwatchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            for (int i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.GetInterval());

                Console.WriteLine("Please Press Enter to Run the Stopwatch one again.");
                Console.ReadLine();
            }
        }
    }
}
