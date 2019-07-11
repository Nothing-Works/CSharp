using System;

namespace Challenges.CSharpIND3.CSharp3.Lambda
{
    public class Example
    {
        public void Test()
        {
            Func<string, int> returnLength;

            returnLength = delegate(string s) { return s.Length; };

            Console.WriteLine(returnLength("Andy"));


            Func<string, int> returnLengthL;

            returnLengthL = (string s) => { return s.Length; };

            Console.WriteLine(returnLengthL("Andy"));


            Func<string, int> returnLengthL1;

            returnLengthL1 = (string s) => s.Length;

            Console.WriteLine(returnLengthL1("Andy"));

            Func<string, int> returnLengthL2;

            returnLengthL2 = (s) => s.Length;

            Console.WriteLine(returnLengthL2("Andy"));

            Func<string, int> returnLengthL3;

            returnLengthL3 = s => s.Length;

            Console.WriteLine(returnLengthL3("Andy"));
        }
    }
}