using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp3.ObjectInitializer
{
    public class Order
    {
        private readonly List<OrderItem> items = new List<OrderItem>();
        public string OrderId { get; set; }

        public Customer Customer { get; set; }

        public List<OrderItem> Items
        {
            get { return items; }
        }
    }
}