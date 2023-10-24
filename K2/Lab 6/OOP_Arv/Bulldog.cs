using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Bulldog : Dog
    {
        public int crazyLevel { get; set; } = 25;

        public void printCrazyLevel()
        {
            Console.WriteLine($"Crazy Level {crazyLevel}%");
        }
    }
}