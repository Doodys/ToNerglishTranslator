using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerglishTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("King Mrgl-Mrgl is waiting for your question: ");
            string text = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(Translator.ToNerglishTranslator(AffineCipher.Encode(text, 5, 8)));
            Console.ReadKey();
        }
    }
}
