﻿using Challenges.CSharpIND3.CSharp3.SimplifiedInitialization;
using System;

namespace Challenges.CSharpIND3.CSharp3.AnonymousType
{
    public class Example
    {
        public void Test1()
        {
            var person = new Person
            {
                Name = "Andy",
                Age = 30
            };

            var another = new
            {
                person.Name,
                IsAdult = (person.Age > 18)
            };
        }

        public void Test()
        {
            var tom = new { Name = "Tom", Age = 9 };
            var holly = new { Name = "Holly", Age = 36 };
            var jon = new { Name = "Jon", Age = 36 };
            Console.WriteLine("{0} is {1} years old", jon.Name, jon.Age);

            var family = new[]
            {
                new { Name = "Holly", Age = 36 },
                new { Name = "Jon", Age = 36 },
                new { Name = "Tom", Age = 9 },
                new { Name = "Robin", Age = 6 },
                new { Name = "William", Age = 6 }
            };

            int total = 0;

            foreach (var f in family)
            {
                total += f.Age;
            }

            Console.WriteLine(total);
        }
    }
}