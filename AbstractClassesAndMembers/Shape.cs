using System;

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        //This implementation would be common across all subclasses.
        public void Copy()
        {
            Console.WriteLine("Copy shape into Clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }

    }
}