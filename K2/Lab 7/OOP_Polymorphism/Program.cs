using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Geometri cirkel = new Cirkel(5);
            Geometri fyrkant = new Fyrkant(5);
            Geometri rektangel = new Rektangel(5, 10);
            Geometri ellips = new Ellips(5, 7);
            Geometri parallellogram = new Parallellogram(5, 5);

            Console.WriteLine($"Area Cirkel: {cirkel.Area()}");
            Console.WriteLine($"Area Fyrkant: {fyrkant.Area()}");
            Console.WriteLine($"Area Rektangel: {rektangel.Area()}");
            Console.WriteLine($"Area Ellips: {ellips.Area()}");
            Console.WriteLine($"Area Parallellogram: {parallellogram.Area()}");
        }
    }
}