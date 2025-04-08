using System;

class MainClass 
{
  public static void Calcular (int v1, ref int v2)
  { 
    if (v1 == 1)
    {
      v2--;
    }
  }
  public static void Main (string[] args)
  {
    int a = int.Parse(Console.ReadLine());
    int b = a;
    for (int i = 1; i <= b; i++)
    {
      int x = int.Parse(Console.ReadLine());
      Calcular(x, ref a);
    }
    Console.WriteLine(a);  
  }
}
