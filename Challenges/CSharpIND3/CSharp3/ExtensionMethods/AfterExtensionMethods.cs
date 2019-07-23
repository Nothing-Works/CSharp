using System;
using System.IO;
using System.Net;

namespace Challenges.CSharpIND3.CSharp3.ExtensionMethods
{
    public static class AfterExtensionMethods
    {
        const int BufferSize = 8192;

        public static void CopyTo1(this Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];

            int read;

            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }


        public static byte[] ReadFully(this Stream input)
        {
            using (MemoryStream temStream = new MemoryStream())
            {
                //CopyTo(input, temStream);
                input.CopyTo1(temStream);
                return temStream.ToArray();
            }
        }

        public static bool IsNull(this object x)
        {
            return x == null;
        }

        public static void UseIt()
        {
            object x = null;
            Console.WriteLine(x.IsNull());
            object y = new object();
            Console.WriteLine(y.IsNull());

            WebRequest request = WebRequest.Create("http://manning.com");

            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                responseStream.CopyTo1(output);
            }
        }
    }
}