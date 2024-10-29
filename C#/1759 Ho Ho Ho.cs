using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
      if (i < n)Console.Write("Ho ");
      if (i == n) Console.WriteLine("Ho!");
    }
  }
}
