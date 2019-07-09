using System;

namespace Challenges.CSharpIND3.CSharp2.StaticClasses
{
    public sealed class NonStaticStringHelper
    {
        private NonStaticStringHelper()
        {
        }

        public static string Reverse(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}