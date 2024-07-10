using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Сформировать одномерный массив из 7 элементов.
             * Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/
            const int ArraySize = 7;
            
            int[] nums = new int[ArraySize];
            float s = 0;

            Console.WriteLine("Введетие {0} чисел: ", ArraySize);

            for (int i = 0; i < nums.Length; i++) {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                s += nums[i];
            }

            Console.WriteLine("Среднее арифметическое элементов: {0:f3}",  s / ArraySize);
            Console.ReadKey();
        }
    }
}
