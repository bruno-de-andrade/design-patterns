using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    class Startup
    {
        static void Main(string[] args)
        {
            var singleValue = new SingleValue { Value = 11 };
            var otherValues = new ManyValues { 22, 33 };
            var sum = new List<IValueContainer> { singleValue, otherValues }.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
