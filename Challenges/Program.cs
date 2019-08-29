using Challenges.CSharpIND3.CSharp3.ExpressionTree;
using Challenges.CSharpIND3.CSharp3.IEnumerableExample;
using Challenges.CSharpIND3.CSharp4.DynamicTyping;
using Challenges.CSharpIND3.CSharp4.MinorChanges;
using Challenges.CSharpIND4.CSharp2.Iterators;
using Challenges.CSharpIND4.CSharp3.ObjectInitializer;
using Challenges.CSharpIND4.CSharp4;
using Challenges.CSharpIND4.CSharp6;
using System;
using System.Globalization;

namespace Challenges
{
    public static class Program
    {
        private static void Main()
        {
            //new ExceptionFilters().Test();
            new ExceptionFilters().Go();
            new FinallyBlocks().PrintTwo();
            var a = new ProcessOrder().Process();
            Console.WriteLine(a.Customer.Name);
            new Example().Test();
            new ExampleMethods().Test();
            new CSharpIND3.CSharp3.Queries.Example().Continuations();
            new Example1().Go();
            new DT().GO();
            new Dynamic4().CallDynamic();
            new CSharpIND3.CSharp5.Example().Sync();
            new CSharpIND4.CSharp5.Example().Async();
            Console.ReadLine();

            DateTime date = DateTime.UtcNow;
            string parameter2 =
                ((FormattableString) $"x={date:yyyy-MM-dd}")
                .ToString(CultureInfo.InvariantCulture);
            string parameter1 =
                $"x={date:yyyy-MM-dd}"
                    .ToString(CultureInfo.InvariantCulture);


            var culture = CultureInfo.GetCultureInfo("en-GB");
            decimal price = 95.25m;

            FormattableString formattableString = $"Price: {price,9:c}";
            var result = formattableString.ToString(culture);
            Console.WriteLine(result);

            string s = $"Price: {price,9:c}";
            var another = s.ToString(culture);
            Console.WriteLine(another);
            new NameOfExample().Test();
        }
    }
}