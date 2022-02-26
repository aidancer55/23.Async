using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);

            Console.ReadKey();
        }
        static void Fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine("Факториал числа {0}! равен {1}", n, fact);
        }
        static async void FactAsync(int n)
        {
            await Task.Run(() => Fact(n));
        }
    }
}
