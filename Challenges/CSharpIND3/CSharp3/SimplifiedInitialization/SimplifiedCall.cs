using System.Collections.Generic;

namespace Challenges.CSharpIND3.CSharp3.SimplifiedInitialization
{
    public class SimplifiedCall
    {
        public void SimplifiedCollection()
        {
            //before 
            List<string> array = new List<string>();
            array.Add("1");
            array.Add("2");
            array.Add("3");
            array.Add("4");
            array.Add("5");
            array.Add("6");
            array.Add("7");

            //after 
            var array1 = new List<string>
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6"
            };

            Person tom = new Person
            {
                Name = "Tom",
                Age = 9,
                Home = { Country = "UK", Town = "Reading" },
                Friends =
                {
                    new Person { Name = "Alberto" },
                    new Person("Max"),
                    new Person { Name = "Zak", Age = 7 },
                    new Person("Ben"),
                    new Person("Alice")
                    {
                        Age = 9,
                        Home = { Town = "Twyford", Country = "UK" }
                    }
                }
            };
        }

        public void Test()
        {
            //Before C# 3.
            Person tom1 = new Person();
            tom1.Name = "Tom";
            tom1.Age = 9;

            Person tom2 = new Person("Tom");
            tom2.Age = 9;


            Person tomHome1 = new Person("Tom");
            tomHome1.Age = 9;
            tomHome1.Home.Country = "UK";
            tomHome1.Home.Town = "Reading";

            //After C# 3.
            Person tom3 = new Person() { Name = "Tom", Age = 9 };
            Person tom4 = new Person { Name = "Tom", Age = 9 };
            Person tom5 = new Person("Tom") { Age = 9 };

            Person tomHome2 = new Person("Tom")
            {
                Age = 9,
                Home = { Country = "UK", Town = "Reading" }
            };
        }
    }
}