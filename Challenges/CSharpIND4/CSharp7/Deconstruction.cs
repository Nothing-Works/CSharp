using System;

namespace Challenges.CSharpIND4.CSharp7
{
    public class Deconstruction
    {
        public int X { get; }
        public int Y { get; }

        public Deconstruction(int x, int y) => (X, Y) = (x, y);

        public void Test()
        {
            //example of discards
            var tupleDiscards = (1, 2, 3, 4, 5, 6);

            var (a1, b1, _, _, _, _) = tupleDiscards;

            var tuple = (10, "text");


            //1
            var (a, b) = tuple;
            //1
            (int c, string d) = tuple;
            //3
            int e;
            string f;
            (e, f) = tuple;

            Console.WriteLine($"a: {a}; b: {b}");
            Console.WriteLine($"c: {c}; d: {d}");
            Console.WriteLine($"e: {e}; f: {f}");
        }
    }
}