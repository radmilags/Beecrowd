using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string[] ler = Console.ReadLine().Split(' ');
    int v1 = int.Parse(ler[0]);
    int v2 = int.Parse(ler[1]);
    for (int x = 1; x <= v2; x++)
    {
      if (x % v1 == 0) Console.WriteLine(x);
      else Console.Write($"{x} ");
    }
  }
}
