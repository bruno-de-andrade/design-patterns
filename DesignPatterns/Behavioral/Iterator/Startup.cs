using System;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var left = new Node<int>(20);
            var right = new Node<int>(30);
            var root = new Node<int>(10, left, right);

            foreach (var nodeValue in root.PreOrder)
            {
                Console.WriteLine(nodeValue);
            }
        }
    }
}
