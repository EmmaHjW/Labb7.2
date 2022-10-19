using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7._2
{
    public class Rectangle : IGeometri
    {
        public Rectangle()
        {
            Width = 12.0;
            Height = 6.0;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }

}
