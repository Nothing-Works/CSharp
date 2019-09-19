using System.Collections.Generic;

namespace Challenges.Practice.Part1
{
    public static class DataSource
    {
        public static readonly IEnumerable<int> Numbers = new List<int> { 1, 2, 3, 4 };

        public static readonly IEnumerable<Order> Orders = new List<Order>
        {
            new Order { Id = 1, Total = 12 },
            new Order { Id = 2, Total = 32 },
            new Order { Id = 3, Total = 43 },
            new Order { Id = 4, Total = 54 },
            new Order { Id = 5, Total = 32 },
            new Order { Id = 6, Total = 54 },
            new Order { Id = 7, Total = 23 }
        };

        public static readonly IEnumerable<User> Users = new List<User>
        {
            new User
            {
                Id = 1, Name = "Andy2",
                Orders = new List<Order>
                {
                    new Order { Id = 1, Total = 12 },
                    new Order { Id = 2, Total = 32 },
                    new Order { Id = 3, Total = 43 },
                    new Order { Id = 4, Total = 54 },
                    new Order { Id = 5, Total = 32 },
                    new Order { Id = 6, Total = 54 },
                    new Order { Id = 7, Total = 23 }
                }
            },
            new User
            {
                Id = 2, Name = "Andy2", Orders = new List<Order>
                {
                    new Order { Id = 8, Total = 65 },
                    new Order { Id = 9, Total = 75 },
                    new Order { Id = 10, Total = 87 },
                    new Order { Id = 11, Total = 56 },
                    new Order { Id = 12, Total = 34 },
                    new Order { Id = 13, Total = 78 },
                    new Order { Id = 14, Total = 89 }
                }
            }
        };
    }
}