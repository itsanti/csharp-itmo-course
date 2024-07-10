using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Запросить у пользователя целочисленное значение N.
             * Сформировать двумерный массив размера NxN следующего вида (шахматы) */

            Console.Write("Введите целое число N больше 0: ");
            uint n = Convert.ToUInt32(Console.ReadLine());

            byte[,] field = new byte[n, n];
            
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                    {
                        field[i, j] = 1;
                    }
                    Console.Write("{0,4} ", field[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
