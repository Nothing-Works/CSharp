using System;

namespace Challenges.CSharpIND4.CSharp2.Delegates
{
    public class DelegatesFrom1To2
    {
        delegate void TestDelegate(string s);


        private void Andy(string s)
        {
            Console.WriteLine(s);
        }

        public void Go1()
        {
            TestDelegate tl;
            tl = new TestDelegate(Andy);
            tl("haha");
        }


        public void Go2()
        {
            TestDelegate tl;
            tl = Andy;
            tl("haha");
        }

        public void Go3()
        {
            TestDelegate tl = delegate(string s) { Console.WriteLine(s); };

            tl("Test");
        }
    }
}