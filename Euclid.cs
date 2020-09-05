using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    class Program
    {
        static int Tinh(int a, int b)
        {
            if (b == 0) return a;
            return Tinh(b, a % b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(Tinh(a, b));
            Console.ReadKey();
        }
    }
}
