using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerglishTranslator
{
    class Translator
    {
        public static string ToNerglishTranslator(string text)
        {
            Dictionary<int, char> _mappedChars = Mapper.NerglishMapper();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(text);
            string sTranslatedText = "";

            foreach(byte asciiValue in asciiBytes)
            {
                var cNewChar = _mappedChars.FirstOrDefault(x => x.Key == asciiValue).Value;
                //Console.WriteLine(cNewChar.ToString() + " - " + asciiValue);

                if (asciiValue.Equals(32)) sTranslatedText += " ";
                else sTranslatedText += cNewChar.ToString();
            }

            return sTranslatedText;
        }
    }
}
