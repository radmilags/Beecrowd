using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int[] x = new int[10];
    for (int i = 0; i <= 9; i++)
    {
      x[i] = int.Parse(Console.ReadLine());
      if(x[i] == 0 || x[i] < 0) x[i] = 1;
      Console.WriteLine($"X[{i}] = {x[i]}");
    }
  }
}
