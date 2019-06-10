using System.Collections.Generic;

namespace Challenges.CSharpIND3.part1
{
    public class ProductCSharp3
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public ProductCSharp3(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        ProductCSharp3()
        {
        }

        public static List<ProductCSharp3> GetSampleProducts()
        {
            return new List<ProductCSharp3>
            {
                new ProductCSharp3 { Name = "West Side Story", Price = 9.99m },
                new ProductCSharp3 { Name = "Assassins", Price = 14.99m },
                new ProductCSharp3 { Name = "Frogs", Price = 13.99m },
                new ProductCSharp3 { Name = "Sweeney Todd", Price = 10.99m }
            };
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Price);
        }
    }
}