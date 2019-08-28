using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace Challenges.CSharpIND4.CSharp6
{
    public class UsingStaticDirective : IEnumerable<int>
    {
        private readonly List<int> list = new List<int>();

        public int this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public void Test()
        {
            var a = PI;
            Console.WriteLine("worked");
            var b = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 1 }
            };

            var c = new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 2
            };

            var d = new List<int>
            {
                Capacity = 1,
                [1] = 1
            };
        }

        List<string> strings = new List<string>
        {
            10,
            "hello",
            { 20, 3 }
        };

        public IEnumerator<int> GetEnumerator() => list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static class StringListExtensions
    {
        public static void Add(
            this List<string> list, int value, int count = 1)
        {
            list.AddRange(Enumerable.Repeat(value.ToString(), count));
        }
    }
}