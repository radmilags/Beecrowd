using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int n = int.Parse(Console.ReadLine());
    int a = 1; int b = 2; int c = 3;

    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine($"{a} {b} {c} PUM");
      a += 4; b += 4; c += 4;
    }
  }
}
