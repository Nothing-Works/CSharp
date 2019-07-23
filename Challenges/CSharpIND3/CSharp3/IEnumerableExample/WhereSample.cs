using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.CSharp3.IEnumerableExample
{
    public static class WhereSample
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null || predicate == null)
            {
                throw new ArgumentException();
            }

            return WhereIpl(source, predicate);
        }


        private static IEnumerable<T> WhereIpl<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T t in source)
            {
                if (predicate(t))
                {
                    yield return t;
                }
            }
        }
    }
}