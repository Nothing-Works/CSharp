using System;

namespace Challenges.CSharpIND4.CSharp3.Lambda
{
    public class Example
    {
        Action<string> action = delegate(string s) { Console.WriteLine(s); };

        Action<string> action1 = s => Console.WriteLine(s);

        Func<int, int, int> multiply = (a, b) => a * b;

        Func<string, int> squareLength = s => s.Length * s.Length;

        public void Test()
        {
            action("Hahahah");
        }
    }
}