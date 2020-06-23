using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Facade
{
    public static class Generator
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Makes an array of random digits (suitable constrained) of a particular length.
        /// </summary>
        public static List<int> Generate(int count)
        {
            return Enumerable.Range(0, count)
              .Select(_ => random.Next(1, 6))
              .ToList();
        }
    }
}
