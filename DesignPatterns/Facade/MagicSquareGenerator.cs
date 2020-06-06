using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public static class MagicSquareGenerator
    {
        public static List<List<int>> Generate(int size)
        {
            List<List<int>> matrix;
            List<List<int>> list;
            int tries = 0;

            do
            {
                list = new List<List<int>>();

                for (int index = 0; index < size; index++)
                {
                    list.Add(Generator.Generate(size));
                }

                matrix = Splitter.Split(list);
                tries++;
            }
            while (!Verifier.Verify(matrix));

            return list;
        }
    }
}
