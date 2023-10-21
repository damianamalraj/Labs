using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grunderna_OOP.Classes
{
    public class Circle
    {
        private int _radius;
        public int Radius { get; private set; }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int GetArea()
        {
            return (int)(Radius * Radius * Math.PI);
        }
    }
}