using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
    class Program
    {
        static int n;
        static void Nhap()
        {
            do
            {
                Console.Write("Nhap n:");
                n = int.Parse(Console.ReadLine());
            } while (n <= 2);
        }
        static void SNT()
        {
            bool[] isPrime=new bool[n+1];
            for (int i = 0; i <= n; ++i)
            {
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i * i <= n; ++i)
            {
                if (isPrime[i] == true)
                {
                    for (int j = i * i; j <= n; j += i)
                        isPrime[j] = false;
                }
            }
            for(int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Nhap();
            SNT();
            Console.ReadKey();
        }
    }
}
