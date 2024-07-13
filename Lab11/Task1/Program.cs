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
            Linear linear1 = new Linear(0, 0);
            Console.WriteLine(linear1.Root());

            Linear linear2 = new Linear(0, 1);
            Console.WriteLine(linear2.Root());

            Linear linear3 = new Linear(1, 0);
            Console.WriteLine(linear3.Root());

            Linear linear4 = new Linear(1, 2);
            Console.WriteLine(linear4.Root());

            Console.ReadKey();
        }
    }
}
