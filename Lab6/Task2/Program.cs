using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
             * Знаки препинания не используются. Составить программу, определяющую является ли строка
             * палиндромом без учёта пробелов и регистра */
                /* Was it a car or a cat I saw */
                /* А роза упала на лапу Азора */

            Console.InputEncoding = Encoding.GetEncoding("utf-16");
            string s = Console.ReadLine();

            string original = s.Trim().ToLower().Replace(" ", "");
            string reversed = string.Join("", original.Reverse());

            if (original.Equals(reversed))
            {
                Console.WriteLine("Предложение палиндром:\n\t{0}\n\t{1}", original, reversed);
            }
            else
            {
                Console.WriteLine("Предложение не палиндром:\n\t{0}\n\t{1}", original, reversed);
            }
            
            Console.ReadKey();
        }
    }
}
