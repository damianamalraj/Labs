using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Round(Side * Side, 2);
        }
    }
}