namespace Challenges.WC2
{
    public class User
    {
        public string FirstName { private get; set; }
        public string LastName { private get; set; }
        public int Age { private get; set; }
        public bool IsAlive { private get; set; }

        public string DisplayText
        {
            get
            {
                var aliveStatus = IsAlive ? "is alive" : "is dead";

                return $"{FirstName} {LastName} is {Age} and {aliveStatus}";
            }
        }
    }
}