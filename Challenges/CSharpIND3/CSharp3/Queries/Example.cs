﻿using Challenges.CSharpIND3.CSharp3.Model;
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
            var query = from user in SampleData.AllUsers
                from project in SampleData.AllProjects
                select new { User = user, Project = project };
            foreach (var q in query)
            {
                Console.WriteLine("{0}/{1}", q.User.Name, q.Project.Name);
            }


            var query3 = SampleData.AllUsers.SelectMany(c => SampleData.AllProjects,
                (user, project) => new { User = user, Project = project });

            var query1 = from left in Enumerable.Range(1, 4)
                from right in Enumerable.Range(11, left)
                select new { Left = left, Right = right };

            foreach (var q in query1)
            {
                Console.WriteLine("Left={0}; Right={1}", q.Left, q.Right);
            }

            var query2 = Enumerable.Range(1, 4).SelectMany(left => Enumerable.Range(11, left),
                (left, right) => new { Left = left, Right = right });
        }

        public void Group()
        {
            var query = from defect in SampleData.AllDefects
                where defect.AssignedTo != null
                group defect by defect.AssignedTo;

            var query2 = from defect in SampleData.AllDefects
                where defect.AssignedTo != null
                group defect.Summary by defect.AssignedTo;

            foreach (var entry in query2)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var summary in entry)
                {
                    Console.WriteLine("{0}",
                        summary);
                }

                Console.WriteLine();
            }


            var query1 = SampleData.AllDefects.Where(c => c.AssignedTo != null).GroupBy(c => c.AssignedTo);
            var query3 = SampleData.AllDefects.Where(c => c.AssignedTo != null)
                .GroupBy(c => c.AssignedTo, c => c.Summary);

            foreach (var entry in query)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var defect in entry)
                {
                    Console.WriteLine("({0}) {1}",
                        defect.Severity, defect.Summary);
                }

                Console.WriteLine();
            }
        }

        public void Continuations()
        {
            var query = from defect in SampleData.AllDefects
                where defect.AssignedTo != null
                group defect by defect.AssignedTo
                into grouped
                select new { Assignee = grouped.Key, Count = grouped.Count() };


            var query1 = from grouped in (from defect in SampleData.AllDefects
                    where defect.AssignedTo != null
                    group defect by defect.AssignedTo)
                select new { Assignee = grouped.Key, Count = grouped.Count() };

            var query3 = SampleData.AllDefects.Where(c => c.AssignedTo != null).GroupBy(c => c.AssignedTo)
                .Select(c => new { Assignee = c.Key, Count = c.Count() });


            var query4 = from defect in SampleData.AllDefects
                where defect.AssignedTo != null
                group defect by defect.AssignedTo
                into grouped
                select new { Assignee = grouped.Key, Count = grouped.Count() }
                into result
                orderby result.Count descending
                select result;

            var query5 = SampleData.AllDefects
                .Where(c => c.AssignedTo != null)
                .GroupBy(c => c.AssignedTo)
                .Select(c => new { Assignee = c.Key, Count = c.Count() })
                .OrderByDescending(c => c.Count);

            foreach (var entry in query)
            {
                Console.WriteLine("{0}: {1}", entry.Assignee, entry.Count);
            }
        }
    }
}