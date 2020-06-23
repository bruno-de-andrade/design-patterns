using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Lizard : ILizard
    {
        public int Age { get; set; }

        public void Crawl()
        {
            if (Age >= 1)
            {
                Console.WriteLine("I'm crawling");
            }
        }
    }
}
