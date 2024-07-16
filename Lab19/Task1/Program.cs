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
            const string fileName = @"C:\Temp\Products.json";
            List<Product> pcs = new List<Product>();
            
            pcs.AddRange(Product.LoadFromJson(fileName));

            Console.WriteLine("Компьютеры на складе:");
            foreach (Product pc in pcs)
            {
                Console.Write($"\tКод: {pc.Code}; ");
                Console.Write($"Марка: {pc.Brand,10}; ");
                Console.Write($"CPU: {pc.CpuType, 15}; ");
                Console.Write($"Количиство: {pc.Count,2}; ");
                Console.WriteLine();
            }
            Console.WriteLine();

            DoAnalytics(pcs);

            Console.ReadKey();
        }

        static void DoAnalytics(List<Product> products)
        {
            /* все компьютеры с указанным процессором. Название процессора запросить у пользователя; */
            Console.Write("Введите бренд процессора: ");
            string brand = Console.ReadLine();
            
            List<Product> filter = (from pc in products
                                         where pc.Brand.ToLower() == brand.ToLower()
                                         select pc).ToList();

            foreach (Product pc in filter) {
                Console.WriteLine($"{pc.Code}, {pc.Brand}");
            }
            Console.WriteLine();

            /* все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя; */
            Console.Write("Введите пороговый объем ОЗУ: ");
            byte ram = Convert.ToByte(Console.ReadLine());
            
            filter = products.Where(pc => pc.Ram >= ram).ToList();

            foreach (Product pc in filter)
            {
                Console.WriteLine($"{pc.Code}, {pc.Brand}, {pc.Ram}");
            }
            Console.WriteLine();

            /* вывести весь список, отсортированный по увеличению стоимости; */
            Console.WriteLine("Список, отсортированный по увеличению стоимости: ");
            foreach (Product pc in products.OrderBy(pc => pc.Price))
            {
                Console.WriteLine($"{pc.Code}, {pc.Brand}, {pc.Price}");
            }
            Console.WriteLine();

            /* вывести весь список, сгруппированный по типу процессора; */
            Console.WriteLine("Список, сгруппированный по типу процессора: ");
            foreach (var group in products.GroupBy(pc => pc.CpuType))
            {
                Console.WriteLine(group.Key);
                foreach (Product pc in group)
                {
                    Console.WriteLine($"\t{pc.Code}, {pc.Brand}");
                }
            }
            Console.WriteLine();

            /* найти самый дорогой и самый бюджетный компьютер; */
            Product pcMax = products.OrderByDescending(pc => pc.Price).FirstOrDefault();
            if (pcMax != null)
            {
                Console.WriteLine("Самый дорогой компьютер: {0} {1}", pcMax.Brand, pcMax.Price);
            }

            Product pcMin = products.OrderBy(pc => pc.Price).FirstOrDefault();
            if (pcMin != null)
            {
                Console.WriteLine("Самый бюджетный компьютер: {0} {1}", pcMin.Brand, pcMin.Price);
            }
            Console.WriteLine();

            /* есть ли хотя бы один компьютер в количестве не менее 30 штук? */
            if (products.Any(pc => pc.Count >= 30))
            {
                Console.WriteLine("На складе есть хотя бы один компьютер в количестве не менее 30 штук");
            }

        }
    }
}
