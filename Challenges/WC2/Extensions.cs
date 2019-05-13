using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Challenges.WC2
{
    public static class Extensions
    {
        public static string ToApplicationPath(this string fileName)
        {
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return Path.Combine(appRoot, fileName);
        }
    }
}