using System;
using System.Collections;

namespace Challenges.CSharpIND3.part1
{
    public class ProductNameCompareCSharp1 : IComparer
    {
        public int Compare(object x, object y)
        {
            ProductCSharp1 first = (ProductCSharp1) x;
            ProductCSharp1 second = (ProductCSharp1) y;

            return first.Name.CompareTo(second.Name);
        }

        public static void SortIt()
        {
            ArrayList products = ProductCSharp1.GetSampleProducts();
            products.Sort(new ProductNameCompareCSharp1());
            foreach (ProductCSharp1 product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}