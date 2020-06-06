﻿using System;

namespace DesignPatterns.Facade
{
    class Startup
    {
        static void Main(string[] args)
        {
            var magicSquare = MagicSquareGenerator.Generate(3);

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine(string.Join(" ", magicSquare[index].ToArray()));
            }
        }
    }
}
