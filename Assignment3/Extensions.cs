using System;
using System.Linq;
namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri)
        {
            return uri.ToString().StartsWith("https");
        }
    }
}
