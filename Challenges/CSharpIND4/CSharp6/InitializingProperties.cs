using System.Collections.Generic;

namespace Challenges.CSharpIND4.CSharp6
{
    public class InitializingProperties
    {
        //C#2
        private List<int> nums = new List<int>();

        public List<int> Nums
        {
            get { return nums; }
            set { nums = value; }
        }

        //C#3
        public List<int> nums3 { get; set; }

        public InitializingProperties()
        {
            nums3 = new List<int>();
        }

        //C#6
        public List<int> num6 { get; set; } = new List<int>();

        //ReadOnly one
        public List<int> num7 { get; } = new List<int>();
    }
}