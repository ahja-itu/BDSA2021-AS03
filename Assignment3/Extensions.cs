using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        // https://stackoverflow.com/questions/5692020/c-sharp-regex-match-whole-words
        private static Regex _wordRegex = new Regex(@"\b[a-z]+\b", RegexOptions.IgnoreCase);
        public static bool IsSecure(this Uri uri)
        {
            return uri.AbsoluteUri.ToString().StartsWith("https");
        }

        public static int WordCount(this string str)
        {
            return _wordRegex.Matches(str).Count();
        }            
    }
}
