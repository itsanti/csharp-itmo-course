using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        const byte width = 10;
        const byte height = width / 2;
        const byte gardenerSpeed = 10;

        static object locker = new object();

        static byte[,] garden = new byte[height, width];

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread1 = new Thread(threadStart);
            thread1.Name = "Gardener1";
            thread1.Start();

            threadStart = new ThreadStart(Gardener2);
            Thread thread2 = new Thread(threadStart);
            thread2.Name = "Gardener2";
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("\nРезультат работы садовников:");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(garden[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Gardener1()
        {
            for (byte i = 0; i < height; i++)
            {
                for (byte j = 0; j < width; j++)
                {
                    lock (locker)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name} works");
                        if (garden[i, j] == 0) garden[i, j] = 1;
                    }
                    Thread.Sleep(gardenerSpeed);
                  }
            }
        }

        static void Gardener2()
        {
            for (int i = width - 1; i >= 0; i--)
            {
                for (int j = height - 1; j >= 0; j--)
                {
                    lock (locker)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name} works");
                        if (garden[j, i] == 0) garden[j, i] = 2;
                    }
                    Thread.Sleep(gardenerSpeed);
                }
            }
        }
    }
}
