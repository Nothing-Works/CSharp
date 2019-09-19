using System.Collections.Generic;

namespace Challenges.Practice.Part1
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}