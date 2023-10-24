using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Animal
    {
        public string Environment { get; set; } = "land";
        public int Legs { get; set; } = 4;
        public int Eyes { get; set; } = 2;
        public int Ears { get; set; } = 2;
        public int Mouth { get; set; } = 1;

        public void whichEnviroment()
        {
            Console.WriteLine($"The Animal is a {Environment} Animal.");
        }
        public void howManyLegs()
        {
            Console.WriteLine($"Animal has {Legs} legs.");
        }
        public void howManyEyes()
        {
            Console.WriteLine($"Animal has {Eyes} ");
        }

    }
}