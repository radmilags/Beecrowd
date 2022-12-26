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
                double c = double.Parse(s[2]);
                double m = ((a * 2) + (b * 3) + (c * 5)) / 10;
                Console.WriteLine($"{m:0.0}");
            }

            Console.ReadKey();

        }
    }
}
