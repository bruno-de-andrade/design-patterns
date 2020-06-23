using System;

namespace DesignPatterns.Structural.Adapter
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var square = new Square() { Side = 3 };
            var adapter = new SquareToRectangleAdapter(square);

            Console.WriteLine($"Area: {adapter.GetArea()}");
        }
    }
}
