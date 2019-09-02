using System;

namespace Challenges.CSharpIND4.CSharp7
{
    public static class DeconstructionNontuple
    {
        public static void Go()
        {
            var point = new DePoint(1, 2);
            var (x, y) = point;
            Console.WriteLine(x);
            Console.WriteLine(y);

            DateTime dd = DateTime.UtcNow;
            var (y1, m1, d1) = dd;
        }

        public static void Deconstruct(this DateTime date, out int year, out int month, out int day)
            => (year, month, day) = (date.Year, date.Month, date.Day);
    }
}