using System;
using System.Collections.Generic;

namespace Challenges.CSharpIND3.part1
{
    public class ProductNameCompareCSharp2 : IComparer<ProductCSharp2>
    {
        public int Compare(ProductCSharp2 x, ProductCSharp2 y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public static void SortIt()
        {
            //with interface
            List<ProductCSharp2> products1 = ProductCSharp2.GetSampleProducts();
            products1.Sort(new ProductNameCompareCSharp2());
            foreach (ProductCSharp2 product in products1)
            {
                Console.WriteLine(product);
            }

            //with delegate
            List<ProductCSharp2> products2 = ProductCSharp2.GetSampleProducts();
            products2.Sort(delegate(ProductCSharp2 x, ProductCSharp2 y) { return x.Name.CompareTo(y.Name); });
            foreach (ProductCSharp2 product in products2)
            {
                Console.WriteLine(product);
            }
        }
    }
}