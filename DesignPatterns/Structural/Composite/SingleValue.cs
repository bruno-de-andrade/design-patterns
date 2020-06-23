using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class SingleValue : IValueContainer
    {
        public int Value { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
