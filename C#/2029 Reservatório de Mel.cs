using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.Clear();
    string s, s1;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      double v = double.Parse(s);
      double d = double.Parse(Console.ReadLine());
      double r = d/2;
      double a = 3.14 * Math.Pow(r,2);
      double h = v/a;
      Console.WriteLine($"ALTURA = {h:0.00}");
      Console.WriteLine($"AREA = {a:0.00}");
    }
  }
}
