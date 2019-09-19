using System;
using System.Linq;

namespace Challenges.Practice.Part1
{
    public class Output
    {
        public void Example()
        {
            int[] ds = { 1, 2, 3, 4 };
            var result = ds.Aggregate((acc, val) =>
            {
                Console.WriteLine(acc);
                Console.WriteLine(val);
                return acc + val;
            });
            Console.WriteLine(result);
        }
    }
}