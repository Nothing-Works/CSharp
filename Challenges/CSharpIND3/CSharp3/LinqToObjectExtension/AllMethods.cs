using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.CSharpIND3.CSharp3.LinqToObjectExtension
{
    public static class AllMethods
    {
        public static T RandomElement<T>(this IEnumerable<T> source, Random random)
        {
            if (source == null)
            {
                throw new ArgumentException("source");
            }

            if (random == null)
            {
                throw new ArgumentException("random");
            }

            ICollection collection = source as ICollection;

            if (collection != null)
            {
                int count = collection.Count;

                if (count == 0)
                {
                    throw new InvalidOperationException("Sequence was empty");
                }

                int index = random.Next(count);
                return source.ElementAt(index);
            }

            using (IEnumerator<T> iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Sequence was empty");
                }

                int countSoFar = 1;
                T current = iterator.Current;

                while (iterator.MoveNext())
                {
                    countSoFar++;

                    if (random.Next(countSoFar) == 0)
                    {
                        current = iterator.Current;
                    }
                }

                return current;
            }
        }
    }
}