using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Cat : Animal
    {
        public string Sound { get; set; }
        public Cat(string sound = "Meowwww")
        {
            Sound = sound;
        }

        public void makeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}