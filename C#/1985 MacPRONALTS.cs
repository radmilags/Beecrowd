using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double x = 0;
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      int a = int.Parse(s[0]);
      int b = int.Parse(s[1]);
      if (a == 1001) x = 1.50 * b + x;
      else if (a == 1002) x = 2.50 * b + x;
      else if (a == 1003) x = 3.50 * b + x;
      else if (a == 1004) x = 4.50 * b + x;
      else if (a == 1005) x = 5.50 * b + x;
    }
    Console.WriteLine($"{x:0.00}");
  }
}
