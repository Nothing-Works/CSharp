using System;

namespace Challenges.Csharp7
{
    public class CSharp7
    {
        public void OutVar()
        {
            if (int.TryParse("1", out var i))
                Console.WriteLine(i);
            else
                Console.WriteLine("Can not do that");
        }

        public void Tuples()
        {
            var tuple1 = (a: 1, b: 2);

            var (x, y) = tuple1;

            var test1 = 1;
            var test2 = 2;

            var tuple2 = (test1, test2);

            Console.WriteLine(tuple2.test1);
            Console.WriteLine(tuple2.test2);
        }

        public void PatternMatching()
        {
            const int input = 1;

            if (input is int i) Console.WriteLine(i);
        }

        private (int, int) Tuples1((int, int) tuple) => (tuple.Item1 * 2, tuple.Item2 * 2);

        public void PrintTuples()
        {
            var (resultA, resultB) = Tuples1((100, 200));
            Console.WriteLine(resultA);
            Console.WriteLine(resultB);
        }
    }
}