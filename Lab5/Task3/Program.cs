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
            /* Сформировать одномерный массив из 10 случайных чисел в диапазоне[-50; 50]. */
            const int ArraySize = 10;
            Random random = new Random();

            int[] nums = new int[ArraySize];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(-50, 51);
                Console.Write("{0,3} ", nums[i]);
            }
            Console.WriteLine();

            /* Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию. */
            for (int i = 0; i < nums.Length / 2 - 1; i++)
            {
                for (int j = i + 1; j < nums.Length / 2; j++)
                {
                    if (nums[i] > nums[j]) {
                        int t = nums[i];
                        nums[i] = nums[j];
                        nums[j] = t;
                    }
                }
            }
            for (int i = nums.Length / 2; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int t = nums[i];
                        nums[i] = nums[j];
                        nums[j] = t;
                    }
                }
            }

            foreach (int i in nums) {
                Console.Write("{0,3} ", i);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
