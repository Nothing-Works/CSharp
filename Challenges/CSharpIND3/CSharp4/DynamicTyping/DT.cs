using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.CSharp4.DynamicTyping
{
    public class DT
    {
        public void GO()
        {
            dynamic items = new List<string> { "first", "second", "third" };
            dynamic valueToAdd = "!";
            dynamic valueToAdd1 = 2;

            foreach (dynamic item in items)
            {
                string result = item + valueToAdd + valueToAdd1;
                Console.WriteLine(result);
            }
        }
    }
}