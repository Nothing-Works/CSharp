using System;

namespace Challenges.CSharpIND3.CSharp1.DelegateExample
{
    delegate void StringProcessor(string input);

    class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void Say(string input)
        {
            Console.WriteLine("{0} says: {1}", name, input);
        }
    }

    class Background
    {
        public static void Note(string input)
        {
            Console.WriteLine("{0}", input);
        }
    }
}