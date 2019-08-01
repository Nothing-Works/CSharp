using System;
using System.Collections.Generic;

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
    }
}