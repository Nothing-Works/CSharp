using Challenges.CSharpIND3.CSharp1;
using System;

namespace Challenges
{
    public static class Program
    {
        private static void Main()
        {
            var iterable = new IterationSample(3, new object[] { "a", "b", "c", "d", "e" });

            foreach (object o in iterable)
            {
                Console.WriteLine(o);
            }
        }
    }
}