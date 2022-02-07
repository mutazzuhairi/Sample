
using System.Text.RegularExpressions;

namespace Sample.DataLayer.DataUtilities.Extensions
{
    public static class StringExtensions
    {
        public static string Pluralize(this string value)
        {
            if (value.Length == 1)
                return value;
            else if (value.EndsWith("y"))
                return value.Substring(0, value.Length - 1) + "ies";
            return value + "s";
        }

        public static string GenerateSlug(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}
