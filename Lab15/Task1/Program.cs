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
            Console.WriteLine("Арифметическая прогрессия:");
            ArithProgression ap = new ArithProgression();
            ap.SetStart(0);
            ap.SetStep(1);
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            ap.Reset();
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            
            Console.WriteLine();
            
            Console.WriteLine("Геометрическая прогрессия:");
            GeomProgression gp = new GeomProgression();
            gp.SetStart(2);
            gp.SetStep(2);
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());
            gp.Reset();
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());

            Console.ReadKey();
        }
    }
}
