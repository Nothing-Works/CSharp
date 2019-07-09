namespace Challenges.CSharpIND3.CSharp3
{
    public class AutomaticProperties
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private static int InstanceCounter { get; set; }

        private static readonly object counterLock = new object();

        public void InstanceCountingAutomaticProperties(string name, int age)
        {
            Name = name;
            Age = age;

            lock (counterLock)
            {
                InstanceCounter++;
            }
        }
    }

    public struct Foo
    {
        public int Value { get; private set; }

        public Foo(int value)
        {
            this.Value = value;
        }
    }

    public struct Bar
    {
        public int Value { get; private set; }

        public Bar(int value) : this()
        {
            this.Value = value;
        }
    }
}