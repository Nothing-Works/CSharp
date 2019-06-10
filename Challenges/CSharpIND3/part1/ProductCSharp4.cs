using System.Collections.Generic;

namespace Challenges.CSharpIND3.part1
{
    public class ProductCSharp4
    {
        readonly string name;

        public string Name
        {
            get { return name; }
        }

        readonly decimal price;

        public decimal Price
        {
            get { return price; }
        }

        public ProductCSharp4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<ProductCSharp4> GetSampleProducts()
        {
            return new List<ProductCSharp4>
            {
                new ProductCSharp4(name: "West Side Story", price: 9.99m),
                new ProductCSharp4(name: "Assassins", price: 14.99m),
                new ProductCSharp4(name: "Frogs", price: 13.99m),
                new ProductCSharp4(name: "Sweeney Todd", price: 10.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", name, price);
        }
    }
}