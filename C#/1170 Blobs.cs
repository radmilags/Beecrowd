using System;

class Program {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine()); int j = 0;
    double a;
    for(int i = 1; i <= n; i++)
    {
      a = double.Parse(Console.ReadLine());
      while(a > 1.00) {a /= 2; j++;}
      Console.WriteLine($"{j} dias");
      j = 0;
    }
  }
}
