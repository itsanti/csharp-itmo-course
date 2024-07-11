using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
             * Знаки препинания не используются. Найти самое длинное слово в строке.*/
            
            Console.InputEncoding = Encoding.GetEncoding("utf-16");

            string s = Console.ReadLine();
            string maxWord = "";

            foreach (var word in s.Split(' '))
            {
                if (word.Length > maxWord.Length) { maxWord = word; }
            }
            
            Console.WriteLine("самое длинное слово в строке: {0}", maxWord);
            Console.ReadKey();
        }
    }
}
