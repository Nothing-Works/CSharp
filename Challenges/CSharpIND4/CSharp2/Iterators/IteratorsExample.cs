using System;
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

        public static void Print()
        {
            foreach (int i in SampleOne())
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintTwo()
        {
            IEnumerable<int> iterable = SampleOne();

            using (IEnumerator<int> iterator = iterable.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
            }
        }

        public static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;

            while (true)
            {
                yield return current;

                int oldCurrent = current;

                current = next;

                next = next + oldCurrent;
            }
        }

        public static void PrintFibonacci()
        {
            foreach (int i in Fibonacci())
            {
                Console.WriteLine(i);
                if (i > 1000)
                {
                    break;
                }
            }
        }
    }
}