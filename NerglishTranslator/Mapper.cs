using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerglishTranslator
{
    class Mapper
    {     
        public static Dictionary<int, char> NerglishMapper()
        {
            char[] alphabet = new char[5] { 'm', 'r', 'g', 'l', 'u' };
            Dictionary<int, char> mappedChars = new Dictionary<int, char>();
            int iTabIndex = 0, iCounter = 0;

            for(int i = 0; i < 127; i++, iCounter++)
            {
                mappedChars.Add(i, alphabet[iTabIndex]);

                if (iCounter.Equals(6))
                {
                    iCounter = 0;
                    iTabIndex++;
                    if (iTabIndex == alphabet.Length - 1) iTabIndex = 0;
                }
            }

            return mappedChars;
        }
    }
}
