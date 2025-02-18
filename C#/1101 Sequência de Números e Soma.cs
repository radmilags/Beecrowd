using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int m = 0; int n = 0; int aux = 0; int soma = 0;
    do
    {
      string[] s = Console.ReadLine().Split(' ');
      m = int.Parse(s[0]);
      n = int.Parse(s[1]);
      if((m != 0 && n != 0) && (m > 0 && n > 0))
      {
        if (n < m) {aux = n; n = m; m = aux;}
        for(int i = m; i <= n; i++)
        {
          soma += i;
          Console.Write($"{i} ");
        }
        Console.WriteLine($"Sum={soma}");
      }
      soma = 0;
    }while((m != 0 && n != 0) && (m > 0 && n > 0));
  }
}
