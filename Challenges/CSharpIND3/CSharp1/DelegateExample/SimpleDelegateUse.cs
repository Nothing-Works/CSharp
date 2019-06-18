namespace Challenges.CSharpIND3.CSharp1.DelegateExample
{
    class SimpleDelegateUse
    {
        public static void Test()
        {
            Person p1 = new Person("Andy");
            Person p2 = new Person("Tom");

            StringProcessor andyvoice, tomvoice, background;

            andyvoice = new StringProcessor(p1.Say);
            tomvoice = new StringProcessor(p2.Say);
            background = new StringProcessor(Background.Note);


            andyvoice("is the best");
            tomvoice.Invoke("is not really good");
            background("bull shit");
        }
    }
}