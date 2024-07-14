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
            Console.WriteLine("Длина окружности: {0:0.000}", Circle.Length(1));
            Console.WriteLine("Площадь круга: {0:0.000}", Circle.Area(2));

            if (Circle.IsPointWithinCirlce(0, 0, 1, 0.5, 0.5))
            {
                Console.WriteLine("Точка внутри круга");
            }
            else
            {
                Console.WriteLine("Точка вне круга");
            }
            
            Console.ReadKey();
        }
    }
}
