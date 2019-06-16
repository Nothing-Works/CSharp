using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.CSharpIND3.part1
{
    public class ProductNameCompareCSharp3
    {
        public static void SortIt()
        {
            List<ProductCSharp3> products = ProductCSharp3.GetSampleProducts();
            products.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (ProductCSharp3 product in products)
            {
                Console.WriteLine(product);
            }


            List<ProductCSharp3> products2 = ProductCSharp3.GetSampleProducts();
            foreach (ProductCSharp3 product in products2.OrderBy(c => c.Name))
            {
                Console.WriteLine(product);
            }
        }
    }
}