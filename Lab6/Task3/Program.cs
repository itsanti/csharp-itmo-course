using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
             * В строке может быть несколько фрагментов, заключённых в фигурные скобки.
             * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала. */

            string S = "Из строки требуется {да {удалить текст}}, заключенный в {фигурные} скобки";
            Console.WriteLine(RemoveBracketsText(S));
            Console.ReadKey();
        }

        static string RemoveBracketsText(string text)
        {
            int openBrackets = 0;
            int closeBrackets = 0;
            int startIndex = 0;
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '{')
                {
                    if (openBrackets == 0)
                    {
                        result += text.Substring(startIndex, i - startIndex);
                    }
                    openBrackets++;
                }
                else if (text[i] == '}')
                {
                    closeBrackets++;
                    if (openBrackets > 0 && openBrackets == closeBrackets)
                    {
                        openBrackets = 0;
                        closeBrackets = 0;
                        startIndex = i + 1;
                    }
                }
            }

            if (startIndex < text.Length)
            {
                result += text.Substring(startIndex);
            }

            return result;
        }
    }
}
