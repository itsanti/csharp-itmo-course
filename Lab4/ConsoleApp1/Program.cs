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
            Console.Write("Введите числа A B C: ");
            string numbersLine = Console.ReadLine();
            string[] numbers = numbersLine.Split(' ');

            int A = Convert.ToInt32(numbers[0]);
            int B = Convert.ToInt32(numbers[1]);
            int C = Convert.ToInt32(numbers[2]);

            int count = 0;

            if (C > A || C > B)
            {
                Console.WriteLine("Количество квадратов со строной С: {0}", count);
                Console.ReadKey();
                return;
            }

            int r = A;
            while (r >= C)
            {
                count++;
                r -= C;
            }

            r = B - C;
            int countA = count;
            while (r >= C)
            {
                count += countA;
                r -= C;
            }

            Console.WriteLine("Количество квадратов со строной С: {0}", count);
            Console.ReadKey();
        }
    }
}
