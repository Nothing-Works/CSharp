using System;
using System.Collections;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.CSharp3.Model
{
    public class DateTimeRange : IEnumerable<DateTime>
    {
        private readonly DateTime start;
        private readonly DateTime end;

        public DateTimeRange(DateTime start, DateTime end)
        {
            this.end = end;
            this.start = start;
        }

        public IEnumerator<DateTime> GetEnumerator()
        {
            for (DateTime current = start; current <= end; current = current.AddDays(1))
            {
                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}