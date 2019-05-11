using System;
using System.Collections.Generic;

namespace Challenges.WC1
{
    public class ForeachLoop
    {
        private readonly List<string> _names = new List<string> {"Andy", "Joe", "Happy"};

        private readonly List<Person> _persons = new List<Person>
        {
            new Person {Name = "Rita", Address = "Auckland"},
            new Person {Name = "RuiQi", Address = "Auckland"},
            new Person {Name = "Angus", Address = "Auckland"},
            new Person {Name = "Angle", Address = "Auckland"},
            new Person {Name = "Paul", Address = "Auckland"}
        };

        public void Show()
        {
            foreach (var name in _names)
            {
                Console.WriteLine($"Hello {name}");
            }

            foreach (var person in _persons)
            {
                Console.WriteLine($"Hello {person.Name} from {person.Address}");
            }
        }
    }
}