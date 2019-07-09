namespace Challenges.CSharpIND4.CSharp3
{
    public class AutoProperties
    {
        //C# 1 and 2.
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //C# 3 or higher.
        public string NameAuto { get; set; }

        public string NamePrivate { get; private set; }
    }
}