using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Dog : Animal
    {
        public string Sound { get; set; }
        public Dog(string sound = "Wuffff")
        {
            Sound = sound;
        }

        public void makeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}