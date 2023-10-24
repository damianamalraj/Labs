using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Chihuahua : Dog
    {
        public int CrazyLevel { get; set; }
        public Chihuahua(int crazyLevel = 90)
        {
            CrazyLevel = crazyLevel;
        }

        public void printCrazyLevel()
        {
            Console.WriteLine($"Crazy Level {CrazyLevel}%");
        }
    }
}