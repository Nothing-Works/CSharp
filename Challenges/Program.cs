using Challenges.CSharpIND3.CSharp1;
using System;
using Challenges.CSharpIND3.CSharp2;

namespace Challenges
{
    public static class Program
    {
        private static void Main()
        {
            var iterable = new IterationC2(new object[] { "a", "b", "c", "d", "e" }, 3);

            foreach (object o in iterable)
            {
                Console.WriteLine(o);
            }
        }
    }
}