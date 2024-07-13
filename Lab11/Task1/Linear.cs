using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal struct Linear
    {
        /* Разработать структуру для решения линейного уравнения 0=kx+b */
        /* Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. */

        double k;
        double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            string result = String.Format("При k={0} и b={1} уравнение 0=kx+b", k, b);
            if (k == 0) {
                if (b == 0)
                {
                    result += " имеет множество решений.";
                }
                else
                {
                    result += " не имеет решений.";
                }
            }
            else
            {
                double x = -b / k;
                result += $" имеет решение x={x}.";
            }
            return result;
        }
    }
}
