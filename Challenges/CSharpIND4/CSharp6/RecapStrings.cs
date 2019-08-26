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

        public void Money()
        {
            decimal price = 95.25m;
            decimal tip = price * 0.2m;
            Console.WriteLine("Price: {0,9:c}", price);
            Console.WriteLine("Tip: {0,9:c}", tip);
            Console.WriteLine("Total: {0,9:c}", tip + price);
        }
    }
}