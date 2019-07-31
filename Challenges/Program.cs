﻿using Challenges.CSharpIND3.CSharp3.ExpressionTree;
using Challenges.CSharpIND3.CSharp3.IEnumerableExample;
using Challenges.CSharpIND3.CSharp4.DynamicTyping;
using Challenges.CSharpIND3.CSharp4.MinorChanges;
using Challenges.CSharpIND4.CSharp2.Iterators;
using Challenges.CSharpIND4.CSharp3.ObjectInitializer;
using Challenges.CSharpIND4.CSharp4;
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
            new ExampleMethods().Test();
            new CSharpIND3.CSharp3.Queries.Example().Continuations();
            new Example1().Go();
            new DT().GO();
            new Dynamic4().CallDynamic();
        }
    }
}