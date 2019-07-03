using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.CSharp2.Anonymous
{
    public class AnonymousExample
    {
        Action<string> printReverse = delegate(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
        };

        Action<int> printRoot = delegate(int i) { Console.WriteLine(Math.Sqrt(i)); };

        Action<IList<double>> printMean = delegate(IList<double> numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }

            Console.WriteLine(total / numbers.Count);
        };

        public void Example()
        {
            List<int> x = new List<int>();
            x.Add(1);
            x.Add(2);
            x.Add(3);
            x.Add(4);
            x.Add(5);
            x.Add(6);
            x.Add(7);

            x.ForEach(delegate(int i) { Console.WriteLine(Math.Sqrt(i)); });
        }


        public void CallAll()
        {
            printReverse("Andy");
            printRoot(2);
            printMean(new double[] { 1.2, 2.4, 4, 42.2 });
        }
    }
}