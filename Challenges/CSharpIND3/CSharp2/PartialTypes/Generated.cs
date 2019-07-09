using System;

namespace Challenges.CSharpIND3.CSharp2.PartialTypes
{
    public partial class PartialMethodDemo
    {
        public PartialMethodDemo()
        {
            BeforeConstructor();
            Console.WriteLine("Generated Constructor");
            AfterConstructor();
        }

        partial void BeforeConstructor();
        partial void AfterConstructor();
    }
}