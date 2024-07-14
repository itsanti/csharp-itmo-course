using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building lahta = new Building("Высотная улица, 1, Санкт-Петербург, 197229", 60, 60, 462);
            Console.WriteLine(lahta.Print());

            Console.WriteLine();

            MultiBuilding burjKhalifa = new MultiBuilding(
                "1 Sheikh Mohammed bin Rashid Blvd - Downtown Dubai - Dubai",
                168, 168, 828, 163
            );
            Console.WriteLine(burjKhalifa.Print());

            Console.ReadKey();

        }
    }
}
