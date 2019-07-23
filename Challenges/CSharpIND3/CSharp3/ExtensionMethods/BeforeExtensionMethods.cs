using System.IO;
using System.Net;

namespace Challenges.CSharpIND3.CSharp3.ExtensionMethods
{
    public static class BeforeExtensionMethods
    {
        const int BufferSize = 8192;

        public static void Copy(Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream temStream = new MemoryStream())
            {
                Copy(input, temStream);
                return temStream.ToArray();
            }
        }

        public static void UseIt()
        {
            WebRequest request = WebRequest.Create("http://manning.com");
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                BeforeExtensionMethods.Copy(responseStream, output);
            }
        }
    }
}