using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.part1
{
    public class QueryingCSharp2
    {
        public static void QueryIt()
        {
            List<ProductCSharp2> products = ProductCSharp2.GetSampleProducts();

            Predicate<ProductCSharp2> test = delegate(ProductCSharp2 p) { return p.Price > 10m; };

            List<ProductCSharp2> matches = products.FindAll(test);

            Action<ProductCSharp2> print = Console.WriteLine;

            matches.ForEach(print);


            products
                .FindAll(delegate(ProductCSharp2 p) { return p.Price > 10m; })
                .ForEach(Console.WriteLine);
        }
    }
}