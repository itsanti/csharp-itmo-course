using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Запросить у пользователя целочисленное значение N.
             * Сформировать двумерный массив размера NxN.
             * Заполнить массив числами, вводимыми с клавиатуры.*/
            Console.Write("Введите целое число N больше 0: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            int[,] field = new int[n, n];

            Console.WriteLine("Введетие NxN={0} чисел: ", n * n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            /* Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
             * Магическим квадратом называется матрица, сумма элементов которой
             * в каждой строке, в каждом столбце и по каждой диагонали одинакова. */
            
            int magicNumber = 0;
            bool isMagic = true;

            for (int i = 0; i < n; i++)
            {
                magicNumber += field[0, i];
            }

            int mainDiagSum = 0;
            int antiDiagSum = 0;

            for (int i = 0; i < n; i++)
            {
                int curRowSum = 0;
                for (int j = 0; j < n; j++)
                {
                    curRowSum += field[i, j];
                    if (i == j)
                    {
                        mainDiagSum += field[i, j];
                    }
                    if (i + j == n - 1)
                    {
                        antiDiagSum += field[i, j];
                    }
                }
                
                if (magicNumber != curRowSum)
                {
                    isMagic = false;
                    break;
                }
            }

            if (isMagic)
            {
                for (int j = 0; j < n; j++)
                {
                    int curColumnSum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        curColumnSum += field[i, j];
                    }
                    if (magicNumber != curColumnSum)
                    {
                        isMagic = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", field[i, j]);
                }
                Console.WriteLine();
            }

            if (isMagic && (mainDiagSum == antiDiagSum && magicNumber == mainDiagSum))
            {
                Console.WriteLine("Матрица является магическим квадратом с числом {0}", magicNumber);
            }
            else
            {
                Console.WriteLine("Матрица не является магическим квадратом");
            }

            Console.ReadKey();
        }
    }
}
