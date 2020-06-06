using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Facade
{
    public static class Verifier
    {
        /// <summary>
        /// Ensures that, given a list of lists, every single list adds up to the same value.
        /// </summary>
        public static bool Verify(List<List<int>> array)
        {
            if (!array.Any()) 
                return false;

            var expected = array.First().Sum();

            return array.All(t => t.Sum() == expected);
        }
    }
}
