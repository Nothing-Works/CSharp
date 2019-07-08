using Challenges.CSharpIND4.CSharp2.Iterators;
using System;

namespace Challenges
{
    public static class Program
    {
        private static void Main()
        {
            foreach (int i in IteratorsExample.SampleOne())
            {
                Console.WriteLine(i);
            }
        }
    }
}