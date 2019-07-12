using Challenges.CSharpIND3.CSharp3.ExpressionTree;
using Challenges.CSharpIND4.CSharp2.Iterators;
using Challenges.CSharpIND4.CSharp3.ObjectInitializer;
using System;

namespace Challenges
{
    public static class Program
    {
        private static void Main()
        {
            new FinallyBlocks().PrintTwo();
            var a = new ProcessOrder().Process();
            Console.WriteLine(a.Customer.Name);
            new Example().Test();
        }
    }
}