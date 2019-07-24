using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.CSharpIND4.CSharp3.ExtensionMethods
{
    public class Example
    {
        string[] words = { "keys", "coat", "laptop", "bottle" };

        public void Test()
        {
            IEnumerable<string> query = words.Where(c => c.Length > 4)
                .OrderBy(c => c)
                .Select(c => c.ToUpper());

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }
    }
}