using Challenges.CSharpIND3.CSharp3.Model;
using System;
using System.Linq;

namespace Challenges.CSharpIND3.CSharp3.Queries
{
    public class Example
    {
        public void InnerJoin()
        {
            var query = from defect in SampleData.AllDefects
                join subscription in SampleData.AllSubscriptions
                    on defect.Project equals subscription.Project
                select new { defect.Summary, subscription.EmailAddress };

            foreach (var entry in query)
            {
                Console.WriteLine("{0} : {1}", entry.Summary, entry.EmailAddress);
            }

            var query1 = SampleData.AllDefects.Join(SampleData.AllSubscriptions,
                c => c.Project,
                c => c.Project,
                (a, b) => new { a.Summary, b.EmailAddress });

            foreach (var entry in query1)
            {
                Console.WriteLine("{0} : {1}", entry.Summary, entry.EmailAddress);
            }
        }

        public void GroupJoin()
        {
            var query = from defect in SampleData.AllDefects
                join subscription in SampleData.AllSubscriptions
                    on defect.Project equals subscription.Project
                    into groupedSubscriptions
                select new { Defect = defect, Subscriptions = groupedSubscriptions };
            foreach (var entry in query)
            {
                Console.WriteLine(entry.Defect.Summary);
                foreach (var subscription in entry.Subscriptions)
                {
                    Console.WriteLine(" {0}", subscription.EmailAddress);
                }
            }

            var dates = new DateTimeRange(SampleData.Start, SampleData.End);

            var query1 = from date in dates
                join defect in SampleData.AllDefects
                    on date equals defect.Created.Date
                    into joined
                select new { Date = date, Count = joined.Count() };

            foreach (var grouped in query1)
            {
                Console.WriteLine("{0:d}: {1}", grouped.Date, grouped.Count);
            }


            var query2 = SampleData.AllDefects.GroupJoin(
                SampleData.AllSubscriptions,
                c => c.Project,
                c => c.Project,
                (a, b) => new { Defect = a, Subscriptions = b }
            );

            foreach (var entry in query2)
            {
                Console.WriteLine(entry.Defect.Summary);
                foreach (var subscription in entry.Subscriptions)
                {
                    Console.WriteLine(" {0}", subscription.EmailAddress);
                }
            }

            var query3 = dates.GroupJoin(SampleData.AllDefects, c => c, c => c.Created.Date,
                (a, b) => new { Date = a, Count = b.Count() });

            foreach (var q in query3)
            {
                Console.WriteLine("{0:d}: {1}", q.Date, q.Count);
            }
        }

        public void CrossJoin()
        {
        }
    }
}