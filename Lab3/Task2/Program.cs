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
            Console.Write("Введите три точки на числовой оси A B C: ");
            string coordsLine = Console.ReadLine();
            string[] coords = coordsLine.Split(' ');

            int A = Convert.ToInt32(coords[0]);
            int B = Convert.ToInt32(coords[1]);
            int C = Convert.ToInt32(coords[2]);

            if (A == B && A == C)
            {
                Console.WriteLine("Все точки совпадают между собой.");
            }
            else if (B == C)
            {
                Console.WriteLine("Точки B и C совпадают между собой.");
            }
            else if (A == B || A == C)
            {
                char point = A == B ? 'B' : 'C';
                Console.WriteLine("Точки A и {0} совпадают между собой.", point);
            }
            else if (Math.Abs(A - B) == Math.Abs(A - C))
            {
                Console.WriteLine("Точки B и C равноотстоящие от A.");
            }
            else
            {
                char point = Math.Abs(A - B) < Math.Abs(A - C) ? 'B' : 'C';
                int distance = Math.Min(Math.Abs(A - B), Math.Abs(A - C));
                Console.WriteLine("Точка {0} расположена ближе к A. Расстояние между точками равно {1}.", point, distance);
            }

            Console.ReadKey();
        }
    }
}
