using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intervalo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                double a = double.Parse(s[0]);
                double b = double.Parse(s[1]);

                if (b == 0) Console.WriteLine("divisao impossivel");
                else
                {
                    double x = a / b;
                    Console.WriteLine($"{x:0.0}");
                }
            }

        }
    }
}
