using System;

namespace DesignPatterns.Bridge
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(new VectorRenderer()).ToString());
            Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
            Console.WriteLine(new Square(new VectorRenderer()).ToString());
            Console.WriteLine(new Square(new RasterRenderer()).ToString());
        }
    }
}
