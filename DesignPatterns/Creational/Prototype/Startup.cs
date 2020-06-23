using System;

namespace DesignPatterns.Creational.Prototype
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var line1 = new Line();
            line1.Start.X = 10;
            line1.Start.Y = 20;
            line1.End.X = 100;
            line1.End.Y = 200;

            var line2 = line1.DeepCopy();
            line2.Start.Y = 15;
            line2.End.X = 300;

            Console.WriteLine($"Line 1 Start X: {line1.Start.X}, Y: {line1.Start.Y}; End X: {line1.End.X}, Y: {line1.End.Y}");
            Console.WriteLine($"Line 2 Start X: {line2.Start.X}, Y: {line2.Start.Y}; End X: {line2.End.X}, Y: {line2.End.Y}");
        }
    }
}
