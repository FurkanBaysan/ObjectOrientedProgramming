using System;
using System.Collections.Generic;
using System.Net;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Furkan";
            Console.WriteLine(cookie["name"]);
        }
    }
}
