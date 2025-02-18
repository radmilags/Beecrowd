using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    double[] n = new double[100];
    for(int i = 0; i <= 99; i++)
    {
      n[i] = double.Parse(Console.ReadLine());
    }
    for(int i = 0; i <= 99; i++)
    {
      if(n[i] <= 10) Console.WriteLine($"A[{i}] = {n[i]:0.0}");
    }
  }
}
