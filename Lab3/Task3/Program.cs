using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст в диапазоне 20-69: ");
            byte age = Convert.ToByte(Console.ReadLine());

            if (age < 20 || age > 69)
            {
                Console.WriteLine("Возраст находится вне диапазона!");
            }
            else
            {
                string msg = "";
                switch(age / 10)
                {
                    case 2: msg += "двадцать"; break;
                    case 3: msg += "тридцать"; break;
                    case 4: msg += "сорок"; break;
                    case 5: msg += "пятьдесят"; break;
                    case 6: msg += "шестьдесят"; break;
                }

                switch (age % 10)
                {
                    case 1: msg += " один"; break;
                    case 2: msg += " два"; break;
                    case 3: msg += " три"; break;
                    case 4: msg += " четыре"; break;
                    case 5: msg += " пять"; break;
                    case 6: msg += " шесть"; break;
                    case 7: msg += " семь"; break;
                    case 8: msg += " восемь"; break;
                    case 9: msg += " девять"; break;
                    default: break;
                }

                switch (age % 10)
                {
                    case 1: msg += " год"; break;
                    case 2:
                    case 3:
                    case 4:
                        msg += " года"; break;
                    default:
                        msg += " лет"; break;

                }
                Console.WriteLine(msg);
            }

            Console.ReadKey();
        }
    }
}
