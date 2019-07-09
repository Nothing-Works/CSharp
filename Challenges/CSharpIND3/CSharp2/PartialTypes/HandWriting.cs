using System;

namespace Challenges.CSharpIND3.CSharp2.PartialTypes
{
    public partial class PartialMethodDemo
    {
        partial void BeforeConstructor()
        {
            Console.WriteLine("before");
        }
    }
}