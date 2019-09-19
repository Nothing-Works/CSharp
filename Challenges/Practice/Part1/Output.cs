using System;
using System.Linq;

namespace Challenges.Practice.Part1
{
    public class Output
    {
        public void Example()
        {
            int[] ds = { 1, 2, 3, 4 };
            var result = ds.Aggregate(10, (acc, val) =>
            {
                Console.WriteLine(acc);
                Console.WriteLine(val);
                return acc + val;
            }, c =>
            {
                Console.WriteLine(c);
                return c * 2;
            });
            Console.WriteLine(result);
        }

        public void Example1()
        {
            var a = DataSource.Orders;
            var b = new OverAll();
            var re = a.Aggregate(b, (cur, next) =>
            {
                b.TotalOrders++;
                b.TotalAmount += next.Total;
                return b;
            });

            Console.WriteLine(a.Sum(c => c.Total));
            Console.WriteLine($"{re.TotalOrders} {re.TotalAmount}");
        }
    }
}