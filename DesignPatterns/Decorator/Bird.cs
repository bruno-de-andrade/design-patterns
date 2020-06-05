using System;

namespace DesignPatterns.Decorator
{
    class Bird : IBird
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
