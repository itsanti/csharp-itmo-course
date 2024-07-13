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
            Angle A = new Angle(90, 120, 0);
            A.Sec = 72;
            Console.WriteLine("Gradus={0}, Min={1}, Sec={2}", A.Gradus, A.Min, A.Sec);
            Console.WriteLine(A.ToRadians());
        }
    }
}
