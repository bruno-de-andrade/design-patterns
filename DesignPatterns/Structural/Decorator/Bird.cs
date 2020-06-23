using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Bird : IBird
    {
        public int Age { get; set; }

        public void Fly()
        {
            if (Age >= 5)
            {
                Console.WriteLine("I'm flying");
            }
        }
    }
}
