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
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                GetIntNumber(out double x);
                GetIntNumber(out double y);
                GetOperation(out byte op);

                double result = Calculate(x, y, op);
                Console.WriteLine("Результат = {0:0.###}", result);
            }
            catch {}

            Console.ReadKey();
        }

        static double Calculate(double x, double y, byte op) {
            double result;
            switch (op)
            {
                case 1:
                    result = x + y;
                    break;
                case 2:
                    result = x - y;
                    break;
                case 3:
                    result = x * y;
                    break;
                case 4:
                    result = x / y;
                    if (Double.IsInfinity(result))
                    {
                        Console.WriteLine("Деление на 0");
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        static void GetIntNumber(out double num)
        {
            Console.Write("Введите операнд целое число: ");

            num = 0;

            try { 
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                throw ex;
            }
        }

        static void GetOperation(out byte op)
        {
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("\t1 – сложение\n\t2 – вычитание\n\t3 – произведение\n\t4 – частное");
            
            op = 0;
            
            try { 
                op = Convert.ToByte(Console.ReadLine());
                
                Console.WriteLine("Ваш выбор: {0}", op);

                if (op < 1 || op > 4)
                {
                    throw new Exception("Нет операции с указанным номером");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Нет операции с указанным номером");
                throw ex;
            }
        }
    }
}
