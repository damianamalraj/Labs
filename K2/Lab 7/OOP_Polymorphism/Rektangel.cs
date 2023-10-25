using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Rektangel : Geometri
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rektangel(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Math.Round(Length * Width, 2);
        }
    }
}