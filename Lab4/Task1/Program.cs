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
            Console.Write("Введите целое число N > 0: ");
            uint N = Convert.ToUInt32(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= N; i++)
            {
                s += 2 * i - 1;
                Console.WriteLine("{0} {1}", i, s);
            }

            Console.ReadKey();
        }
    }
}
