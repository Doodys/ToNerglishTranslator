using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerglishTranslator
{
    class AffineCipher
    {
        public static string Encode(string plainText, int a, int b)
        {
            CheckA(a);

            var text = "";
            foreach (var ch in plainText.ToLower().ToCharArray())
            {
                var en = Encode(ch, a, b);
                if (en != null) { text += en; }
            }

            return text;
        }
        private static char? Encode(char ch, int a, int b)
        {
            if (char.IsDigit(ch) || char.IsWhiteSpace(ch)) { return ch; }
            if (!char.IsLetter(ch)) { return null; }

            var x = ((ch - 'a') * a + b) % 26;
            return (char)('a' + x);
        }
        private static void CheckA(int a)
        {
            if (a % 2 == 0 || a % 13 == 0)
            {
                throw new ArgumentException("Error: keyA and alphabet size must be coprime.");
            }
        }
    }
}
