using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public static class MagicSquareGenerator
    {
        public static List<List<int>> Generate(int size)
        {
            List<List<int>> list;

            do
            {
                list = new List<List<int>>();

                for (int index = 0; index < size; index++)
                {
                    list.Add(Generator.Generate(size));
                }
            }
            while (!Verifier.Verify(Splitter.Split(list)));

            return list;
        }
    }
}
