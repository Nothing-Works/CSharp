using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp7
{
    public class TuplesExample
    {
        public IEnumerable<TResult> GenerateSequence<TState, TResult>(TState seed, Func<TState, TState> generator,
            Func<TState, TResult> resultSelector)

        {
            var state = seed;

            while (true)
            {
                yield return resultSelector(state);
                state = generator(state);
            }
        }

        public void Go1()
        {
            var result = GenerateSequence((current: 0, next: 1), pair => (pair.next, pair.current + pair.next),
                pair => pair.current);
        }

        public IEnumerable<int> Fib6()
        {
            int current = 0;
            int next = 1;

            while (true)
            {
                yield return current;
                int nextNext = current + next;
                current = next;
                next = nextNext;
            }
        }

        public IEnumerable<int> Fib7()
        {
            var pair = (current: 0, next: 1);
            while (true)
            {
                yield return pair.current;
                pair = (pair.next, pair.current + pair.current);
            }
        }

        public void Go()
        {
            int[] array = new int[] { 2, 7, 3, -5, 1, 0, 10 };

            var result = MinMax(array);

            Console.WriteLine($"{result.min}, {result.max}");
        }

        private (int min, int max) MinMax(IEnumerable<int> source)
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Cannot find min/max of an empty sequence");
                }

                var result = (min: iterator.Current, max: iterator.Current);

                while (iterator.MoveNext())
                {
                    result = (Math.Min(result.min, iterator.Current),
                        Math.Max(result.max, iterator.Current));
                }

                return result;
            }
        }
    }
}