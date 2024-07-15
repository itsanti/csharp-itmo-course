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
            string ok = "he[ll]o (world) ({log} word)";

            if (BracketChecker.IsValid(ok))
            {
                Console.WriteLine("Верная скобочная последовательность");
            }
            else
            {
                Console.WriteLine("Неверная скобочная последовательность");
            }

            Console.ReadKey();
        }
    }
}
