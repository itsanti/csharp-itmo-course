using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal static class Circle
    {
        public static double Length(uint radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Area(uint radius)
        {
            return Math.PI * radius * radius;
        }

        public static bool IsPointWithinCirlce(double centerX, double centerY, uint radius, double x, double y)
        {
            return Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) <= radius * radius;
        }
    }
}
