using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseScoreCalculator baseScoreCalculator = new MenScoreCalculator();
            double menScore = baseScoreCalculator.CalculateScore(10);
            Console.WriteLine("Men Score: " + menScore);
            BaseScoreCalculator scoreCalculator = new WomanScoreCalculator();
            double womanScore = scoreCalculator.CalculateScore(20);
            Console.WriteLine("Woman Score: " + womanScore);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
