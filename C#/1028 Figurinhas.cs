using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1028_Figurinhas
{
    class Program
    {
        public static int mdc(int F1, int F2)
        {
            int a = F1, b = F2, c;
            if (a < b) { a = F2; b = F1; }
            c = a % b;
            while (c != 0)
            { a = b; b = c; c = a % b; }
            return b;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]); int b = int.Parse(s[1]);
                Console.WriteLine(mdc(a, b));
            }
            Console.ReadKey();
        }
    }
}
