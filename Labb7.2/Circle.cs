using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7._2
{
    public class Circle : IGeometri
    {
        public Circle()
        {
            Radius = 5.0;
        }
        public double Radius { get; set; }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2));
        }
    }
}
