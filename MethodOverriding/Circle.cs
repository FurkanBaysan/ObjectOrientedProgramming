using System;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //Algorithm for Drawing a Circle.
            Console.WriteLine("Draw a Circle");
        }
    }
}