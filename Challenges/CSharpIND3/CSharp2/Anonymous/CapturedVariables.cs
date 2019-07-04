using System;

namespace Challenges.CSharpIND3.CSharp2.Anonymous
{
    public class CapturedVariables
    {
        public static void Go()
        {
            string captured = "before X is created";

            Action x = delegate
            {
                Console.WriteLine(captured);
                captured = "changed by x";
            };

            captured = "directly before x is invoked";

            x();

            Console.WriteLine(captured);

            captured = "before second invocation";

            x();
        }
    }
}