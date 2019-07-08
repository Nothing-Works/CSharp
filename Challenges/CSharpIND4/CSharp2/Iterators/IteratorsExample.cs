using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp2.Iterators
{
    public class IteratorsExample
    {
        public static IEnumerable<int> SampleOne()
        {
            yield return 10;
            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }

            yield return 20;
        }
    }
}