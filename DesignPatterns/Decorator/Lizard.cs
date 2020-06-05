using System;

namespace DesignPatterns.Decorator
{
    class Lizard : ILizard
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
