using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2694_Problema_com_a_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                string s = Console.ReadLine();
                int a = int.Parse(s.Substring(2, 2));
                int b = int.Parse(s.Substring(5, 3));
                int c = int.Parse(s.Substring(11, 2));
                Console.WriteLine(a + b + c);
            }
            Console.ReadKey();
        }
    }
}
