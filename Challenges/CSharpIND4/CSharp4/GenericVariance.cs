using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.CSharpIND4.CSharp4
{
    public class GenericVariance
    {
        public void Go()
        {
            //Variance

            //Covariance
            IEnumerable<string> strings = new List<string> { "a", "b", "c" };
            IEnumerable<object> objects = strings;


            //Contravariance
            Action<object> objectAction = c => Console.WriteLine(c);
            Action<string> stringAction = objectAction;

            stringAction("Andy");

            //IEnumerable values as only output,Action values as only input,IList values as both input and output. 

            //Invariance
            //will not work. as IList can do both input and output, whereas IEnumerable can only do output.
            //IList<string> lists = new List<string> { "a", "b", "c" };
            //IList<object> list1 = lists;
        }


        public void Example()
        {
            //before

            IEnumerable<string> strigns = new[] { "a", "b", "cdefg", "hij" };
            List<object> list = strigns.Where(c => c.Length > 1).Cast<object>().ToList();

            //after
            IEnumerable<string> strings1 = new[] { "a", "b", "cdefg", "hij" };
            List<object> list1 = strings1.Where(c => c.Length > 1).ToList<object>();
        }
    }
}