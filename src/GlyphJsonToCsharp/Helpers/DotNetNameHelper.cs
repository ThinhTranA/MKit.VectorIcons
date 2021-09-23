using System;
using System.Collections.Generic;
using Humanizer;

namespace GlyphJsonToCsharp.Helpers
{
    public static class DotNetNameHelper
    {
        public static string ToDotNetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            if (Char.IsDigit(name[0]))
            {
                name = DigitsToDotnetName(name);
            }
            
            var split = name.Split('-');

            string dotNetName = "";
            foreach (var s in split)
            {
                dotNetName += StringHelper.FirstCharToUpper(s);
            }

            return dotNetName;
        }

        private static string DigitsToDotnetName(string name)
        {
            var i = 0;
            while (Char.IsDigit(name[i]))
            {
                i++;
                if(i >= name.Length)
                    break;
            }

            var digits = int.Parse(name[..i]);
            var digitsWords = digits.ToWords().Pascalize();
            var remainWord = name[i..].FirstCharToUpper();
            return digitsWords + remainWord;
        }
    }
}
