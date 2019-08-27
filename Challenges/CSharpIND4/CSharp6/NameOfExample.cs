using System;

namespace Challenges.CSharpIND4.CSharp6
{
    public class NameOfExample
    {
        private string field;

        public void Test()
        {
            Console.WriteLine(nameof(field));
            Console.WriteLine(nameof(Test));
        }
    }
}