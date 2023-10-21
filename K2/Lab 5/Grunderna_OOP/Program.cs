using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grunderna_OOP.Classes;

namespace Grunderna_OOP
{
    class Program
    {
        internal static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Cirkeln med {circle1.Radius} som radie har en area av: {circle1.GetArea()}");
            Console.WriteLine($"Cirkeln med {circle2.Radius} som radie har en area av: {circle2.GetArea()}");
        }
    }
}

