using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int r = 0; int s = 0; int c = 0; int x = 0;
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      string[] s1 = Console.ReadLine().Split(' ');
      int a = int.Parse(s1[0]);
      x += a;
      string b = s1[1];
      if(b == "C") c += a;
      if(b == "S") s += a;
      if(b == "R") r += a;
    }
    double pc = c*100.0/x;
    double ps = s*100.0/x;
    double pr = r*100.0/x;
    
    Console.WriteLine($"Total: {x} cobaias");
    Console.WriteLine($"Total de coelhos: {c}");
    Console.WriteLine($"Total de ratos: {r}");
    Console.WriteLine($"Total de sapos: {s}");
    Console.WriteLine($"Percentual de coelhos: {pc:0.00} %");
    Console.WriteLine($"Percentual de ratos: {pr:0.00} %");
    Console.WriteLine($"Percentual de sapos: {ps:0.00} %");
  }
}
