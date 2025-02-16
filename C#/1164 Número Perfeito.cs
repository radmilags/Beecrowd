using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int soma = 0; int c;
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      int a = int.Parse(Console.ReadLine());
      c = a / 2;
      for (int j = 1; j <= c; j++)
      {
        if (a % j == 0) soma += j;
      }
      if (soma == a) Console.WriteLine($"{a} eh perfeito");
      else Console.WriteLine($"{a} nao eh perfeito");
      soma = 0;
    }
  }
}
