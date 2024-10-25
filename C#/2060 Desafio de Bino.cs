using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine()); int d = 0, t = 0, q = 0, c = 0; 
    string[] s = Console.ReadLine().Split(' ');
    for(int i = 0; i < n; i++)
    {
      if(int.Parse(s[i]) % 2 == 0) d++;
      if(int.Parse(s[i]) % 3 == 0) t++;
      if(int.Parse(s[i]) % 4 == 0) q++;
      if(int.Parse(s[i]) % 5 == 0) c++;
    }
    Console.WriteLine($"{d} Multiplo(s) de 2");
    Console.WriteLine($"{t} Multiplo(s) de 3");
    Console.WriteLine($"{q} Multiplo(s) de 4");
    Console.WriteLine($"{c} Multiplo(s) de 5");
  }
}
