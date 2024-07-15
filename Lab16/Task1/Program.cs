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
            const string fileName = @"C:\Temp\Products.json";
            const byte size = 5;

            Product[] products = new Product[size];

            for (int i = 0; i < size; i++) {
                products[i] = InputProduct();
            }

            Product.SaveToJson(fileName, products);

            Console.ReadKey();
        }

        public static Product InputProduct()
        {
            Console.WriteLine("Введите код товара:");
            uint code = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите цену товара:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            return new Product() {Code = code, Title = title, Price = price };
        }

    }
}
