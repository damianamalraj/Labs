using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Chihuahua : Dog
    {
        public int crazyLevel { get; set; } = 90;

        public void printCrazyLevel()
        {
            Console.WriteLine($"Crazy Level {crazyLevel}%");
        }
    }
}