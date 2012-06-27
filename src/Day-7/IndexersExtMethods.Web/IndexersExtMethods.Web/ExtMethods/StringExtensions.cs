using System;
using System.Globalization;

namespace IndexersExtMethods.Web.ExtMethods
{
    public static class StringExtensions
    {
        public static decimal ParseToDecimal(this string str)
        {
            return str.ParseToDecimal("en-US");
        }

        public static decimal ParseToDecimal(this string str, string cultureCode = default(string))
        {
            // If culture code is not informed
            if (cultureCode == default(string))
                cultureCode = "en-US";
            return Decimal.Parse(str, new CultureInfo(cultureCode));
        }

        public static bool ContainsIgnoreCase(this string str, string s)
        {
            return str.IndexOf(s, StringComparison.InvariantCultureIgnoreCase)
                != -1;
        }
    }
}