using System;

namespace Labb7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeometri circle = new Circle();
            IGeometri square = new Square();
            IGeometri rectangle = new Rectangle();
            Console.WriteLine($"Area Circle: {circle.Area():F2}");
            Console.WriteLine($"Area Square: {square.Area():F2}");
            Console.WriteLine($"Area Rectangle: {rectangle.Area():F2}");
        }
    }
}
