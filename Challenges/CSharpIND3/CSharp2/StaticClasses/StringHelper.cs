using System;

namespace Challenges.CSharpIND3.CSharp2.StaticClasses
{
    public static class StringHelper
    {
        public static string Reverse(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}