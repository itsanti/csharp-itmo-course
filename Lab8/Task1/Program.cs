using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Выберите любую папку на своем компьютере, имеющую вложенные директории.
             * Выведите на консоль ее содержимое и содержимое всех подкаталогов. */

            string path = @"C:\Temp";

            string[] items = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
