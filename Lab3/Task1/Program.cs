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
            Console.Write("Введите координаты трёх вершин прямоугольника x1 y1 x2 y2 x3 y3: ");
            string coordsLine = Console.ReadLine();
            string[] coords = coordsLine.Split(' ');

            int x1 = Convert.ToInt32(coords[0]);
            int y1 = Convert.ToInt32(coords[1]);
            int x2 = Convert.ToInt32(coords[2]);
            int y2 = Convert.ToInt32(coords[3]);
            int x3 = Convert.ToInt32(coords[4]);
            int y3 = Convert.ToInt32(coords[5]);

            if (
                (x1 == x2 && x1 != x3 && y1 != y2) || (x1 == x3 && x1 != x2 && y1 != y3) || (x2 == x3 && x2 != x1 && y2 != y3) &&
                (y1 == y2 && y1 != y3 && x1 != x2) || (y1 == y3 && y1 != y2 && x1 != x3) || (y2 == y3 && y2 != y1 && x2 != x3)
            )
            {
                int x4, y4;
                if (x1 == x2)
                {
                    x4 = x3;
                }
                else if (x1 == x3)
                {
                    x4 = x2;
                }
                else
                {
                    x4 = x1;
                }

                if (y1 == y2)
                {
                    y4 = y3;
                }
                else if (y1 == y3)
                {
                    y4 = y2;
                }
                else
                {
                    y4 = y1;
                }
                Console.WriteLine("Координаты четвертой вершины прямоугольника: {0} {1}", x4, y4);
            }
            else
            {
                Console.WriteLine("Нельзя построить прямоугольник со сторонами, параллельными координатным осям.");
            }

            Console.ReadKey();
        }

    }
}
