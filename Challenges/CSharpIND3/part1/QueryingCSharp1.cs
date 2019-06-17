using System;
using System.Collections;

namespace Challenges.CSharpIND3.part1
{
    public class QueryingCSharp1
    {
        public static void QueryIt()
        {
            ArrayList products = ProductCSharp1.GetSampleProducts();
            foreach (ProductCSharp1 product in products)
            {
                if (product.Price > 10m)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}