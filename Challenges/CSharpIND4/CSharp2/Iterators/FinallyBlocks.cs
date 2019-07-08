using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp2.Iterators
{
    public class FinallyBlocks
    {
        public IEnumerable<string> Finally()
        {
            try
            {
                Console.WriteLine("before first yield");
                yield return "first";
                Console.WriteLine("between");
                yield return "second";
                Console.WriteLine("after second yield");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }

        public void Print()
        {
            foreach (string s in Finally())
            {
                Console.WriteLine(s);
            }
        }

        public void PrintOne()
        {
            foreach (string s in Finally())
            {
                Console.WriteLine(s);
                if (s != null)
                {
                    break;
                }
            }
        }

        public void PrintTwo()
        {
            IEnumerable<string> iterable = Finally();
            using (IEnumerator<string> iterator = iterable.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                    if (iterator.Current != null)
                    {
                        break;
                    }
                }
            }
        }
    }
}