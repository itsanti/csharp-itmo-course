using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. */

            const int ArraySize = 20;
            Random random = new Random();

            int[] nums = new int[ArraySize];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(-50, 51);
                Console.Write("{0,3} ", nums[i]);
            }
            Console.WriteLine();


            /* Определить количество нечетных положительных элементов, стоящих на четных местах. */
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 1 && (i + 1) % 2 == 0) {
                    k++;
                    Console.Write("{0} ", nums[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0}", k);
            Console.ReadKey();
        }
    }
}
