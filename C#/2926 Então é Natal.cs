using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    Console.Write("Ent");
    for(int i = 1; i <= n; i++) Console.Write("a");
    Console.Write("o eh N");
    for(int i = 1; i <= n; i++) Console.Write("a");
    Console.Write("t");
    for(int i = 1; i <= n; i++)
    {
      if(i == n) Console.WriteLine("al!");
      else Console.Write("a");
    }
  }
}
