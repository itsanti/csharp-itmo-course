using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    internal class Program
    {
        delegate double CircleDelegate(double r);

        static void Main(string[] args)
        {
            CircleDelegate circleDelegate = CircleLength;
            double result = circleDelegate(2);
            Console.WriteLine(result);

            Func<double, double> calculate = CircleLength;
            calculate += CircleArea;
            calculate += CircleVolume;

            foreach (Func<double, double> func in calculate.GetInvocationList())
            {
                Console.WriteLine(func(1));
            }

            Console.ReadKey();
        }

        static double CircleLength(double r) => 2 * Math.PI * r;

        static double CircleArea(double r) => Math.PI * r * r;

        static double CircleVolume(double r)
        {
            return Math.PI * Math.Pow(r, 3) * 4/3;
        }
    }
}
