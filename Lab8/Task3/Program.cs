using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Вручную подготовьте текстовый файл с фрагментом текста.
             * Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте. */

            string path = @"C:\Temp\rngText.txt";

            if (GetTextStat(path, out uint lines, out uint words, out uint chars))
            {
                Console.WriteLine("статистика по файлу:");
                Console.WriteLine("\tколичество строк: {0}", lines);
                Console.WriteLine("\tколичество слов: {0}", words);
                Console.WriteLine("\tколичество символов: {0}", chars);
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }

            Console.ReadKey();

        }

        static bool GetTextStat(string path, out uint lines, out uint words, out uint chars) {
            lines = words = chars = 0;

            if (!File.Exists(path)) {
                return false;
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines++;
                    words += (uint) line.Split(' ').Length;
                    chars += (uint) line.Length;
                }
            }

            chars += lines; // add new line symbols like wc Linux do

            return true;
        }
    }
}
