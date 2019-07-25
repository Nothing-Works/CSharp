namespace Challenges.CSharpIND3.CSharp3.Model
{
    public class Project
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Project: {0}", Name);
        }
    }
}