using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Radius * Radius * Math.PI, 2);
        }
    }
}