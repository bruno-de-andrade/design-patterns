using System;

namespace DesignPatterns.Structural.Flyweight
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var sentence = new Sentence("hello world");
            sentence[1].Capitalize = true;

            Console.WriteLine(sentence);
        }
    }
}
