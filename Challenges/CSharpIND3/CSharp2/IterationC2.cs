using System.Collections;

namespace Challenges.CSharpIND3.CSharp2
{
    public class IterationC2 : IEnumerable
    {
        object[] values;
        int startPoint;

        public IterationC2(object[] values, int startPoint)
        {
            this.values = values;
            this.startPoint = startPoint;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < values.Length; i++)
            {
                yield return values[(i + startPoint) % values.Length];
            }
        }
    }
}