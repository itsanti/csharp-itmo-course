using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. */
             
            const int ArraySize = 15;
            Random random = new Random();

            int[] nums = new int[ArraySize];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(0, 51);
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();

            /* Определить сумму максимального и минимального элементов массива.*/
            int max = nums[0];
            int min = nums[0];

            foreach (var num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("Сумма максимального {0} и минимального {1} элементов равна {2}.", max, min, max + min);

            Console.ReadKey();
        }
    }
}
