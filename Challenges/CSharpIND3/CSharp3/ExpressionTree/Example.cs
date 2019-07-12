using System;
using System.Linq.Expressions;

namespace Challenges.CSharpIND3.CSharp3.ExpressionTree
{
    public class Example
    {
        Expression firstArg = Expression.Constant(2);
        Expression secondArg = Expression.Constant(3);

        public void Test()
        {
            Expression add = Expression.Add(firstArg, secondArg);


            Console.WriteLine("this is the expression tree");

            Console.WriteLine(add);

            Console.WriteLine("this is the func");

            Func<int> compiled = Expression.Lambda<Func<int>>(add).Compile();
            Console.WriteLine(compiled);

            Expression<Func<int>> return5 = () => 5;
            Func<int> returnf = () => 5;
            Func<int> compiled5 = return5.Compile();

            Console.WriteLine("here both");
            Console.WriteLine(return5);
            Console.WriteLine(returnf);
            Console.WriteLine(compiled5);

            Expression<Func<string, string, bool>> expression = (x, y) => x.StartsWith(y);
            Func<string, string, bool> expression1 = expression.Compile();
            Console.WriteLine(expression1("First", "Second"));
            Console.WriteLine(expression1("First", "Fir"));
        }
    }
}