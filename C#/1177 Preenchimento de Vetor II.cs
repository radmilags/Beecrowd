using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int[] n  = new int[1000];
    int j = 0;
    int x = int.Parse(Console.ReadLine());
    for(int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"N[{i}] = {j}");
        j++;
        if (j == x) j = 0;
    }
  }
}
