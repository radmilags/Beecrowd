using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int n = int.Parse(Console.ReadLine());
    int s = 0;
    int a;

    for (int i = 1; i <= n; i++)
    {
      a = int.Parse(Console.ReadLine());
      if (a % 2 == 0) Console.WriteLine(s);
      else Console.WriteLine(1);
    }
  }
}
