using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7._2
{
    public class Square : IGeometri
    {
        public Square()
        {
            Side = 8.0;
        }
        public double Side { get; set; }
        public double Area()
        {
            return Side * Side;
        }
    }
}
