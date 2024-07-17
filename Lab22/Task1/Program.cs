using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        /*
         * Сформировать массив случайных целых чисел (размер  задается пользователем).
         * Вычислить сумму чисел массива и максимальное число в массиве. 
         * Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.
         */

        static void Main(string[] args)
        {
            Console.Write("Задайте размер массива: ");
            ushort n = Convert.ToUInt16(Console.ReadLine());

            Func<object, int[]> generateFunc = new Func<object, int[]>(GenerateArray);
            Task<int[]> generateTask = new Task<int[]>(generateFunc, n);

            Action<Task> sumAction = new Action<Task>((Task task) => ArraySum(generateTask.Result));
            Task sumTask = generateTask.ContinueWith(sumAction);

            Action<Task> maxAction = new Action<Task>((Task task) => ArrayMax(generateTask.Result));
            sumTask.ContinueWith(maxAction);

            generateTask.Start();

            Console.ReadKey();
        }

        static int[] GenerateArray(object arg)
        {
            ushort n = (ushort) arg;
            int[] numbers = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-100, 101);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            
            return numbers;
        }

        static void ArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма чисел: {sum}");
        }

        static void ArrayMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Максимальное число: {max}");
        }
    }
}
