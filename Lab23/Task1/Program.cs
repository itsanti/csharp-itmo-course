using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        /* Разработать асинхронный метод для вычисления факториала числа.
         * В методе Main выполнить проверку работы метода.*/

        static void Main(string[] args)
        {

            FactorialAsync(17);
            FactorialAsync(5);

            Console.WriteLine("Вычислем факториалы. Для меньшего числа n вывод будет раньше.");

            Console.ReadKey();
        }

        static async void FactorialAsync(uint n)
        {
            await Task.Run(() => Factorial(n));
        }

        static void Factorial(uint n)
        {
            ulong result = 1;

            for (uint i = 2; i < n + 1; i++)
            {
                result *= i;
                Thread.Sleep(150);
            }

            Console.WriteLine($"Факториал n={n} равен {result}");
        }
        
    }
}
