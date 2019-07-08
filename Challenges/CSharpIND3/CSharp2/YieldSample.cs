using System;
using System.Collections.Generic;
using System.Threading;

namespace Challenges.CSharpIND3.CSharp2
{
    public class YieldSample
    {
        readonly string padding = new string(' ', 30);

        public IEnumerable<int> CreateEnumerable()
        {
            Console.WriteLine("{0} start of createEnumerable", padding);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} about to yield {1}", padding, i);
                yield return i;
                Console.WriteLine("{0} After yield", padding);
            }

            Console.WriteLine("{0} Yielding final value", padding);

            yield return -1;
            Console.WriteLine("{0} End of createEnumerable", padding);
        }
    }

    public class YieldExample
    {
        public void Example()
        {
            var en = new YieldSample();
            IEnumerable<int> iterable = en.CreateEnumerable();
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("starting to iterate");
            while (true)
            {
                Console.WriteLine("calling MoveNext()....");
                bool result = iterator.MoveNext();
                Console.WriteLine("... MoveNext result = {0}", result);
                if (!result)
                {
                    break;
                }

                Console.WriteLine("Fetching Current....");
                Console.WriteLine("... Current result = {0}", iterator.Current);
            }
        }
    }

    public class YieldDate
    {
        public IEnumerable<int> CountWithTimeLimit(DateTime limit)
        {
            for (int i = 0; i < 100; i++)
            {
                if (DateTime.Now >= limit)
                {
                    yield break;
                }

                yield return i;
            }
        }

        public void Example()
        {
            DateTime stop = DateTime.Now.AddSeconds(2);
            foreach (int i in CountWithTimeLimit(stop))
            {
                Console.WriteLine("Received {0}", i);
                Thread.Sleep(300);
            }
        }
    }
}