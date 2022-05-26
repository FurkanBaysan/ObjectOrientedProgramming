using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingAndDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "Upcasting");

            Text text = new Text();
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine("Text Width: " + text.Width);

            StreamReader reader = new StreamReader(new MemoryStream());
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Furkan");
            list.Add(new Text());
            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("\t" + "Downcasting");

            Shape newShape = new Text();
            Text newText = (Text)newShape;
        }
    }
}
