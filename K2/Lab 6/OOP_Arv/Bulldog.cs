using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Bulldog : Dog
    {
        public int CrazyLevel { get; set; }
        public Bulldog(int crazyLevel = 25)
        {
            CrazyLevel = crazyLevel;
        }

        public void printCrazyLevel()
        {
            Console.WriteLine($"Crazy Level {CrazyLevel}%");
        }
    }
}