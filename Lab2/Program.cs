using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Console.ReadKey();

            Task2();
            Console.WriteLine();
            Console.ReadKey();

            Task3();
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.Write("Введите длину окружности: ");
            double L = Convert.ToDouble(Console.ReadLine());
            double R = L / (2 * Math.PI);
            double A = Math.PI * R * R;
            Console.WriteLine($"Если длина окружности L={L:0.###}, то радиус R={R:0.###}, а площадь A={A:0.###}.");
        }

        static void Task2()
        {
            Console.Write("Введите координаты двух противоположных вершин прямоугольника x1 y1 x2 y2: ");
            string coordsLine = Console.ReadLine();
            string[] coords = coordsLine.Split(' ');
            
            double x1 = Convert.ToDouble(coords[0]);
            double y1 = Convert.ToDouble(coords[1]);
            double x2 = Convert.ToDouble(coords[2]);
            double y2 = Convert.ToDouble(coords[3]);

            double P = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1)) * 2;
            double A = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

            Console.Write("Для вершин ({0:0.###}, {1:0.###}), ({2:0.###}, {3:0.###}) ", x1, y1, x2, y2);
            Console.WriteLine("периметр прямоугольника равен {0:0.###}, а площадь {1:0.###}", P, A);
        }

        static void Task3()
        {
            Console.Write("Введите координаты трёх вершин треугольника x1 y1 x2 y2 x3 y3: ");
            string coordsLine = Console.ReadLine();
            string[] coords = coordsLine.Split(' ');

            double x1 = Convert.ToDouble(coords[0]);
            double y1 = Convert.ToDouble(coords[1]);
            double x2 = Convert.ToDouble(coords[2]);
            double y2 = Convert.ToDouble(coords[3]);
            double x3 = Convert.ToDouble(coords[4]);
            double y3 = Convert.ToDouble(coords[5]);

            double AB = Distance(x1, y1, x2, y2);
            double BC = Distance(x2, y2, x3, y3);
            double AC = Distance(x1, y1, x3, y3);

            double P = AB + BC + AC;
            
            double P2 = P / 2;
            double A = Math.Sqrt(P2 * (P2 - AB) * (P2 - BC) * (P2 - AC));

            Console.Write($"Для треугольника со сторонами AB={AB:0.###} BC={BC:0.###} AC={AC:0.###} ");
            Console.WriteLine($"периметр P={P:0.###}, площадь A={A:0.###}");
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
