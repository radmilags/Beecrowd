using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string s;
    while(!string.IsNullOrEmpty(s = Console.ReadLine()))
    {
      int n = int.Parse(s);
      string[] s1 = Console.ReadLine().Split(' ');
      double h = double.Parse(s1[0]);
      double c = double.Parse(s1[1]);
      double l = double.Parse(s1[2]);
      double x = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(c, 2))*l*n;
      x /= 10000.0;
      Console.WriteLine($"{x:0.0000}");
    }
  }
}
