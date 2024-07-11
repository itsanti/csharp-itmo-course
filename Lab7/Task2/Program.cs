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
            /* Создать метод для вычисления объема и площади поверхности куба по длине его ребра. */

            Console.Write("Введите длину ребра куба: ");
            double A = Convert.ToDouble(Console.ReadLine());

            GetParamsCube(A, out double v, out double s);

            Console.WriteLine("Для куба с ребром {2}:\n - объем равен {0}\n - площадь поверхности {1} ", v, s, A);
            
            Console.ReadKey();

        }

        static void GetParamsCube(double a, out double v, out double s)
        {
            v = Math.Pow(a, 3);
            s = Math.Pow(a, 2) * 6;
        }
    }
}
