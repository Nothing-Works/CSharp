using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp5
{
    public class SmallFeatures
    {
        List<string> names = new List<string> { "x", "y", "z" };

        List<Action> cw = new List<Action>();
        List<Action> cw1 = new List<Action>();

        public void Run()
        {
            // one variable per iteration
            foreach (string name in names)
            {
                cw.Add(() => Console.WriteLine(name));
            }

            // this will throw ArgumentOutOfRange-Exception as i will be 3.
            for (int i = 0; i < names.Count; i++)
            {
                cw1.Add(() => Console.WriteLine(names[i]));
            }

            foreach (Action action in cw1)
            {
                action();
            }

            foreach (Action action in cw)
            {
                action();
            }
        }
    }
}