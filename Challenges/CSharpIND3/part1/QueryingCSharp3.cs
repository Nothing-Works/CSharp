using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.CSharpIND3.part1
{
    public class QueryingCSharp3
    {
        public static void QueryIt()
        {
            List<ProductCSharp3> products = ProductCSharp3.GetSampleProducts();
            foreach (ProductCSharp3 product in products.Where(c => c.Price > 10m))
            {
                Console.WriteLine(product);
            }
        }
    }
}