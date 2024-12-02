using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int[] n = new int[20];
    for(int i = 0; i <= 19; i++)
    {
      n[i] = int.Parse(Console.ReadLine());
    }
    Array.Reverse(n);
    for(int i = 0; i <= 19; i++)
    {
      Console.WriteLine($"N[{i}] = {n[i]}");
    }
  }
}
