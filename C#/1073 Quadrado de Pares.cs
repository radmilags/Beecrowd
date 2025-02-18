using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int x = 0;

    if (n > 5 && n < 2000)
    {
      for(int i = 2; i <= n; i += 2)
      {
        x = i*i;
        // Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
        Console.WriteLine($"{i}^2 = {x}");
        x = 0;
      }
    }
  }
}
