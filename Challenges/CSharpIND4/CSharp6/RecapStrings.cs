using System;

namespace Challenges.CSharpIND4.CSharp6
{
    public class RecapStrings
    {
        public void Hello()
        {
            Console.WriteLine("what's is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);

            var name1 = string.Format("Hello, {0}!", name);
        }
    }
}