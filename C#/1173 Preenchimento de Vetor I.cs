using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int a = int.Parse(Console.ReadLine());
    int[] n = new int[10];
    for(int i = 0; i <= 9; i++)
    {
      n[i] = a;
      Console.WriteLine($"N[{i}] = {n[i]}");
      a *= 2;
    }
  }
}
