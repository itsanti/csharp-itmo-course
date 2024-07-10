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
            Console.WriteLine("Вводите целые числа пока не встретится 0.");

            int N;
            int pos = 0;
            int neg = 0;
            
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    pos++;
                }
                else if (N < 0)
                {
                    neg++;
                }
                Console.WriteLine("Ввели {0}. Положительных чисел: {1}. Отрицательных чисел {2}.", N, pos, neg);
            } while (N != 0);

            if (pos > neg)
            {
                Console.WriteLine("Положительных чисел в последовательности больше.");
            } else if (pos < neg)
            {
                Console.WriteLine("Отрицательных чисел в последовательности больше.");
            }

            Console.ReadKey();
        }
    }
}
