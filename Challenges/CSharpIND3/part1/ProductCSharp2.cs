using System.Collections.Generic;

namespace Challenges.CSharpIND3.part1
{
    public class ProductCSharp2
    {
        string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;

        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public ProductCSharp2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<ProductCSharp2> GetSampleProducts()
        {
            List<ProductCSharp2> list = new List<ProductCSharp2>();
            list.Add(new ProductCSharp2("West Side Story", 9.99m));
            list.Add(new ProductCSharp2("Assassins", 14.99m));
            list.Add(new ProductCSharp2("Frogs", 13.99m));
            list.Add(new ProductCSharp2("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", name, price);
        }
    }
}