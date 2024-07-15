using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<string> account1 = new Account<string>();
            account1.SetNumber("N1");
            account1.SetName("Jhon");
            account1.SetBalance(1000);
            Console.WriteLine(account1.GetInfo());

            Console.WriteLine();

            Account<int> account2 = new Account<int>();
            account2.SetNumber(1001);
            account2.SetName("Alice");
            account2.SetBalance(99.99m);
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
