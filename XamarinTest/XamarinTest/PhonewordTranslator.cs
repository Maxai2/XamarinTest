using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinTest
{
    public static class PhonewordTranslator
    {
        public static string FromWordToNumber(this string pw)
        {
            if (String.IsNullOrWhiteSpace(pw))
            {
                return null;
            }

            pw = pw.ToUpper();

            var result = new StringBuilder();
            foreach (var character in pw)
            {
                if (" -1234567890".Contains(character))
                {
                    result.Append(character);
                }
                else
                {
                    var tranlated = Translate(character);
                    if (tranlated != null)
                    {
                        result.Append(tranlated);
                    }
                    else
                        return "INVALID NUMBER!";
                }
            }

            return result.ToString();
        }

        static int? Translate(char symbol)
        {
            var digits = new string[] { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

            for (int i = 0; i < digits.Length; ++i)
            {
                if (digits[i].Contains(symbol))
                {
                    return 2 + i;
                }
            }

            return null;    
        }
    }
}
