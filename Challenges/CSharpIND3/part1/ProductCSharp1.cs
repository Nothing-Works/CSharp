using System.Collections;

namespace Challenges.CSharpIND3.part1
{
    public class ProductCSharp1
    {
        string name;

        public string Name
        {
            get { return name; }
        }

        decimal price;

        public decimal Price
        {
            get { return price; }
        }

        public ProductCSharp1(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new ProductCSharp1("West Side Story", 9.99m));
            list.Add(new ProductCSharp1("Assassins", 14.99m));
            list.Add(new ProductCSharp1("Frogs", 13.99m));
            list.Add(new ProductCSharp1("Sweeney Todd", 10.99m));
            // from the compiler point of view, this is totally valid
            // list.Add("Andy");
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", name, price);
        }
    }
}