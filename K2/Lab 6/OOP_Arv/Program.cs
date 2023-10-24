using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Chihuahua houseChihuahua = new Chihuahua();
            houseChihuahua.makeSound();

            Cat officeCat = new Cat();
            officeCat.makeSound();

            Bulldog wildBulldog = new Bulldog();
            wildBulldog.makeSound();

            Otter lakeOtter = new Otter();
            lakeOtter.makeSound();
        }
    }
}