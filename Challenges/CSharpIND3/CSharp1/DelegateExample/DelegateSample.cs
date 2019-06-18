namespace Challenges.CSharpIND3.CSharp1.DelegateExample
{
    //1. declare delegate type
    delegate string GiveMeTheString(string s);

    class DelegateSample
    {
        //2. create a method
        string DoesNothing(string s)
        {
            return s;
        }

        void RunIt()
        {
            //3. create delegate instance
            GiveMeTheString del1;

            del1 = new GiveMeTheString(DoesNothing);

            //4. invoke the instance
            del1("Andy");
        }
    }
}