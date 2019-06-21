using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.CSharp2.Generics
{
    public class GenericsConvert
    {
        private static double TakeRootSquare(int i)
        {
            return Math.Sqrt(i);
        }


        public static void PrintConverted()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);

            Converter<int, double> converter = TakeRootSquare;

            List<double> converted = new List<double>();
            converted = nums.ConvertAll<double>(converter);

            foreach (double d in converted)
            {
                Console.WriteLine(d);
            }
        }
    }
}