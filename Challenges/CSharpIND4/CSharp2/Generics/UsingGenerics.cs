using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp2.Generics
{
    public class UsingGenerics
    {
        public static List<string> GenerateNamesGenerics()
        {
            List<string> names = new List<string>();

            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");

            return names;
        }

        public static void PrintNamesGenerics(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        private static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);

            List<T> ret = new List<T>();

            for (int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }

            return ret;
        }

        public static void CopyWithGenerics()
        {
            List<int> nums = new List<int>();

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);

            List<int> copied = CopyAtMost<int>(nums, 2);

            foreach (int i in copied)
            {
                Console.WriteLine(i);
            }
        }
    }
}