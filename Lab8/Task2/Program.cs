using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Программно создайте текстовый файл и запишите в него 10 случайных чисел.
             * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль. */

            string path = @"C:\Temp\rngNumbers.txt";
            
            GenerateNumbersInFile(path, 10);
            int s = GetNumbersSumFromFile(path);

            Console.WriteLine("Сумма чисел в файле: {0}", s);
            Console.ReadKey();
        }

        static void GenerateNumbersInFile(string path, byte lineCount)
        {
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < lineCount; i++)
                {
                    sw.WriteLine(random.Next(-10, 11));
                }
            }
        }

        static int GetNumbersSumFromFile(string path)
        {
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sum += Convert.ToInt32(line);
                }
            }
            return sum;
        }
    }
}
