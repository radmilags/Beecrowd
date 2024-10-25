using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1871_Zero_Vale_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] z = Console.ReadLine().Split(' ');
            int a = int.Parse(z[0]); int b = int.Parse(z[1]);
            while (a != 0 && b != 0)
            {
                if (a != 0 && b != 0)
                {
                    int x = a + b; string s1 = x.ToString(); string[] s = s1.Split('0');
                    string s2 = "";
                    for (int i = 0; i < s.Length; i++) s2 += s[i];
                    Console.WriteLine(s2);
                    s2 = "";
                    z = Console.ReadLine().Split(' ');
                    a = int.Parse(z[0]); b = int.Parse(z[1]);
                }
            }
            Console.ReadKey();
        }
    }
}
