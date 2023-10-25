using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Ellips : Geometri
    {
        public double AAxis { get; set; }
        public double BAxis { get; set; }

        public Ellips(double aaxis, double baxis)
        {
            AAxis = aaxis;
            BAxis = baxis;
        }

        public override double Area()
        {
            return Math.Round(AAxis * BAxis * Math.PI, 2);
        }
    }
}