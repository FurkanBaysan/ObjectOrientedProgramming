using System;

namespace StackDesignApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            int initial = 1;
            int maximum = 5;

            for (int i = initial; i <= maximum; i++)
            {
                stack.Push(i);
            }

            for (int i = initial; i <= maximum; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            //stack.Clear();
            //stack.Print();

            //Product firstProduct = new Product("Huawei", "Matebook X Pro", 20000);
            //Product secondProduct = new Product("Apple", "Macbook Pro", 30000);
            //stack.Push(firstProduct);
            //stack.Push(secondProduct);
        }
    }
}
