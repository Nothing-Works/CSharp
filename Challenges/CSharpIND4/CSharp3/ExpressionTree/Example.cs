using System;
using System.Linq.Expressions;

namespace Challenges.CSharpIND4.CSharp3.ExpressionTree
{
    public class Example
    {
        Expression<Func<int, int, int>> adder = (x, y) => x + y;

        public void Go()
        {
            Console.WriteLine(adder);
            Func<int, int, int> compiled = adder.Compile();
            Console.WriteLine(compiled(2, 3));
            Console.WriteLine(compiled);
        }
    }
}