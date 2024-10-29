using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int v1 = int.Parse(Console.ReadLine());
    int v2 = int.Parse(Console.ReadLine());
    if (v1 > v2)
    {
      int aux = v1;
      v1 = v2;
      v2 = aux;
    }
    for (int i = v1+1; i < v2; i++)
    {
      if (i % 5 == 2 || i % 5 == 3)
      {
        Console.WriteLine(i);
      }
    }
  }
}
