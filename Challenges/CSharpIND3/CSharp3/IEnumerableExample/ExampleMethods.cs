using System;
using System.Linq;

namespace Challenges.CSharpIND3.CSharp3.IEnumerableExample
{
    public class ExampleMethods
    {
        public void Test()
        {
            var collection = Enumerable.Range(0, 10);

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }


            var collection1 = Enumerable.Range(0, 10).Reverse();

            foreach (var i in collection1)
            {
                Console.WriteLine(i);
            }


            var collection2 = Enumerable.Range(0, 10).Where(c => c % 2 != 0).Reverse();

            foreach (var i in collection2)
            {
                Console.WriteLine(i);
            }


            var collection3 = Enumerable
                .Range(0, 10)
                .Where(c => c % 2 != 0)
                .Reverse()
                .Select(c => new
                {
                    c,
                    root = Math.Sqrt(c)
                });


            foreach (var i in collection3)
            {
                Console.WriteLine("sqrt({0})={1}",
                    i.c,
                    i.root);
            }


            var collection4 = Enumerable
                .Range(-5, 11)
                .Select(c => new
                {
                    Original = c,
                    Square = c * c
                })
                .OrderBy(c => c.Square)
                .ThenBy(c => c.Original);


            foreach (var i in collection4)
            {
                Console.WriteLine(i);
            }
        }
    }
}