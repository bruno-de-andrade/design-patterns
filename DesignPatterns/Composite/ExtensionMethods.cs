using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    static class ExtensionMethods
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            int sum = 0;

            foreach (var container in containers)
            {
                foreach (var value in container)
                {
                    sum += value;
                }
            }

            return sum;
        }
    }
}
