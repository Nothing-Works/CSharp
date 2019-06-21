using System;
using System.Collections;
using System.Collections.Specialized;

namespace Challenges.CSharpIND4.CSharp2.Generics
{
    public class BeforeGenerics
    {
        public static string[] GenerateNamesArray()
        {
            string[] names = new string[4];
            names[0] = "Gamma";
            names[1] = "Vlissides";
            names[2] = "Johnson";
            names[3] = "Helm";

            return names;
        }

        public static void PrintNamesArray(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        public static ArrayList GenerateNamesArrayList()
        {
            ArrayList names = new ArrayList();

            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");

            return names;
        }

        public static void PrintNamesArrayList(ArrayList names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        public static StringCollection GenerateNamesSC()
        {
            StringCollection names = new StringCollection();

            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");

            return names;
        }

        public static void PrintNamesSC(StringCollection names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}