using System;
using System.Collections;

namespace Challenges.CSharpIND3.CSharp1
{
    public class IterationSample : IEnumerable
    {
        object[] values;
        int startPoint;

        public IterationSample(int startPoint, object[] values)
        {
            this.startPoint = startPoint;
            this.values = values;
        }

        public IEnumerator GetEnumerator()
        {
            return new IterationSampleIterator(this);
        }

        class IterationSampleIterator : IEnumerator
        {
            IterationSample parent;
            int position;

            internal IterationSampleIterator(IterationSample parent)
            {
                this.parent = parent;
                position = -1;
            }

            public bool MoveNext()
            {
                if (position != parent.values.Length)
                {
                    position++;
                }

                return position < parent.values.Length;
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current
            {
                get
                {
                    if (position == -1 || position > parent.values.Length)
                    {
                        throw new InvalidOperationException();
                    }

                    int index = position + parent.startPoint;
                    index = index % parent.values.Length;
                    return parent.values[index];
                }
            }
        }
    }
}