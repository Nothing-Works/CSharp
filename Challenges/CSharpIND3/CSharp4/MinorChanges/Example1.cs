﻿using System;

namespace Challenges.CSharpIND3.CSharp4.MinorChanges
{
    public class Example1
    {
        public void Optional(int x, int y = 20, int z = 30)
        {
            Console.WriteLine("x={0}, y={1}, z={2},", x, y, z);
        }

        public void Named(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }

        public void Go()
        {
            Optional(1, 2, 3);
            Optional(1, 2);
            Optional(1);
            Named(s2: "second", s1: "first");
        }
    }
}