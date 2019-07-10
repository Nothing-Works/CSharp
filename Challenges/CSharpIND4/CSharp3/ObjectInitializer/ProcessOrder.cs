using System;
using System.Net.Http;

namespace Challenges.CSharpIND4.CSharp3.ObjectInitializer
{
    public class ProcessOrder
    {
        public Order Process()
        {
            HttpClient client = new HttpClient
            {
                DefaultRequestHeaders = { From = "user@example.com", Date = DateTimeOffset.UtcNow }
            };

            var client1 = new HttpClient();
            var header = client1.DefaultRequestHeaders;
            header.From = "user@example.com";
            header.Date = DateTimeOffset.UtcNow;

            //old way
            Customer c1 = new Customer();
            c1.Name = "Jon";
            c1.Address = "UK";

            OrderItem oi1 = new OrderItem();
            oi1.ItemId = "abc123";
            oi1.Quantity = 1;

            OrderItem oi2 = new OrderItem();
            oi2.ItemId = "fghi456";
            oi2.Quantity = 2;

            Order o = new Order();
            o.OrderId = "xyz";
            o.Customer = c1;
            o.Items.Add(oi1);
            o.Items.Add(oi2);

            //after C# 3.

            Order o2 = new Order
            {
                OrderId = "zxc",
                Customer = new Customer { Address = "UK", Name = "Andy" },
                Items =
                {
                    new OrderItem { Quantity = 1, ItemId = "123" },
                    new OrderItem { Quantity = 2, ItemId = "222" }
                }
            };

            return o2;
        }
    }
}