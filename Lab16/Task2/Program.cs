using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = @"C:\Temp\Products.json";

            decimal maxPrice = decimal.MinValue;
            string maxPriceProduct = string.Empty;

            Console.WriteLine("Продукты из файла:");
            foreach (Product product in Product.LoadFromJson(fileName)) {
                Console.WriteLine($"Код: {product.Code}");
                Console.WriteLine($"Название: {product.Title}");
                Console.WriteLine($"Цена: {product.Price}");
                Console.WriteLine();

                if (product.Price > maxPrice)
                {
                    maxPrice = product.Price;
                    maxPriceProduct = product.Title;
                }
            }

            Console.WriteLine("Самый дорогой товар из файла: {0}, цена {1}", maxPriceProduct, maxPrice);

            Console.ReadKey();
        }
    }
}
