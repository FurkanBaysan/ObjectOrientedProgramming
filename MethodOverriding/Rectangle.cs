using System;

namespace MethodOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Algorithm for Drawing a Rectangle
            Console.WriteLine("Draw a Rectangle");
        }
    }
}