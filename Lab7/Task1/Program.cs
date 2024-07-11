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
            /* Два треугольника заданы длинами своих сторон.
             * Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
             * Для решения задачи можно использовать формулу Герона */
            
            double[] triangle1 = GetInput();
            double area1 = CalcArea(triangle1[0], triangle1[1], triangle1[2]);

            double[] triangle2 = GetInput();
            double area2 = CalcArea(triangle2[0], triangle2[1], triangle2[2]);

            if (area1 < area2)
            {
                Console.WriteLine("Площадь треугольника 2 больше.");
            }
            else if (area1 > area2) {
                Console.WriteLine("Площадь треугольника 1 больше.");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }

            Console.ReadKey();
        }

        static double[] GetInput()
        {
            Console.Write("Введите длины сторон треугольника A, B и C: ");
            string line = Console.ReadLine();
            string[] sides = line.Split(' ');

            double a = Convert.ToDouble(sides[0]);
            double b = Convert.ToDouble(sides[1]);
            double c = Convert.ToDouble(sides[2]);

            return new double[]{a, b, c};
        }

        static double CalcArea(double a, double b, double c) {
            double P = a + b + c;
            double P2 = P / 2;
            return Math.Sqrt(P2 * (P2 - a) * (P2 - b) * (P2 - c));
        }
    }
}
