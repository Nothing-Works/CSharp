using System;

namespace Challenges.CSharpIND4.CSharp4
{
    public class Dynamic4
    {
        public void CallDynamic()
        {
            dynamic example = new SimpleDynamicExample();
            example.CallSomeMethod("x", 10);
            Console.WriteLine(example.SomeProperty);
        }

        public void Go()
        {
            dynamic text = "hello world";
            string world = text.Substring(6);
            Console.WriteLine(world);

            string broken = text.SUBSTR(6);
            Console.WriteLine(broken);

            Add1("text");
            Add1(10);
            Add1(TimeSpan.FromMinutes(45));
        }


        private void Add1(dynamic d)
        {
            Console.WriteLine(d + d);
        }
    }
}