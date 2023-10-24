using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Otter : Animal
    {
        public string Sound { get; set; }
        public Otter(string sound = "Ehehehehehe")
        {
            Sound = sound;
        }

        public void makeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}